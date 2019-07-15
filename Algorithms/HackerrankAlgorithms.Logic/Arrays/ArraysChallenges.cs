using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    public static class ArraysChallenges
    {
        public static int[] reverseArray(int[] a)
        {
            List<int> intList = new List<int>();
            for (int i = a.Length - 1; i >= 0; i--)
            {
                intList.Add(a[i]);
            }

            return intList.ToArray();

        }

    }
}
