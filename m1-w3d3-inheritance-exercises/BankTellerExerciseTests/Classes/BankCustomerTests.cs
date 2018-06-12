using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{

    [TestClass]
    public class BankCustomerTests
    {
        [TestMethod]
        public void CustIsVIP()
        {
           BankCustomer customer = new BankCustomer();
            customer.AddAccount(new CheckingAccount("", 20000));
            customer.AddAccount(new SavingsAccount("", 5000));
            Assert.AreEqual(true, customer.IsVip); 
           
        }
        [TestMethod]
        public void CustNotVIP()///correct to represent not VIP
        {
            BankCustomer customer = new BankCustomer();
            customer.AddAccount(new CheckingAccount("", 20000));
            customer.AddAccount(new SavingsAccount("", 4999.99M)); //boundary testing - right at boundary 
            Assert.AreEqual(false, customer.IsVip); 
        }

        [TestMethod]
        public void AddNewCust()
        {
            BankCustomer customer = new BankCustomer();
            Assert.AreEqual(0, customer.Accounts.Length);
            customer.AddAccount(new BankAccount("", ""));
            Assert.AreEqual(1, customer.Accounts.Length);
        }
    }
}
