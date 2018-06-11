using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountName, string accountNumber, decimal balance)
        :base(accountName, accountNumber, balance)
        {
        }
        public CheckingAccount(string accountNumber, decimal balance)
        :base(accountNumber, balance)
        {
        }
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            base.Withdraw(amountToWithdraw);
            if (Balance - amountToWithdraw >= -100M)
            {
                return Balance;

            }
            else if (Balance - amountToWithdraw < 0.0M)
            {
                return Balance - 10;
            }
            return Balance; 
        }
    }
}
