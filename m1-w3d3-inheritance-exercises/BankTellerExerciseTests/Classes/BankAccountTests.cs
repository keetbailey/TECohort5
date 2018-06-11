﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    class BankAccountTest
    {
        [TestMethod]
        public void NewCustomer() //new cust with zero bal 
        {
            BankAccount account = new BankAccount("", "");
            Assert.AreEqual(0, account.Balance);
        }

    }
    
}
