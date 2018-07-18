using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        private readonly string connectionString;
        private const string SQL_AllReviews = "SELECT * FROM reviews";
        private const string SQL_InsertReview = "INSERT INTO reviews VALUES(@username, @rating, @review_title, @review_text, @review_date);";

        public ReviewSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Review> GetAllReviews()
        {
            IList<Review> reviews = new List<Review>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_AllReviews, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())                                 
                    {
                        Review review = new Review();
                        review.Username = Convert.ToString(reader["username"]);
                        review.Rating = Convert.ToInt32(reader["rating"]);
                        review.Message = Convert.ToString(reader["review_text"]);
                        review.Title = Convert.ToString(reader["review_title"]);
                        review.ReviewDate = Convert.ToDateTime(reader["review_date"]);
                        reviews.Add(review);
                    }
                }
                return reviews;
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
        public bool SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_InsertReview, conn);

                    cmd.Parameters.AddWithValue("@username", newReview.Username);  //will need to revisit to ensure newReview. is correct
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@review_title", newReview.Title);
                    cmd.Parameters.AddWithValue("@review_text", newReview.Message);
                    cmd.Parameters.AddWithValue("@review_date", DateTime.UtcNow);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {

                throw;
            }
        }
    }
}
