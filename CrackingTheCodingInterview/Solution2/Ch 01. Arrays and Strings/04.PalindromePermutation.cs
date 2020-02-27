using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ArraysAndStrings
{
    public static class PalindromePermutationExt
    {
        public static bool IsPalindromePermutation(this string source)
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


        public static bool IsPalindromePermutation2(string input)
        {
            char[] inputArr = input.ToCharArray();
            Stack<char> charStack = new Stack<char>(inputArr);
            Queue<char> charQueue = new Queue<char>(inputArr);

            for (int j = 0; j < inputArr.Length; j++)
            {
                if (charStack.Peek() == charQueue.Peek())
                {
                    charStack.Pop();
                    charQueue.Dequeue();
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class PalindromePermutationTests
    {
        [TestCase("taco cat", ExpectedResult = true)]
        [TestCase("taco catt", ExpectedResult = false)]
        [TestCase("tactcoapapa", ExpectedResult = true)]
        public bool Should_Return_true_When_is_Palindrome_permutation(string input)
        {
            bool result = input.IsPalindromePermutation();
            return result;
        }

        [TestCase("tacocat", ExpectedResult = true)]
        [TestCase("taco catt", ExpectedResult = false)]
        [TestCase("Rats live on no evil star", ExpectedResult = true)]
        public bool Should_Return_true_When_is_Palindrome_permutation2(string input)
        {
            bool result = PalindromePermutationExt.IsPalindromePermutation2(input.ToLower());
            return result;
        }
    }
}
