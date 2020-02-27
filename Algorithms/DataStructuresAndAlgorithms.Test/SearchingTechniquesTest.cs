using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DataStructuresAndAlgorithms.Logic;
using System.Collections;

namespace DataStructuresAndAlgorithms.Test
{
    [TestFixture]
    public class SearchingTechniquesTest
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2)]
        public void CheckTest(int[] arr, int searchvalue)
        {
            SearchingTechniques sample = new SearchingTechniques();
            int MidpointValue;
            var result = sample.BinarySearchCheck(arr, searchvalue, out MidpointValue);
        }


        [Test]
        // [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2)]
        //[TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 5, 6, 7, 8, 11 }, 6)]
        public void CheckTest2(int[] arr, int searchvalue)
        {
            SearchingTechniques sample = new SearchingTechniques();
            int MidpointValue;
            var result = sample.InterpolationSearchCheck(arr, searchvalue, out MidpointValue);
        }



        [Test]
        // [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2)]
        //[TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 3)]
        //[TestCase(4)]
        [TestCase(13)]
        public void CheckTest3(int key)
        {
            //Hashtable ht = new Hashtable()
            //    {
            //        { 1, "One" },
            //        { 2, "Two" },
            //        { 3, "Three" },
            //        { 4, "Four" },
            //        { 5, null },
            //        { "Fv", "Five" },
            //        { 8.5F, 8.5 },
            //        { 13, "Therteen" },

            //    };

            Hashtable ht = new Hashtable()
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 13, "Therteen" },

                };
            SearchingTechniques sample = new SearchingTechniques();

            var result = sample.HashingSearch(ht, key, ht.Count);
        }


        [TestCase(5,"Five")]
        public void HashingInsertTest(int key, string data)
        {
            Hashtable ht = new Hashtable()
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" }

                };
            SearchingTechniques sample = new SearchingTechniques();

            var result = sample.HashingInsert(ht, key, data, ht.Count);
        }


       
    }

}


