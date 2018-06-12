using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount:BankAccount
    {
        public decimal feeBalanceSav;
        public SavingsAccount(string accountNumber, decimal balance)
        : base(accountNumber, balance)
        {
        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {

            base.Withdraw(amountToWithdraw);
            if ((CalculateFutureBal(amountToWithdraw)) >= (0))
            {
                base.Withdraw(2);
            }
            return Balance;
        }

        private decimal CalculateFutureBal(decimal amountToWithDraw)
        {
            decimal futureBal = Balance - amountToWithDraw;
            if (futureBal < 150)
            {
                futureBal = futureBal - 2;
            }
            return futureBal;
        }
    }
}