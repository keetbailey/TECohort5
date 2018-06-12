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
            CheckingAccount checkingAccount = new CheckingAccount("", "", new Decimal(-50));
            Decimal newBalance = checkingAccount.Withdraw(new Decimal(50));
            Assert.AreEqual(-110, checkingAccount.feeBalance);
        }

        [TestMethod]
        public void Withdraw()
        {
            CheckingAccount checkingAccount = new CheckingAccount("", "", new Decimal(100));
            Decimal newBalance = checkingAccount.Withdraw(new Decimal(100));
            Assert.AreEqual(0, checkingAccount.Balance);
        }

        [TestMethod]
        public void Deposit()
        {
            CheckingAccount checkingAccount = new CheckingAccount("", "", new Decimal(1000));
            Decimal newBalance = checkingAccount.Deposit(new Decimal(500));
            Assert.AreEqual(1500, checkingAccount.Balance);
        }
        [TestMethod]
        public void OverdrawnSorry()
        {
            CheckingAccount checkingAccount = new CheckingAccount("", "", new Decimal(-50));
            Decimal newBalance = checkingAccount.Withdraw(new Decimal(100));
            Assert.AreEqual(-50, checkingAccount.Balance);
        }
    }
}
