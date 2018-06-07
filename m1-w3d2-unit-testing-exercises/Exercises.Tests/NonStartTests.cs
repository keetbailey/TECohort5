using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]
        public void PartialStringManipulation()
        {
            NonStart output = new NonStart();

            Assert.AreEqual("owdyowdy", output.GetPartialString("Howdy", "Howdy"));
            Assert.AreEqual("oahow", output.GetPartialString("Woah", "Now"));
        }
    }
}
///*
// Given 2 strings, return their concatenation, except omit the first char of each. The strings will 
// be at least length 1.
// GetPartialString("Hello", "There") → "ellohere"
// GetPartialString("java", "code") → "avaode"	
// GetPartialString("shotl", "java") → "hotlava"	
// */
//public string GetPartialString(string a, string b)
//{
//    if (a.Length == 0)
//    {
//        return b.Substring(1);
//    }
//    else if (b.Length == 0)
//    {
//        return a.Substring(1);
//    }
//    else
//    {
//        return a.Substring(1) + b.Substring(1);
//    }
//}
