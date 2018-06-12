using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPotter
    {
        public decimal GetCost(int[] books)
        {
            decimal sumOfBooks = 0.00M;
            decimal[] groupPricesBooks = { 8.00M, 15.20M, 21.60M, 25.60M, 30.00M };
            int[] cart = new int[5];

            if (cart.Sum() > 0)
            {

            }

            return 0;
        }
    }
} 
//One copy $8 regardless
//Two books at 5% discount - 15.20
//Three books at 10% discount - 21.60
//Four books at 20% - 25.60
//Five at 25% - 30.00 

//need a shopping cart to hold items - int assigned with value of 5 (# books in set?)
//cheaper to buy five books at 25% than five books @ 8.00/piece;or that three books at 21.60 and two books at 15.20(sum 36.80) is more expensive than four books at 25.60 and one book at 8.00 (sum 33.60)
