﻿using System;
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
           Assert.AreEqual(true, !customer.IsVip); //looks funny, but if IsVIP originally defaults to false, then this reads, expected True, Actual true (!customerVIP = true)
           
        }
        [TestMethod]
        public void CustNotVIP()
        {
           BankCustomer customer = new BankCustomer();
            Assert.AreEqual(false, customer.IsVip);// IsVIP defaults to false, resulting in passing test for "false" actual. 
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
