using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         doubleX("axxbb") → true
         doubleX("axaxax") → false
         doubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            int idx = str.IndexOf("x");
            if (idx <= -1)
                return false;
            else if (idx + 1 >= str.Length)
                return false;
            else
                return str.Substring(idx + 1, idx + 2).Equals("x");
        }
    }
}
