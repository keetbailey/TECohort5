using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        [TestMethod]
        public void FizzTest()
        {
            KataFizzBuzz fizz = new KataFizzBuzz();
            Assert.AreEqual("Fizz", fizz.FizzBuzz(6));
            Assert.AreEqual("Fizz", fizz.FizzBuzz(87));
            Assert.AreEqual("Fizz", fizz.FizzBuzz(57));
            Assert.AreEqual("Fizz", fizz.FizzBuzz(33));
            Assert.AreEqual("Fizz", fizz.FizzBuzz(18));
        }
        [TestMethod]
        public void BuzzTest()
        {
            KataFizzBuzz buzz = new KataFizzBuzz();
            Assert.AreEqual("Buzz", buzz.FizzBuzz(10));
            Assert.AreEqual("Buzz", buzz.FizzBuzz(35));
            Assert.AreEqual("Buzz", buzz.FizzBuzz(95));
            Assert.AreEqual("Buzz", buzz.FizzBuzz(55));
            Assert.AreEqual("Buzz", buzz.FizzBuzz(5));
        }
        [TestMethod]
        public void FizzBuzzTest()
        {
            KataFizzBuzz fizzbuzz = new KataFizzBuzz();
            Assert.AreEqual("FizzBuzz", fizzbuzz.FizzBuzz(15));
            Assert.AreEqual("FizzBuzz", fizzbuzz.FizzBuzz(90));
            Assert.AreEqual("FizzBuzz", fizzbuzz.FizzBuzz(60));
            Assert.AreEqual("FizzBuzz", fizzbuzz.FizzBuzz(75));
        }
        [TestMethod]
        public void BoundaryTest()
        {
            KataFizzBuzz nofizzorbuzz = new KataFizzBuzz();
            Assert.AreEqual("", nofizzorbuzz.FizzBuzz(-1));
            Assert.AreEqual("", nofizzorbuzz.FizzBuzz(105));
            Assert.AreEqual("", nofizzorbuzz.FizzBuzz(101));
            Assert.AreEqual("", nofizzorbuzz.FizzBuzz(509));
            Assert.AreEqual("", nofizzorbuzz.FizzBuzz(-78));
        }
    }
}
