using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankAccountTests 
    {
        [TestMethod]
        public void NewCustomerNoBal()
        {
            BankAccount account = new BankAccount("", "");
            Assert.AreEqual(0, account.Balance);
        }

        [TestMethod]
        public void CurrentCustomerBal()
        {

        }
    }
}
