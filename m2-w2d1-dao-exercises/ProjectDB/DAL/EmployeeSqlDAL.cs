using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB.DAL
{
    public class EmployeeSqlDAL
    {
        private string connectionString;
        private const string SQL_SelectAllEmployees = "SELECT * FROM employee;";
        private const string SQL_SearchEmployees = "SELECT * FROM employee WHERE first_name LIKE @firstname AND last_name LIKE @lastname;";
        private const string SQL_FreeEmployees = "SELECT * FROM employee WHERE employee_id NOT IN (SELECT employee_id FROM project_employee);";

        // Single Parameter Constructor
        public EmployeeSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public List<Employee> Search(string firstname, string lastname)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeesWithoutProjects()
        {
            throw new NotImplementedException();
        }
    }
}
