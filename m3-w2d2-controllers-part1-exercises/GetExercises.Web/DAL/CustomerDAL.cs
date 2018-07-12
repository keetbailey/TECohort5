using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GetExercises.Web.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        private string connectionString;
        private string custSqlDal = "Select first_name, last_name, email, activebool FROM customer"; //SQL statement 

        public CustomerDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Customer> SearchForCustomers(string search, string sortBy)
        {
            IList<Customer> custSearch = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(custSqlDal, conn);
                cmd.Parameters.AddWithValue("@first_name", search + sortBy);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    custSearch.Add(MapRowToCustomer(reader));
                }
            }
            return null;
        }
        private Customer MapRowToCustomer(SqlDataReader reader)
        {
            return new Customer()
            {
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"])
            };
        }
    }
}