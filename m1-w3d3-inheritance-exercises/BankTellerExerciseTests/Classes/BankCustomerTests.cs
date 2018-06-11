using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    class BankCustomerTests
    {
        [TestMethod]
        public void NewCustomer() //new customer with no previous accts
        {
            BankCustomer customer = new BankCustomer();

            Assert.AreEqual(0, customer.Accounts.Length);
        }

        [TestMethod]
        public void CustomerOpenNew() //new account opened by customer
        {
            BankCustomer customer = new BankCustomer();
            Assert.AreEqual(0, customer.Accounts.Length);
            customer.AddAccount(new BankAccount("", ""));
            Assert.AreEqual(1, customer.Accounts.Length);
        }

    }
}
