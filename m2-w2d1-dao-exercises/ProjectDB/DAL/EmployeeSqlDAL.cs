using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectDB.DAL
{
    public class EmployeeSqlDAL
    {
        private string connectionString;
        private const string SQL_SelectEmployees = "SELECT * FROM employee;";
        private const string SQL_BoredEmployees = "SELECT * FROM employee WHERE employee_id NOT IN (SELECT employee_id FROM project_employee);";
        private const string SQL_SearchEmployees = "SELECT * FROM employee WHERE first_name LIKE @firstname AND last_name LIKE @lastname;";

        // Single Parameter Constructor
        public EmployeeSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        private Employee GetEmployeeReader(SqlDataReader reader)
        {
            Employee e = new Employee();
            e.EmployeeId = Convert.ToInt32(reader["employee_id"]);
            e.DepartmentId = Convert.ToInt32(reader["department_id"]);
            e.FirstName = Convert.ToString(reader["first_name"]);
            e.LastName = Convert.ToString(reader["last_name"]);
            e.JobTitle = Convert.ToString(reader["job_title"]);
            e.BirthDate = Convert.ToDateTime(reader["birth_date"]);
            e.Gender = Convert.ToString(reader["gender"]);
            e.HireDate = Convert.ToDateTime(reader["hire_date"]);

            return e;
        }

            public List<Employee> GetAllEmployees()
        {
            List<Employee> output = new List<Employee>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_SelectEmployees, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee e = GetEmployeeReader(reader);
                        output.Add(e);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        public List<Employee> Search(string firstname, string lastname)
        {
            List<Employee> output = new List<Employee>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_SearchEmployees, conn);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee e = GetEmployeeReader(reader);
                        output.Add(e);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        public List<Employee> GetEmployeesWithoutProjects()
        {
            List<Employee> output = new List<Employee>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_BoredEmployees, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee e = GetEmployeeReader(reader);
                        output.Add(e);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }
    }
}
