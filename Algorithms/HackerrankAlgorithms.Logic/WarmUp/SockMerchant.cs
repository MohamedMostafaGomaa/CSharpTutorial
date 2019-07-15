using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    /// <summary>
    /// 
    /// </summary>
    public class SockMerchant
    {
        public int sockMerchant(int n, int[] ar)
        {

            int numberOfPairs = 0;

            List<int> odds = new List<int>();
            for (int i = 0; i < ar.Length; i++)
            {

                if (odds.Contains(ar[i]))
                {
                    odds.Remove(ar[i]);
                    numberOfPairs++;
                }
                else
                {
                    odds.Add(ar[i]);
                }
            }

            return numberOfPairs;

        }
    }
}
