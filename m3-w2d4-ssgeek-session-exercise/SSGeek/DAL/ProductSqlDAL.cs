using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;

namespace SSGeek.DAL
{
    public class ProductSqlDAL : IProductDAL
    {
        public readonly string connectionString;
        private string productSQLSelect = "SELECT * FROM products WHERE product_id = @productID";
        private string productListSQL = "SELECT * FROM products";

        public ProductSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Product GetProduct(int id)
        {
            Product product = null;
        
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(productSQLSelect, conn);
                    cmd.Parameters.AddWithValue("@product_id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        product = AddNewProduct(reader);
                    }

                }
            }

            catch(SqlException ex)
            {
                throw;
            }

            return product;
        }
       
        public List<Product> GetProducts()
        {
            List<Product> product = new List<Product>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(productListSQL, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        product.Add(AddNewProduct(reader));
                    }

                }
            }

            catch (SqlException ex)
            {
                throw;
            }
            return product; 
        }

		private Product AddNewProduct(SqlDataReader reader)
        {
            return new Product
            {
                ProductId = Convert.ToInt32(reader["product_id"]),
                Name = Convert.ToString(reader["name"]),
                Description = Convert.ToString(reader["description"]),
                Price = Convert.ToDouble(reader["price"]),
                ImageName = Convert.ToString(reader["image_name"])
            };
        }
    }
}