using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void CountThreeTest()
        {
            WordCount output = new WordCount();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"sheep", 3},
            };
            CollectionAssert.AreEqual(expected, output.GetCount(new string[] {"sheep","sheep","sheep"}));
        }

        [TestMethod]
        public void CountTwoOneOne()
        {
            WordCount output = new WordCount();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {

                {"ba", 2},
                {"black", 1},
                {"sheep", 1}
            };
            CollectionAssert.AreEqual(expected, output.GetCount(new string[] {"ba","ba","black","sheep"}));
        }

        [TestMethod]
        public void CountMultiple()
        {
            WordCount output = new WordCount();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {

                {"a", 2},
                {"b", 3},
                {"c", 1},
                {"d", 2}
            };
            CollectionAssert.AreEqual(expected, output.GetCount(new string[] {"a","b","c","d","a","b","d","b"}));
        }
    }
}
//public class WordCount
//{
//    /*
//     * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the 
//     * number of times that string appears in the array.
//     * 
//     * ** A CLASSIC **
//     * 
//     * GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
//     * GetCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
//     * GetCount([]) → {}
//     * GetCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
//     * 
//*/
//public Dictionary<string, int> GetCount(string[] words)
//Dictionary<string, int> output = new Dictionary<string, int>();

//        foreach (string word in words)
//        {
//            if (!output.ContainsKey(word))
//            {
//                output[word] = 1;
//            }
//            else
//            {
//                output[word] = output[word] + 1;
//            }
//        }

//        return output;

