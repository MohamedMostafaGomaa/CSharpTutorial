using ctci.Contracts;
using System;
using System.Linq;

namespace Chapter01
{
    //A palindrome is a word or phrase that is the same forwards and backwards.
    //A permutation is a rearrangement of letters.
    //The palindrome does not need to be limited to just dictionary words. 
    public class Q1_04_Palindrome_Permutation : Question
    {
        private static int GetCharNumber(char c)
        {
            var val = char.ToLower(c) - 'a';
            if (0 <= val && val <= 25)
            {
                return val;
            }
            return -1;
        }

        private static int[] BuildCharFrequencyTable(String phrase)
        {
            int[] table = new int[26];
            foreach (char c in phrase)
            {
                int x = GetCharNumber(c);
                if (x != -1)
                {
                    table[x]++;
                }
            }
            return table;
        }

        #region Solution 1

        private static bool CheckMaxOneOdd(int[] table)
        {
            bool foundOdd = false;
            foreach (int count in table)
            {
                if (count % 2 == 1)
                {
                    if (foundOdd)
                    {
                        return false;
                    }
                    // if the count becomes odd after setting foundOdd = true,
                    //this means the word or phrase is not the same forwards and backwards.
                    foundOdd = true;
                }
            }
            return true;
        }

        //Implementing this algorithm is fairly straightforward.
        //We use a hash table to count how many times each character appears.
        //Then, we iterate through the hash table and ensure that no more than one character has an odd count. 
        //This algorithm takes O ( N) time, where N is the length of the string. 
        public static bool IsPermutationOfPalindrome(String phrase)
        {
            int[] table = BuildCharFrequencyTable(phrase);
            return CheckMaxOneOdd(table);
        }

        #endregion Solution 1

        #region Solution 2


        //We can't optimize the big O time here since any algorithm will always have
        //to look through the entire string. However, we can make some smaller
        //incremental improvements. Because this is a relatively simple problem,
        //it can be worthwhile to discuss some small optimizations or
        //at least some tweaks. Instead of checking the number of odd counts at the end,
        //we can check as we go along.
        //Then, as soon as we get to the end, we have our answer. 
        public static bool IsPermutationOfPalindrome2(String phrase)
        {
            int countOdd = 0;
            int[] table = new int[26];
            foreach (char c in phrase.ToCharArray())
            {
                int x = GetCharNumber(c);
                if (x != -1)
                {
                    table[x]++;

                    if (table[x] % 2 == 1)
                    {
                        countOdd++;
                    }
                    else
                    {
                        countOdd--;
                    }
                }
            }
            // Means that 2 or more will make it not permutation.
            return countOdd <= 1; 
        }

        #endregion Solution 2

        #region Solution 3

        /* Toggle the ith bit in the integer. */

        private static int Toggle(int bitVector, int index)
        {
            if (index < 0) return bitVector;

            int mask = 1 << index;
            if ((bitVector & mask) == 0)
            {
                bitVector |= mask;
            }
            else
            {
                bitVector &= ~mask;
            }
            return bitVector;
        }

        /* Create bit vector for string. For each letter with value i,
         * toggle the ith bit. */

        private static int MarkBitForOddCharacterCount(String phrase)
        {
            int bitVector = 0;
            foreach (char c in phrase.ToCharArray())
            {
                int x = GetCharNumber(c);
                bitVector = Toggle(bitVector, x);
            }
            return bitVector;
        }

        /* Check that exactly one bit is set by subtracting one from the
         * integer and ANDing it with the original integer. */

        private static bool CheckExactlyOneBitSet(int bitVector)
        {
            return (bitVector & (bitVector - 1)) == 0;
        }

        public static bool IsPermutationOfPalindrome3(String phrase)
        {
            int bitVector = MarkBitForOddCharacterCount(phrase);
            return bitVector == 0 || CheckExactlyOneBitSet(bitVector);
        }

        #endregion Solution 3

        //Count every Char
        //Check if there is odd count
        //Check if the odd count equals 1 to make sure it can be the same forwards and backwards
        public static bool IsPalindromePermutation(string source)
        {
            var cleanSource = source.ToLowerInvariant().Replace(" ", string.Empty);

            var groupByChar = cleanSource.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());


            // odd
            var hasOddCountOfChar = cleanSource.Length % 2 == 1;

            if (hasOddCountOfChar)
            {
                var countOfOddChar = groupByChar.Count(pair => pair.Value % 2 == 1);
                return countOfOddChar == 1;
            }

            // even
            return groupByChar.All(pair => pair.Value % 2 == 0);
        }

        public override void Run()
        {
            String[] strings = {"Rats live on no evil star",
                            "A man, a plan, a canal, panama",
                            "Lleve",
                            "Tacotac",
                            "asda"};

            foreach (String s in strings)
            {
                bool a = IsPermutationOfPalindrome(s);
                bool b = IsPermutationOfPalindrome2(s);
                bool c = IsPermutationOfPalindrome3(s);
                Console.WriteLine(s);
                if (a == b && b == c)
                {
                    Console.WriteLine("Agree: " + a);
                }
                else
                {
                    Console.WriteLine("Disagree: " + a + ", " + b + ", " + c);
                }
                Console.WriteLine();
            }
        }
    }
}