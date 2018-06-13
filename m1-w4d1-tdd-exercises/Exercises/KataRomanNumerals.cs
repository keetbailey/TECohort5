using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {
        string[] romanOne = new string[] { "I", "II", "III" };
        string[] romandFive = new string[] { "V" };
        string[] romanTen = new string[] { "X" };
        string[] romanHundred = new string[] { "C" };
        string[] romandThousand = new string[] { "M" };
        string[] numericOne = new string[] { "1", "2", "3" };
        string[] numericFive = new string[] { "5" };
        string[] numericTen = new string[] { "10"};
        string[] numericHundred = new string[] {"100"};
        string[] numericThousand = new string[] { "1000"};


        public string ConvertToRomanNumeral(int n)
        {
            string romanNum = "";
            if (n > 0 && n <= 3000)
            {
                for (int i = 1; i < romanNum.Length; i++) ;
            }
            return romanNum;
        }


    }
}
//I-1
//V-5
//X-10
//L-50
//C-100
//D-500
//M-1000
//assign variable to hold roman numeral values;
//
//convert to roman numerals
//number range from 0-3000, 1-I;10-X; 7-VII, etc. 
//"Roman numerals are written by expressing each digit
//separately starting with the left most digit and 
//skipping any digit with a value of zero.To see this in practice, consider the 
//example of 1990. In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; 
//resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII."

