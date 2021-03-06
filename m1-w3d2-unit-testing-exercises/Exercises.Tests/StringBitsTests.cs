﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        [TestMethod]
        public void Singlestring()
        {
            StringBits output = new StringBits(); 
            Assert.AreEqual("H", output.GetBits("H"));
        }

        [TestMethod]
        public void MultiString()
        {
            StringBits output = new StringBits();
            Assert.AreEqual("Hlo", output.GetBits("Hello"));
        }


        ///*
        //     Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
        //     GetBits("Hello") → "Hlo"	
        //     GetBits("Hi") → "H"	
        //     GetBits("Heeololeo") → "Hello"	
        //     */
        //public string GetBits(string str)
        //{
        //    string result = "";
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            result += str[i];
        //        }
        //    }
        //    return result;
    }
}

