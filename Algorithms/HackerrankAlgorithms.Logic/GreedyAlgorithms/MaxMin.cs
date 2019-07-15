using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    public class MaxMin
    {
        public static int maxMin(int[] arr, int k)
        {
            Array.Sort(arr);

            //int[] subArr = new int[k];

            //int minUnfairness = arr[k - 1] - arr[0];

            //for (int i = 1; i <= arr.Length - k; i++)
            //    if (arr[i + k - 1] - arr[i] < minUnfairness)
            //        minUnfairness = arr[i + k - 1] - arr[i];

            //return minUnfairness;

          return Enumerable.Range(0, arr.Length - k + 1)
                .Select(i => arr[i + k - 1] - arr[i]) // 'unfairness'es collection
                .Min();

        }





    }
}
