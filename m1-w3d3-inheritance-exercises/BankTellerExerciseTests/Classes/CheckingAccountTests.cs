using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class CheckingAccountTests
    {
        [TestMethod]
        public void NegativeWithFees() //if w/d amount takes customer overdrawn, plus fee
        {
            CheckingAccount checkingAccount = new CheckingAccount("", -30);
            Decimal newBalance = checkingAccount.Withdraw(50);
            Assert.AreEqual(-90, checkingAccount.Balance);
        }

        [TestMethod]
        public void AllowWithdrawToLimitWithFees() //if w/d amount takes customer overdrawn, plus fee
        {
            CheckingAccount checkingAccount = new CheckingAccount("", -40);
            Decimal newBalance = checkingAccount.Withdraw(50);
            Assert.AreEqual(-100, checkingAccount.Balance);
        }

        [TestMethod]
        public void Withdraw()
        {
            CheckingAccount checkingAccount = new CheckingAccount("", 100);
            Decimal newBalance = checkingAccount.Withdraw(100);
            Assert.AreEqual(0, checkingAccount.Balance);
        }

        [TestMethod]
        public void Deposit()
        {
            CheckingAccount checkingAccount = new CheckingAccount("",  1000);
            Decimal newBalance = checkingAccount.Deposit(500);
            Assert.AreEqual(1500, checkingAccount.Balance);
        }

        [TestMethod]
        public void OverdrawnSorry()
        {
            CheckingAccount checkingAccount = new CheckingAccount("", -50);
            Decimal newBalance = checkingAccount.Withdraw(50.01M);
            Assert.AreEqual(-50, checkingAccount.Balance);
        }
    }
}
