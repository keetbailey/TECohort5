using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectDB.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectDB.Models;



namespace ProjectDB.Tests.DAL
{
    [TestClass()]
    public class DepartmentDALTests
    {
        private TransactionScope tran; 
        private string connectionString = @"Data Source = DESKTOP - 79DH3VU\SQLEXPRESS;Initial Catalog = ProjectOrganizer; Integrated Security = True"
        
        [TestInitialize]
        public void Initialize()
        {
            tran  = new TransactionScope()
        }
    }
}
