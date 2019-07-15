using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    public class LeftRotation
    {
        public static int[] Rotate(int[] a, int n)
        {
            n %= a.Length;
            var ret = new int[a.Length];
            for (int i = 0; i < a.Length; ++i)
            {
                int index = (i + n) % a.Length;
                ret[i] = a[index];
            }
            return ret;
        }

        public static void Rotate2(int[] a, int n)
        {
            n %= a.Length;
            var ret = new int[a.Length];
            string output = string.Empty;
            for (int i = 0; i < a.Length; ++i)
            {
                int index = (i + n) % a.Length;
                ret[i] = a[index];
                output += ret[i].ToString() + ' ';
            }
                     

            Console.WriteLine(output.Trim());
        }

    }
}
