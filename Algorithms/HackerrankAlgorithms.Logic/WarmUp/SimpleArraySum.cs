using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    public class SimpleArraySum
    {
        public int Run(int[] ar)
        {
            int total = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                total = total + ar[i];
            }

            return total;
        }
    }
}
