﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         * 
         * wordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * wordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * wordMultiple(["c", "c", "c", "c"]) → {"c": true}
         * 
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, bool> output = new Dictionary<string, bool>();

            foreach (string letter in words)
            {
                if (!output.ContainsKey(letter)) // essentially if the string does not repeat itself, return false for the particular string
                {
                    output[letter] = false;
                }
                else
                {
                    output[letter] = true; 
                }
            }

            return output; //this one threw me off for a bit
        }
    }
}
