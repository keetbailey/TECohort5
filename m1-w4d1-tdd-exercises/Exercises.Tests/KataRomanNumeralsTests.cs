using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        [TestMethod]
        public void InputInteger()
        {
            KataRomanNumerals input = new KataRomanNumerals();
            Assert.AreEqual("L", input.ConvertToRomanNumeral(50));
            Assert.AreEqual("MMXVIII", input.ConvertToRomanNumeral(2018));
            Assert.AreEqual("XCVII", input.ConvertToRomanNumeral(97));
            Assert.AreEqual("MMCMXCIX", input.ConvertToRomanNumeral(2999));
            Assert.AreEqual("I", input.ConvertToRomanNumeral(1));
            Assert.AreEqual("MCMLXXXVII", input.ConvertToRomanNumeral(1987));
        }
    }
}
