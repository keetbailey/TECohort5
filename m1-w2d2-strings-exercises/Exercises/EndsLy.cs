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
         Given a string, return true if it ends in "ly".
         endsLy("oddly") → true
         endsLy("y") → false
         endsLy("oddy") → false
         */
        public bool EndsLy(string str)
        {
            int stringLength = str.Length;
            if (str.Length < 2)
                return false;
            else
                return str.Substring(stringLength - 2).Equals("ly");
            
        }
    }
}
