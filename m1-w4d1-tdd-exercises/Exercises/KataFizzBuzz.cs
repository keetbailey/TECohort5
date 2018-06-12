using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string FizzBuzz(int n)
        {
            if ((n<1 || n > 100))
            {
                return "";
            }
            else if (n%3 == 0 && n%5 ==0)
            {
                return "FizzBuzz";
            }
            else if (n%5 == 0)
            {
                return "Buzz"; 
            }
            else if (n % 3 == 0)
            {
                return "Fizz";
            }
            return null;
        }
    }
}
