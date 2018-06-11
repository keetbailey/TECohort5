using System;
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
        public void DepositIncreasedsBalance()
        {
            BankAccount account = new BankAccount("", "");

            DollarAmount newBalance = account.Deposit(new DollarAmount(100));

            Assert.AreEqual(100, newBalance.TotalAmountInCents);
            Assert.AreEqual(100, account.Balance.TotalAmountInCents);
        }
        [TestMethod]
        public void NewCustomerHasStartingBalance()
        {
            BankAccount account = new BankAccount("", "");
            Assert.AreEqual(100, account.Balance.TotalAmountInCents);
        }
        [TestMethod]
        public void WithdrawDecreasesBalance()
        {
            BankAccount account = new BankAccount("", "");
            DollarAmount newBalance = account.Withdraw(new DollarAmount(100));

            Assert.AreEqual(-100, newBalance.TotalAmountInCents);
            Assert.AreEqual(-100, account.Balance.TotalAmountInCents);
        }
    }
    
}
