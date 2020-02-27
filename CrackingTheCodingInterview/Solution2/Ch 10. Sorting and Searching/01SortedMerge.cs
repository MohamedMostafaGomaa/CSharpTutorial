using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Ch_10.Sorting_and_Searching
{
    public static class SortedMerge
    {
        public static int[] Merge(int[] a, int[] b, int lastA)
        {
            int lastB = b.Length;
            int indexMerged = lastB + lastA - 1; /* Index of last location of merged array */
            int indexA = lastA - 1; /* Index of last element in array b */
            int indexB = lastB - 1; /* Index of last element in array a */

            /* Merge a and b, starting from the last element in each */
            while (indexB >= 0)
            {
                if (indexA >= 0 && a[indexA] > b[indexB])
                { /* end of a is bigger than end of b */
                    a[indexMerged] = a[indexA]; // copy element
                    indexA--;
                }
                else
                {
                    a[indexMerged] = b[indexB]; // copy element
                    indexB--;
                }
                indexMerged--; // move indices
            }

            return a;
        }

    }

    [TestFixture]
    public class SortedMergeTest
    {
        [TestCase("aabcccccaaa")]
        public void TestSortedMerge(string input)
        {

            int[] a = new int[] { 2, 3, 4, 5, 6, 8, 10, 100, 0, 0, 0, 0, 0, 0 };
            int[] b = new int[] { 1, 4, 7, 6, 7, 7 };
            int [] result = SortedMerge.Merge (a, b, 8);
        }

    }
}
