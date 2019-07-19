using ctci.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter01
{
    public class Q1_01_Is_Unique : Question
    {

        public bool IsUniqueChars1(String str)
        {
            if (str.Length > 128) return false;

            char[] arrInput = str.ToCharArray();

            bool[] char_set = new bool[128];

            for (int i = 0; i < arrInput.Length; i++)
            {
                int val = (int)arrInput[i];

                if (char_set[val])
                {//Already found this char in string
                    return false;
                }
                char_set[val] = true;
            }
            return true;
        }

        public bool IsUniqueChars(string str)
        {
            if (str.Length > 256)
            {
                return false;
            }

            var checker = 0;
            for (var i = 0; i < str.Length; i++)
            {
                var val = str[i] - 'a';

                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }

            return true;
        }

        public bool IsUniqueChars2(String str)
        {
            var hashset = new HashSet<char>();
            foreach (var c in str)
            {
                if (hashset.Contains(c)) return false;
                hashset.Add(c);
            }

            return true;
        }

        public bool HasUniqueChar(string source)
        {
            var existingChar = new bool[char.MaxValue];

            foreach (var c in source)
            {
                if (existingChar[c]) return false;
                existingChar[c] = true;
            }
            return true;
        }

        // O(n lg2(n))
        public bool HasUniqueCharByOrdering(string source)
        {
            var orderedSource = source.OrderBy(c => c).ToArray();
            for (int i = 0; i < orderedSource.Length - 1; i++)
            {
                if (orderedSource[i] == orderedSource[i + 1]) return false;
            }
            return true;
        }

        public bool HasUniqueLowerChar(string source)
        {
            source = source.ToLowerInvariant();

            var existingChar = 0;

            foreach (var c in source)
            {
                var charBitIndex = 1 << (c - 'a');

                if ((existingChar & charBitIndex) > 0) return false;
                existingChar |= charBitIndex;
            }
            return true;
        }

        public override void Run()
        {
            string[] words = { "abcde", "hello", "apple", "kite", "padle" };

            foreach (var word in words)
            {
                Console.WriteLine(word + ": " + IsUniqueChars(word) + " " + IsUniqueChars2(word));
            }
        }


        //public bool Start(string input)
        //{
        //    bool result = false;
        //    IList<bool> results = new List<bool>();

        //    char[] arr = input.ToCharArray();

        //    foreach (var c in arr)
        //    {
        //        results.Add(IsUniqueChars(c));
        //    }


        //}
    }
}