using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    public class IceCreamParlor
    {
        public static void whatFlavors(int[] cost, int money)
        {
            int z = 0, x = 0;
            for (int i = 0; i < cost.Length; i++)
            {
                z = cost[i];
                for (int j = 0; j < cost.Length; j++)
                {
                    if (i == j) continue;

                    x = cost[j];
                    if (z + x == money)
                    {
                        z = i + 1;
                        x = j + 1;
                        i = cost.Length;
                        break;
                    }
                }
            }

            string result = (z <= x) ? z + " " + x : x + " " + z;
            Console.WriteLine(result);
        }


        public static string  whatFlavors2(int[] cost, int money)
        {
            Dictionary<int, int> falvours = new Dictionary<int, int>();
            bool IsFinished = false;
            int matchedMoney = money;

            for (int i = 0; i < cost.Length; i++)
            {

                for (int j = 0; j < cost.Length; j++)
                {
                    if (i == j) continue;


                    if (matchedMoney == (cost[i] + cost[j]))
                    {
                        falvours.Add(i + 1, cost[i]);
                        falvours.Add(j + 1, cost[j]);
                        IsFinished = true;
                        break;
                    }

                }
                if (IsFinished)
                    break;

                if (i == cost.Length - 1 && !IsFinished)
                {
                    matchedMoney--;
                    i = 0;
                }

            }

            string result = string.Empty;
            foreach (var falvour in falvours.OrderBy(f => f.Key))
            {
                result += falvour.Key + " ";
            }

            result = result.Remove(result.LastIndexOf(" "));

            
            Console.WriteLine(result);

            return result;


        }

        private static int GetTotal(Dictionary<int, int> intList)
        {
            int Total = 0;
            foreach (var num in intList)
            {
                Total += num.Value;
            }
            return Total;
        }
    }
}
