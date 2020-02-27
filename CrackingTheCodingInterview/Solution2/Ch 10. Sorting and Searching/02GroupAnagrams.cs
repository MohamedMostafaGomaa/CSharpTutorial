using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Ch_10.Sorting_and_Searching
{
    public static class GroupAnagrams
    {
        public static string[] SortStrings(string[] inputArr)
        {

            Array.Sort(inputArr);

            return inputArr;
        }
    }

    public class GroupAnagramsTest
    {
        [Test]
        public void TestGroupAnagrams()
        {
            string[] array = { "apple", "banana", "carrot", "ele", "duck", "papel", "tarroc", "cudk", "eel", "lee" };
            string[] result = GroupAnagrams.SortStrings(array);
        }

    }
}
