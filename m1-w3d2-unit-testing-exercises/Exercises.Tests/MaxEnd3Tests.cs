using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        [TestMethod]
        public void SameStartAndEnd()
        {
            MaxEnd3 output = new MaxEnd3(); //arrange 

            CollectionAssert.AreEqual(new int[] { 5, 5, 5 }, output.MakeArray(new int[] { 5, 15, 5 })); //assert/act 
            CollectionAssert.AreEqual(new int[] { 9, 9, 9 }, output.MakeArray(new int[] { 9, 1, 9 }));
        }

        [TestMethod]
        public void EndLengthLargest()
        {
            MaxEnd3 output = new MaxEnd3();

            CollectionAssert.AreEqual(new int[] { 7, 7, 7 }, output.MakeArray(new int[] { 4, 19, 7 }));
            CollectionAssert.AreEqual(new int[] { 8, 8, 8 }, output.MakeArray(new int[] { 5, 2, 8 }));
        }

        [TestMethod]
        public void StartLengthLargets()
        {
            MaxEnd3 output = new MaxEnd3();

            CollectionAssert.AreEqual(new int[] { 9, 9, 9 }, output.MakeArray(new int[] { 9, 7, 6 }));
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, output.MakeArray(new int[] { 11, 13, 1 }));
        }
    }
}

///*
// Given an array of ints length 3, figure out which is larger between the first and last elements 
// in the array, and set all the other elements to be that value. Return the changed array.
// MakeArray([1, 2, 3]) → [3, 3, 3]
// MakeArray([11, 5, 9]) → [11, 11, 11]
// MakeArray([2, 11, 3]) → [3, 3, 3]
// */
//public int[] MakeArray(int[] nums)
//{
//    int largerNum = (nums[0] > nums[nums.Length - 1]) ? nums[0] : nums[nums.Length - 1];

//    for (int i = 0; i < nums.Length; i++)
//    {
//        nums[i] = largerNum;
//    }

//    return nums;
//}
