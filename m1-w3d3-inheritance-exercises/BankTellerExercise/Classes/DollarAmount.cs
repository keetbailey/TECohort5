using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class DollarAmount:IComparable
    {
        private int amountInCents;

        public int TotalAmountInCents
        {
            get { return amountInCents; }
        }
        public int Cents
        {
            get
            {
                int remainder = amountInCents % 100;
                return remainder;
            }
        }
        public int Dollars
        {
            get
            {
                int quotient = amountInCents / 100;
                return quotient;
            }
        }
        public bool IsNegative
        {
            get
            {
                return amountInCents < 0;
            }
        }
        public DollarAmount(int totalCents)
        {
            amountInCents = totalCents;
        }
        public DollarAmount(int dollars, int cents)
        {
            amountInCents = (dollars * 100) + cents;
        }
        public DollarAmount Minus(DollarAmount amountToSubtract)
        {
            int difference = this.amountInCents - amountToSubtract.amountInCents;

            return new DollarAmount(difference);
        }
        public DollarAmount Plus(DollarAmount amountToAdd)
        {
            int newTotal = this.amountInCents + amountToAdd.amountInCents;

            return new DollarAmount(newTotal);
        }
        public int CompareTo(DollarAmount other)
        {
            if (this.amountInCents < other.amountInCents)
            {
                return -1;
            }
            else if (other.amountInCents < this.amountInCents)
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
            return (amountInCents / 100.00).ToString("C");

        }
    }
}
