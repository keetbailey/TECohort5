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

namespace ProjectDBTests.DAL
{
    [TestClass()]
    public class ProjectDALTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=DESKTOP-79DH3VU\SQLEXPRESS;Initial Catalog=ProjectOrganizer;Integrated Security=True";


        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd;

                conn.Open();

                cmd = new SqlCommand("SELECT * from project ");
                cmd.ExecuteScalar();
                cmd = new SqlCommand("SELECT COUNT(*) FROM project");
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod]
        public void ProjectListTest()
        {

            ProjectSqlDAL projectDal = new ProjectSqlDAL(connectionString);

            List<Project> getProject = projectDal.GetAllProjects();

            Assert.IsNotNull(getProject);
            Assert.IsTrue(getProject.Count > 0);
            Assert.AreEqual("Project X", getProject[0]);
            Assert.AreEqual(6, getProject.Count);

        }

    }
}
