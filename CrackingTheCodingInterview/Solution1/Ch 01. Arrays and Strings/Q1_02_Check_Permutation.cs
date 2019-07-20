using ctci.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter01
{
    //Check Permutation: Given two strings,
    //write a method to decide if one is a permutation of the other
    public class Q1_02_Check_Permutation : Question
    {
        //Sort the strings. 
        public bool IsPermutation(string original, string valueToTest)
        {
            if (original.Length != valueToTest.Length)
            {
                return false;
            }

            var originalAsArray = original.ToCharArray();
            Array.Sort(originalAsArray);
            original = new string(originalAsArray);

            var valueToTestAsArray = valueToTest.ToCharArray();
            Array.Sort(valueToTestAsArray);
            valueToTest = new string(valueToTestAsArray);

            return original.Equals(valueToTest);
        }

        //Check if the two strings have identical character counts. 
        public bool IsPermutation2(string original, string valueToTest)
        {
            if (original.Length != valueToTest.Length)
            {
                return false;
            }

            var letterCount = new Dictionary<char, int>();

            foreach (var character in original)
            {
                if (letterCount.ContainsKey(character))
                    letterCount[character]++;
                else
                    letterCount[character] = 1;
            }

            foreach (var character in valueToTest)
            {
                if (letterCount.ContainsKey(character))
                {
                    letterCount[character]--;
                    if (letterCount[character] < 0)
                    {
                        return false;
                    }
                }
                else return false;
            }

            return true;
        }

        //Sort the strings. 
        // O(3n lg(n))
        public bool IsPermutationOf_sort(string source, string other)
        {
            if (source.Length != other.Length) { return false; }

            var sortedSource = source.OrderBy(c => c).ToArray();
            var sortedOther = other.OrderBy(c => c).ToArray();
            for (int i = 0; i < source.Length; i++)
            {
                if (sortedSource[i] != sortedOther[i])
                    return false;
            }
            return true;

        }

        //Check if the two strings have identical character counts. 
        // O(3n)
        public bool IsPermutationOf(string source, string other)
        {
            if (source.Length != other.Length) { return false; }

            var charMap = new int[char.MaxValue];

            foreach (var c in source)
            {
                charMap[c]++;
            }

            foreach (var c in other)
            {
                charMap[c]--;
            }

            return charMap.All(i => i == 0);
        }

        public override void Run()
        {
            string[][] pairs =
            {
                new string[]{"apple", "papel"},
                new string[]{"carrot", "tarroc"},
                new string[]{"hello", "llloh"}
            };

            foreach (var pair in pairs)
            {
                var word1 = pair[0];
                var word2 = pair[1];
                var result1 = IsPermutation(word1, word2);
                var result2 = IsPermutation2(word1, word2);
                Console.WriteLine("{0}, {1}: {2} / {3}", word1, word2, result1, result2);
            }
        }
    }
}