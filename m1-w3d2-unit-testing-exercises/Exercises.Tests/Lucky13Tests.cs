using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        [TestMethod]
        public void OnesAndThrees()
        {
            Lucky13 unlucky = new Lucky13();

            //Assert
            Assert.AreEqual(false, unlucky.GetLucky(new int[] { 1, 1, 1 }));
            Assert.AreEqual(false, unlucky.GetLucky(new int[] { 3, 3, 3 }));
            Assert.AreEqual(false, unlucky.GetLucky(new int[] { 1, 3}));
        }
        [TestMethod]
        public void TheLuckyOne()
        {
            Lucky13 lucky = new Lucky13();

            //Assert
            Assert.AreEqual(true, lucky.GetLucky(new int[] { 0, 2, 6}));
            Assert.AreEqual(true, lucky.GetLucky(new int[] { 2, 4, 8 }));
            Assert.AreEqual(true, lucky.GetLucky(new int[] { 0, 2 }));
        }
    }
}
//public class Lucky13
//{
//    /*
//     Given an array of ints, return true if the array contains no 1's and no 3's.
//     GetLucky([0, 2, 4]) → true
//     GetLucky([1, 2, 3]) → false
//     GetLucky([1, 2, 4]) → false
//     */
//    public bool GetLucky(int[] nums)
//    {
//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (nums[i] == 1 || nums[i] == 3)
//            {
//                return false;
//            }
//        }
//        return true;
//    }


