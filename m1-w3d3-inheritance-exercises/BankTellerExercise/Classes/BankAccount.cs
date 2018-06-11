using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        private string accountNumber = "";
        private decimal balance;
        private string accountName;

        public string AccountNumber //property 
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
        public string Name //property
        {
            get
            {
                return accountName;
            }
            set
            {
                accountName = value;
            }
        }

        public decimal Balance //property 
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
        public BankAccount() //constructor 
        {
            balance = 0;
        }
        public BankAccount(string accountName, string accountNumber) //constructor 
        {
            this.accountName = accountName;
            this.accountNumber = accountNumber;
            balance = 0;
        }
        public BankAccount(string accountName, string accountNumber, decimal balance)//constructor 
        {
            this.accountName = accountName;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public BankAccount(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public virtual decimal Deposit(decimal amountToDeposit)//method 
        {
            return balance += amountToDeposit; 
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)//method 
        {
            return balance -= amountToWithdraw;
        } 

        public void Transfer(BankAccount destinationAccount, decimal transferAmount) //method 
        {
            
        }
    }
}
