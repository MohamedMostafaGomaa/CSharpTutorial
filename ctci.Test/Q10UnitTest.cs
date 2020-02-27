using NUnit.Framework;
using Chapter10;
using ctci.Library;
using static Chapter10.Q10_02_Group_Anagrams;
using System;

namespace ctci.Test
{
    [TestFixture]
    public class Q10UnitTest
    {
        [Test]
        public void Sorted_Merge_Test()
        {
            int[] a = new int[] { 2, 3, 4, 5, 6, 8, 10, 100, 0, 0, 0, 0, 0, 0 };
            int[] b = new int[] { 1, 4, 6, 7, 7, 7 };
            int[] expected = new int[] { 1, 2, 3, 4, 4, 5, 6, 6, 7, 7, 7, 8, 10, 100 };
            int[] merged = new Q10_01_Sorted_Merge().Merge(a, b, 8, 6);
            Assert.That(merged, Is.EqualTo(expected));
        }


        [Test]
        public void Group_Anagrams_Test()
        {
            string[] array = { "apple", "banana", "carrot", "ele", "duck", "papel", "tarroc", "cudk", "eel", "lee" };
            var s1 = AssortedMethods.StringArrayToString(array);
            Array.Sort(array, new AnagramComparator());
            var s2 = AssortedMethods.StringArrayToString(array);

            string[] array2 = { "apple", "banana", "carrot", "ele", "duck", "papel", "tarroc", "cudk", "eel", "lee" };
            new Q10_02_Group_Anagrams().Sort(array);
            var s3 = AssortedMethods.StringArrayToString(array);
        }
    }
}
