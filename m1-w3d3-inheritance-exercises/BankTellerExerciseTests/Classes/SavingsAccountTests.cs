﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class SavingsAccountTests
    {
        [TestMethod]
        public void LessThan150() //acct bal < $150 
        {
            SavingsAccount savingsAccount = new SavingsAccount("", 140);
            Decimal newBalance = savingsAccount.Withdraw(40);
            Assert.AreEqual(98, savingsAccount.Balance);
        }
        [TestMethod]
        public void BalAfterCustDeposit() //deposit 
        {
            SavingsAccount savingsAccount = new SavingsAccount("", 1000);
            Decimal newBalance = savingsAccount.Deposit(500);
            Assert.AreEqual(1500, savingsAccount.Balance);
        }
        [TestMethod]
        public void BalAfterWithdraw() //withdraw 
        {
            SavingsAccount savingsAccount = new SavingsAccount("", 1000);
            Decimal newBalance = savingsAccount.Withdraw(500);
            Assert.AreEqual(500, savingsAccount.Balance);
        }
        //[TestMethod]
        //public void Transfer() //transfer 
        //{
        //    SavingsAccount savingsAccount = new SavingsAccount("", "", 0M);
        //    Decimal newBalance = savingsAccount.Transfer(new Decimal(500));
        //    Assert.AreEqual(500, savingsAccount.Balance);
        //}
    }
}
