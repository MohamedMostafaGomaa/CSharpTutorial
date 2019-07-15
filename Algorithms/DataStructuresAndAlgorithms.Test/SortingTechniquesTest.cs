using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DataStructuresAndAlgorithms.Logic;

namespace DataStructuresAndAlgorithms.Test
{
    [TestFixture]
    public class SortingTechniquesTest
    {
        [Test]
        [TestCase(new int[] { 54, 32, 53, 9, 5, -1, 7, 8, 20, 10, 11 })]
        public void BubbleSort(int[] arr)
        {
            SortingTechniques sample = new SortingTechniques();
            var result = sample.BubbleSort(arr);
        }



        [Test]
        [TestCase(new int[] { 54, 32, 53, 9, 5, -1, 7, 8, 20, 10, 11 })]
        public void InsertionSort(int[] arr)
        {
            SortingTechniques sample = new SortingTechniques();
            var result = sample.InsertionSort(arr);
        }


        [Test]
        [TestCase(new int[] { 54, 32, 53, 9, 5, -1, 7, 8, 20, 10, 11 })]
        public void SelectionSort(int[] arr)
        {
            SortingTechniques sample = new SortingTechniques();
            var result = sample.SelectionSort(arr);
        }


        [Test]
        [TestCase(new int[] { 7, 3, 8, 1, 2, 5 })]
        public void InsertTest(int[] arr)
        {
            SortingTechniques sample = new SortingTechniques();

            var result = sample.InsertTest(arr);

          
        }
    }
}
