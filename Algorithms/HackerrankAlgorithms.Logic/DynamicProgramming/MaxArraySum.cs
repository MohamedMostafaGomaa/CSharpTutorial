using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    public static class MaxArraySum
    {
        public static int maxSubsetSum(int[] arr)
        {

            int queue1 = 0;
            int queue2 = 0;
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp = queue1;
                queue1 = Math.Max(arr[i] + queue2, temp);
                queue2 = temp;
            }
            return Math.Max(queue1, queue2);
            //List<object> ArraysList = new List<object>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    List<int> numbersList = new List<int>();
            //    for (int j = i; j <= arr.Length - i; j++)
            //    {
            //        if (j + 1 <= arr.Length - i)
            //        {
            //            numbersList.Add(arr[j]);
            //            j++;
            //        }
            //    }
            //    ArraysList.Add(numbersList);
            //}

            //int total = 0;
            //foreach (List<int> numList in ArraysList)
            //{
            //    int listTotal = 0;
            //    foreach (int num in numList)
            //    {
            //        listTotal += num;
            //    }
            //    if (listTotal > total)
            //        total = listTotal;
            //}

            //return total;
        }

    }
}
