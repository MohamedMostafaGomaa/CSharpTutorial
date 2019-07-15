using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using HackerrankAlgorithms.Logic;
using System.Collections.Generic;

namespace HackerrankAlgorithms.Test
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        [TestCase(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 3)]
        // [TestCase(10,new string[] { "1", "1", "3", "1", "2", "1", "3", "3", "3", "3" }, 4)]
        public void SockMerchantTest(int length, int[] arr, int expectedPairs)
        {
            SockMerchant obj = new SockMerchant();
            var result = obj.sockMerchant(length, arr);
            Assert.AreEqual(result, expectedPairs);

        }

        [Test]
        [TestCase(10, new int[] { 1, 2, 3, 4, 10, 11 }, 31)]
        public void SimpleArraySumTest(int[] arr, int expectedPairs)
        {
            SimpleArraySum obj = new SimpleArraySum();
            var result = obj.Run(arr);
            Assert.AreEqual(result, expectedPairs);

        }


        //
        [Test]
        [TestCase(new int[] { 5, 6, 7 }, new int[] { 3, 6, 10 })]
        public void CompareTripletsTest(int[] a, int[] b)
        {
            List<int> aList = new List<int>(a);
            List<int> bList = new List<int>(b);
            var res = CompareTriplets.Run(aList, bList);


            // var result = obj.Run(a,b);


        }

        //


        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5 ,1 ,2 ,3 ,4 }, 4)]
        public void LeftRotationTest(int[] input, int[] expected, int numberOfrotation)
        {

           // int [] res = LeftRotation.Rotate(input, numberOfrotation);
            LeftRotation.Rotate2(input, numberOfrotation);
            //Assert.AreEqual(res, expected);

            // var result = obj.Run(a,b);


        }



        [Test]
        // [TestCase(new int[] { 2, 3, 4, 1, 5 })]
        //[TestCase(new int[] { 4, 3, 1, 2 })]
        [TestCase(new int[] { 4, 3, 5, 1, 2 })]

        public void MinimumSwaps2Test(int[] arr)
        {

            var res = MinimumSwaps2.Run(arr);


            // var result = obj.Run(a,b);


        }


        [Test]
        //[TestCase(new int[] { 10, 100, 300, 200, 1000, 20, 30 }, 3, 20)]
        //[TestCase(new int[] { 1, 2, 3, 4, 10, 20, 30, 40, 100, 200 }, 4, 3)]
        //[TestCase(new int[] { 1, 2, 1, 2, 1 }, 2, 0)]
        [TestCase(new int[] { 4504, 1520, 5857, 4094, 4157, 3902, 822, 6643, 2422, 7288, 8245, 9948, 2822, 1784, 7802, 3142, 9739, 5629, 5413, 7232 }, 5, 1335)]

        public void MaxMinTest(int[] arr, int sunArrItemsNum, int expected)
        {

            var res = MaxMin.maxMin(arr, sunArrItemsNum);


            Assert.AreEqual(res, expected);


        }





        [Test]
        //[TestCase(new int[] { 1, 4, 5, 3, 2 }, 4, 5)]
        //[TestCase(new int[] { 2, 2, 4, 3 }, 4, 5)]

        [TestCase(new int[] { 7, 2, 5, 4, 11 }, 12, "1 3")]

        public void IceCreamParlorTest(int[] cost, int money, string expected)
        {
            var res = IceCreamParlor.whatFlavors2(cost, money);
            Assert.AreEqual(res, expected);
        }


        [Test]

        [TestCase(new int[] { 3, 7, 4, 6, 5 }, 13)]

        public void MaxArraySumTest(int[] arr, int expected)
        {
            var res = MaxArraySum.maxSubsetSum(arr);
            Assert.AreEqual(res, expected);
        }


        #region Data Structures

        #region Trees

        [Test]

        [TestCase(new int[] { 1, 2, 5, 3, 6, 4 }, "1 2 5 3 4 6")]
        //[TestCase(15, new int[] { 1, 14, 3, 7, 4, 5, 15, 6, 13, 10, 11, 2, 12, 8, 9 }, new int[] { 1, 14, 3, 2, 7, 4, 5, 6, 13, 10, 8, 9, 11, 12, 15 })]
        [TestCase(new int[] { 1, 14, 3, 7, 4, 5, 15, 6, 13, 10, 11, 2, 12, 8, 9 }, "1 14 3 2 7 4 5 6 13 10 8 9 11 12 15")]
        public void PreorderTraversalTest(int[] arrInput, string arrOutput)
        {
            //PreorderTraversalTest(int input, int[] arrInput, int[] arrOutput)
            //var res = PreorderTraversal.run(input, arrInput);
            string result = string.Empty;
            PreorderTraversal.StartOrder(arrInput, ref result);

            Assert.AreEqual(result.Trim(), arrOutput);
        }


        [Test]

        [TestCase(new int[] { 1, 2, 5, 3, 6, 4 }, "1 2 3 4 5 6")]
        [TestCase(new int[] { 1, 14, 3, 7, 4, 5, 15, 6, 13, 10, 11, 2, 12, 8, 9 }, "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15")]
        public void InorderTraversalTest(int[] arrInput, string arrOutput)
        {
            string result = string.Empty;
            InorderTraversal.StartOrder(arrInput, ref result);

            Assert.AreEqual(result.Trim(), arrOutput);
        }


        [Test]

        [TestCase(new int[] { 3, 5, 2, 1, 4, 6, 7 }, 3)]
        [TestCase(new int[] { 15 }, 0)]
        [TestCase(new int[] { 3, 1, 7, 5, 4 }, 3)]

        public void GetTreeHeightTest(int[] arrInput, int expectedHeight)
        {

            int result = TreesSamples.StartGetTreeHeight(arrInput);

            Assert.AreEqual(result, expectedHeight);
        }



        #endregion


        #endregion


    }
}
