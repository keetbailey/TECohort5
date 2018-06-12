using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount:BankAccount
    {
        //public CheckingAccount(string accountName, string accountNumber, decimal balance)
        //: base(accountName, accountNumber, balance)
        //{
        //}
        public CheckingAccount(string accountNumber, decimal balance)
        : base(accountNumber, balance)
        {
        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            //base.Withdraw(amountToWithdraw);//Ask Andrew about this - negative with fees test did not work without this, and OverdrawnSorry would not work without same statement placed in If scope
        
            if ((CalculateFutureBal(amountToWithdraw)) >= (-100))
            {
                base.Withdraw(amountToWithdraw);//Ask Andrew
                if (Balance < 0)
                {
                    base.Withdraw(10);
                }
            }
            return Balance; 
        }

        private decimal CalculateFutureBal(decimal amountToWithDraw)
        {
            decimal futureBal = Balance - amountToWithDraw;
            if (futureBal < 0)
            {
                futureBal = futureBal - 10;
            }
            return futureBal;
        }
    }
}
