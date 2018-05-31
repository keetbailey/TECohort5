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
            bool hasXX = false;
            if (str.Contains("xx")) ;
            //{
            //    return false;

            //    for (i = 0; i < str.Length;i++)
            //      if (hasXX)
            //        { 
            //          str[i] == "x" && str[i] != "x";
            //            return true;
            //            break;
            //      else if (hasXX)
            //          str[if] == "x" && str[i] == "x";
            //                return true;
            //                break;
            //}
            return false;
        }
    }
}
