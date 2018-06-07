using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        [TestMethod]
        public void ZeroArrayLength()
        {
            SameFirstLast output = new SameFirstLast();
            Assert.AreEqual(false, output.IsItTheSame(new int[] { })); //if array length zero, return false
        }
        [TestMethod]
        public void OneArrayLength()
        {
            SameFirstLast output = new SameFirstLast();
            Assert.AreEqual(true, output.IsItTheSame(new int[] { 1 }));// if array length is one (one is first and last element), return true
        }
        [TestMethod]
        public void TwoPlusFrontAndBack() 
        {
            SameFirstLast exercises = new SameFirstLast();
            Assert.AreEqual(true, exercises.IsItTheSame(new int[] { 1, 1 }));
            Assert.AreEqual(false, exercises.IsItTheSame(new int[] { 1, 3 }));
            Assert.AreEqual(false, exercises.IsItTheSame(new int[] { 1, 3, 3 }));
            Assert.AreEqual(true, exercises.IsItTheSame(new int[] { 1, 3, 1 }));
        }
    }
    //public class SameFirstLast
    //{

    //    /*
    //     Given an array of ints, return true if the array is length 1 or more, and the first element and
    //     the last element are equal.
    //     IsItTheSame([1, 2, 3]) → false
    //     IsItTheSame([1, 2, 3, 1]) → true
    //     IsItTheSame([1, 2, 1]) → true
    //     */
    //    public bool IsItTheSame(int[] nums)
    //    {
    //        return (nums.Length > 0 && nums[0] == nums[nums.Length - 1]);
    //    }

    //}
}
