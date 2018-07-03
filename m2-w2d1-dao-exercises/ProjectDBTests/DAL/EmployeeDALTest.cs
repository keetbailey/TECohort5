using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectDB.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectDB.Models;
using System.Transactions;

namespace ProjectDBTests
{
    [TestClass()]
    public class EmployeeDALTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=DESKTOP-79DH3VU\SQLEXPRESS;Initial Catalog=ProjectOrganizer;Integrated Security=True";


        public EmployeeDALTests(string connectionString)
        {
            this.connectionString = connectionString;
        }

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd;

                conn.Open();

                cmd = new SqlCommand("SELECT COUNT(*) FROM employee WHERE first_name IS NOT NULL AND last_name IS NOT NULL");
                cmd.ExecuteScalar();
                
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod()]
        public void EmployeeListTests()
        {
            EmployeeSqlDAL employeeDal = new EmployeeSqlDAL(connectionString);

            List<Employee> getEmployee = employeeDal.GetAllEmployees();

            Assert.AreEqual(12, getEmployee.Count);
            Assert.IsNotNull(getEmployee);
            Assert.IsTrue(getEmployee.Count > 0);
        }
    }
}
