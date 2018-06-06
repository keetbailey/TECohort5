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
        public void OneArrayLength()
        {
            SameFirstLast output = new SameFirstLast();
            Assert.AreEqual(true, output.IsItTheSame(new int[] { 1 }));// if array length is one (one is first and last element), return true
        }

        public void TwoPlusFrontAndBack()
        {
            SameFirstLast output = new SameFirstLast();
            //Assert.AreEqual
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
