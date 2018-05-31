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
         Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
         altPairs("kitten") → "kien"
         altPairs("Chocolate") → "Chole"
         altPairs("CodingHorror") → "Congrr"
         */
        public string AltPairs(string str)
        {
            for (int idx = 0; idx < str.Length-1; idx += 4)
            {
                string result = "";
                str.Substring(idx + 2);
                result += str.Substring(idx, idx + 2);
            }
            return null;
        }
        
    }
}
