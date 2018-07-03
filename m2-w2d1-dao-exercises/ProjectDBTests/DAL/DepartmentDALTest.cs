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

namespace ProjectDB.DAL.Tests
{
    [TestClass()]
    public class DepartmentDALTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=DESKTOP-79DH3VU\SQLEXPRESS;Initial Catalog=ProjectOrganizer;Integrated Security=True";
        

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                SqlCommand cmd;

                cmd = new SqlCommand("SELECT COUNT(*) FROM department");
                cmd.ExecuteReader();

                cmd = new SqlCommand("SELECT * FROM department");
                cmd.ExecuteReader();

            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod()]
        public void DepartmentListTest()
        {

            DepartmentSqlDAL departmentDal = new DepartmentSqlDAL(connectionString);

            List<Department> getDepartment = departmentDal.GetDepartments();

            Assert.IsNotNull(getDepartment); 
            Assert.IsTrue(getDepartment.Count > 0);
            Assert.AreEqual(4, getDepartment.Count);

        }

    }
    
}
