using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class DollarAmount:IComparable
    {
        private int totalAmountInCents;

        public int TotalAmountInCents
        {
            get { return totalAmountInCents; }
        }
        public int Cents
        {
            get
            {
                int remainder = totalAmountInCents % 100;
                return remainder;
            }
        }
        public int Dollars
        {
            get
            {
                int quotient = totalAmountInCents / 100;
                return quotient;
            }
        }
        public bool IsNegative
        {
            get
            {
                return totalAmountInCents < 0;
            }
        }
        public DollarAmount(int totalCents)
        {
            totalAmountInCents = totalCents;
        }
        public DollarAmount(int dollars, int cents)
        {
            totalAmountInCents = (dollars * 100) + cents;
        }
        public DollarAmount Minus(DollarAmount amountToSubtract)
        {
            int difference = this.totalAmountInCents - amountToSubtract.totalAmountInCents;

            return new DollarAmount(difference);
        }
        public DollarAmount Plus(DollarAmount amountToAdd)
        {
            int newTotal = this.totalAmountInCents + amountToAdd.totalAmountInCents;

            return new DollarAmount(newTotal);
        }
        public int CompareTo(DollarAmount other)
        {
            if (this.totalAmountInCents < other.totalAmountInCents)
            {
                return -1;
            }
            else if (other.totalAmountInCents < this.totalAmountInCents)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return (totalAmountInCents / 100.00).ToString("C");

        }
    }
}
