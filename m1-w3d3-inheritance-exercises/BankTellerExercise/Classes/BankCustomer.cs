using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankCustomer
    {
        private string name;
        private string address;
        private string phoneNumber;
        private List<BankAccount> accounts = new List<BankAccount>();

        public string Name //property
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
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
                address = value;
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
                phoneNumber = value;
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
    }
}    


