using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    public class CompareTriplets
    {
        public static List<int> Run(List<int> a, List<int> b)
        {

            List<int> result = new List<int>();
            int aTotal = 0;
            int bTotal = 0;
            int length = (a.Count == b.Count) ? a.Count : (a.Count > b.Count) ? a.Count : b.Count;

            int index = 0;
            do
            {

                if (index >= a.Count)
                {
                    bTotal++;
                }
                else if (index >= b.Count)
                { aTotal++; }
                else
                {
                    if (a[index] > b[index])
                        aTotal++;
                    else if (a[index] < b[index])
                        bTotal++;
                }
                index++;
            } while (index < length);

            result.Add(aTotal);
            result.Add(bTotal);

            return result;
        }
    }
}
