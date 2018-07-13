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
        private string emailSqlDal = "SELECT first_name, last_name, email, activebool FROM customer WHERE first_name LIKE @first_name OR last_name LIKE @last_name ORDER BY email"; //SQL statement 
        private string isActiveSqlDal = "SELECT first_name, last_name, email, activebool FROM customer WHERE first_name LIKE @first_name OR last_name LIKE @last_name ORDER BY activebool";
        private string lastNameSqlDal = "SELECT first_name, last_name, email, activebool FROM customer WHERE first_name LIKE @first_name OR last_name LIKE @last_name ORDER BY last_name";

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
                SqlCommand cmd = new SqlCommand();

                if (sortBy == "email")
                {
                    cmd.CommandText = emailSqlDal;
                    cmd.Connection = conn;
                }
                else if(sortBy == "activebool")
                {
                    cmd.CommandText = isActiveSqlDal;
                    cmd.Connection = conn; 
                }
                else
                {
                    cmd.CommandText = lastNameSqlDal;
                    cmd.Connection = conn; 
                }

                cmd.Parameters.AddWithValue("first_name", "%" + search + "%");
                cmd.Parameters.AddWithValue("last_name", "%" + search + "%");


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    custSearch.Add(MapRowToCustomer(reader));
                }
            }
            return custSearch;
        }
        private Customer MapRowToCustomer(SqlDataReader reader)
        {
            return new Customer()
            {
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"]),
                Email = Convert.ToString(reader["email"]),
                IsActive = Convert.ToBoolean(reader["activebool"])
            };
        }
    }
}