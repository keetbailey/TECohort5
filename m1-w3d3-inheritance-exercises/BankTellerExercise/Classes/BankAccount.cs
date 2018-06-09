using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        private string accountNumber;
        private DollarAmount balance;
        private string accountName;

        public string AccountName
        {
            get
            {
                return accountName;
            }
        }

        public string AccountNumber//property
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }
        public DollarAmount Balance//property
        {
            get
            {
                return balance;
            }
            private set
            {
                balance = value;
            }
        }
        public DollarAmount Deposit(DollarAmount amountToDeposit)//method 
        {
            balance = balance.Plus(amountToDeposit);
            return balance;
        }
        public DollarAmount Withdraw(DollarAmount amountToWithdraw)//method 
        {
            balance = balance.Minus(amountToWithdraw);
            return balance;
        }
        public DollarAmount Transfer(BankAccount destinationAccount, DollarAmount transferAmount)//method 
        {
            this.Withdraw(transferAmount);
            destinationAccount.Deposit(transferAmount);
            return balance;
        }
        public BankAccount(string accountName, string accountNumber) //constructor 
        {
            this.accountName = accountName;
            this.accountNumber = accountNumber;
            balance = new DollarAmount(0);
        }


    }
}
