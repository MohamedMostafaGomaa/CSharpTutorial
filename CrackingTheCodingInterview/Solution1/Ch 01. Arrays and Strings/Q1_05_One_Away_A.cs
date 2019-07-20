using ctci.Contracts;
using System;

namespace Chapter01
{
    public class Q1_05_One_Away_A : Question
    {
        private static bool OneEditReplace(String s1, String s2)
        {
            bool foundDifference = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (foundDifference)
                    {
                        return false;
                    }

                    foundDifference = true;
                }
            }
            return true;
        }

        /* Check if you can insert a character into s1 to make s2. */

        private static bool OneEditInsert(String s1, String s2)
        {
            int index1 = 0;
            int index2 = 0;
            while (index2 < s2.Length && index1 < s1.Length) // we don't need to finish the loop for the larger element if smaller arrays element equals the larger first elements
            {
                if (s1[index1] != s2[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }

        public static bool OneEditAway(String first, String second)
        {
            if (first.Length == second.Length)
            {
                return OneEditReplace(first, second);
            }
            else if (first.Length + 1 == second.Length)
            {
                return OneEditInsert(first, second);
            }
            else if (first.Length - 1 == second.Length)
            {
                return OneEditInsert(second, first);
            }
            return false;
        }

        public static bool OneEditAway2(String first, String second)
        {
            /* Length checks. */
            if (Math.Abs(first.Length - second.Length) > 1)
            {
                return false;
            }

            /* Get shorter and longer string.*/
            String s1 = first.Length < second.Length ? first : second;
            String s2 = first.Length < second.Length ? second : first;

            int index1 = 0;
            int index2 = 0;
            bool foundDifference = false;
            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    /* Ensure that this is the first difference found.*/
                    if (foundDifference) return false;
                    foundDifference = true;
                    if (s1.Length == s2.Length)
                    { // On replace, move shorter pointer
                        index1++;
                    }
                }
                else
                {
                    index1++; // If matching, move shorter pointer
                }
                index2++; // Always move pointer for longer string
            }
            return true;
        }


        public static bool IsOneAwayFrom(string source, string other)
        {
            var hasOneInsertFrom = HasOneInsertOrDeleteFrom(source, other);
            var hasOneChange = HasOneChangeFrom(source, other);

            return hasOneInsertFrom ^ hasOneChange;
        }

        private static bool HasOneChangeFrom(string source, string other)
        {
            if (source.Length != other.Length) { return false; }

            var changDetected = false;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != other[i])
                {
                    if (changDetected) { return false; }
                    changDetected = true;
                }
            }
            return changDetected;
        }

        private static bool HasOneInsertOrDeleteFrom(string source, string other)
        {
            if (source.Length > other.Length)
            {
                return HasOneInsertOrDeleteFrom(other, source);
            }

            var index1 = 0;
            var index2 = 0;

            while (index1 < source.Length && index2 < other.Length)
            {
                if (source[index1] != other[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;

        }


        public override void Run()
        {
            String a = "pse";
            String b = "pale";
            bool isOneEdit = OneEditAway(a, b);
            Console.WriteLine("{0}, {1}: {2}", a, b, isOneEdit);

            bool isOneEdit2 = OneEditAway2(a, b);
            Console.WriteLine("{0}, {1}: {2}", a, b, isOneEdit2);
        }
    }
}