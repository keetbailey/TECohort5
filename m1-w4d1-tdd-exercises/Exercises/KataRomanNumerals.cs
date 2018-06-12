﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {        private readonly Dictionary<string, int> _roman2Arabic = new Dictionary<string, int>
        {
            {"M", 1000},
            {"CM", 900},
            {"D",  500},
            {"CD", 400},
            {"C",  100},
            {"XC",  90},
            {"L",   50},
            {"XL",  40},
            {"X",   10},
            {"IX",   9},
            {"V",    5},
            {"IV",   4},
            {"I",    1}                              
        };

        public int ConvertToRomanNumeral(string romanNumeral)
        {
            int arabicNumeral = 0;
            while (romanNumeral.Length != 0)
            {
                foreach (var token in _roman2Arabic.Keys)
                {
                    if (romanNumeral.StartsWith(token))
                    {
                        romanNumeral = romanNumeral.Substring(token.Length);
                        arabicNumeral += _roman2Arabic[token];
                    }
                }
            }
            return arabicNumeral;
        }
        //string[] romanOne = new string[] { "I", "II", "III" };
        //string[] romanTen = new string[] { "X" };
        //string[] romanHundred = new string[] { "C" };
        //string[] romandThousand = new string[] { "M" };

        //public string ConvertToRomanNumeral(int n)
        //{
        //    string romanNum = "";
        //    if (n > 0 && n <= 3000)
        //    {

        //    }
        //    return romanNum;
        //}


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

