using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankCustomer:BankAccount
    {
        private string accountName;
        private string address;
        private string phoneNumber;
        private List<BankAccount> accounts = new List<BankAccount>();

        public string AccountName //property
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
        public string Address//property
        {
            get
            {
                return address;
            }
            set
            {
                AccountNumber = value;
            }
        }
        public string PhoneNumber//property
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                AccountNumber = value;
            }
        }
        public BankAccount[] Accounts//property 
        {
            get
            {
                return accounts.ToArray();
            }
        }
        public void AddAccount(BankAccount newAccount) //method 
        {
            accounts.Add(newAccount);
        }
        public bool IsVip 
        {
            get
            {
                decimal totalBalance = 0;
                foreach (BankAccount account in accounts)
                {
                    totalBalance += account.Balance;
                }

                return Balance >= 25000;
            }
        }
    }
}    


