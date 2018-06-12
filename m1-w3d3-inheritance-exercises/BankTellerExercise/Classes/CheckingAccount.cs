using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount:BankAccount
    {
        public decimal feeBalance;
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
            feeBalance = Balance - 10;
            if ((Balance - amountToWithdraw) > (-100))
            {
                base.Withdraw(amountToWithdraw);
                return Balance;

            }
            else if (Balance - amountToWithdraw < 0)
            {
               feeBalance = Balance - 10;
                return feeBalance;
            }
            return Balance; 
        }
    }
}
