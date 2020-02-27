using System;
using NUnit.Framework;
using HackerrankAlgorithms.Logic;
using System.Collections.Generic;

namespace HackerrankAlgorithms.Test.Arrays
{
    /// <summary>
    /// Summary description for ArraysChallengesUnitTest
    /// </summary>
    [TestFixture]
    public class ArraysChallengesUnitTest
    {
        [Test]
        [TestCase(new int[] { 1, 4, 3, 2 }, new int[] { 2, 3, 4, 1 })]
        public void reverseArrayTest(int[] arrInput, int[] arrExpected)
        {
            int[] arrResult = ArraysChallenges.reverseArray(arrInput);
            Assert.AreEqual(arrResult, arrExpected);
        }


        [Test]
        [TestCase(new string[] { "D","C", "B", "A" }, new string[] {"A", "B", "C", "D" })]
        public void reverseArrayTest(string[] arrInput, string[] arrExpected)
        {
            string[] arrResult = ArraysChallenges.reverseArray(arrInput);
            Assert.AreEqual(arrResult, arrExpected);
        }
    }
}
