using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresAndAlgorithms.Logic;

namespace DataStructuresAndAlgorithms.Test
{
    [TestFixture]
    class QuestionsOnStringsTest
    {
        [Test]
        //[TestCase("Csharpstar" , "Csharpt")]
        //[TestCase("Google", "Gole")]
        //[TestCase("Yahoo", "Yaho")]
        //[TestCase("CNN","CN")]
        [TestCase("Line1\\Line2\\Line3", "Line1\\23")]
        public void RemoveDuplicateCharsTest(string input, string expected)
        {
            QuestionsOnStrings obj = new QuestionsOnStrings();

            var result = obj.RemoveDuplicateChars(input);
            Assert.AreEqual(result, expected);
        }



        [Test]
        [TestCase("Silent", "Listen", true)]
        [TestCase("post", "opts", true)]
        [TestCase("Hamada", "7amada", false)]
        public void DetermineAnagramsOfTwoWords(string word1, string word2 , bool expected)
        {
            QuestionsOnStrings obj = new QuestionsOnStrings();

            var result = obj.DetermineAnagramsOfTwoWords(word1, word2);
            Assert.AreEqual(result, expected);
        }


        [Test]
        [TestCase("Hello", "olleH")]
        public void ReverseStrinTest(string word, string expected)
        {
            QuestionsOnStrings obj = new QuestionsOnStrings();

            var result = obj.ReverseString(word);
            Assert.AreEqual(result.ToLower(), expected.ToLower());
        }


        [Test]
        [TestCase("Welcome to Canada", 3)]
        public void CountNumberOfWordsInStringTest(string str, int expected)
        {
            QuestionsOnStrings obj = new QuestionsOnStrings();

            var result = obj.CountNumberOfWordsInString(str);
            Assert.AreEqual(result, expected);
        }


        [Test]
        [TestCase("Level",true)]
        [TestCase("Levvel", true)]
        [TestCase("Levrel", false)]
        public void IsPalindromeTest(string str, bool expected)
        {
            QuestionsOnStrings obj = new QuestionsOnStrings();

            var result = obj.IsPalindrome(str.ToLower());
            Assert.AreEqual(result, expected);
        }


        [Test]
        [TestCase("Level", true)]
        [TestCase("Levvel", true)]
        [TestCase("Levrel", false)]
        public void IsUnique(string str, bool expected)
        {
            QuestionsOnStrings obj = new QuestionsOnStrings();

            var result = obj.IsPalindrome(str.ToLower());
            Assert.AreEqual(result, expected);
        }
    }
}
