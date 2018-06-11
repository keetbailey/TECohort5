using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    class SavingsAccount:BankAccount
    {
        public SavingsAccount(string accountNumber, decimal balance)
        : base(accountNumber, balance)
        {
        }
        public SavingsAccount(string accountName, string accountNumber, decimal balance)
         :base(accountName, accountNumber, balance)
        {
        }
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            base.Withdraw(amountToWithdraw);
            if (amountToWithdraw > Balance)
            {
                return Balance;
            }
            else if (Balance <= 150)
            {
                return Balance -2;
            }
            
            return Balance;
        }
    }
}