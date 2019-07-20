using NUnit.Framework;
using Chapter01;

namespace Tests
{
    public class Q1UnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("%$*(Mohamed", false)]
        [TestCase("Omar", true)]
        public void IsUniqueCharsTest(string input, bool expected)
        {
            bool result = new Q1_01_Is_Unique().HasUniqueChar(input.ToLower());

            Assert.AreEqual(result, expected);
        }



        [Test]
        [TestCase("apple", "papel", true)]
        [TestCase("carrot", "tarroc", true)]
        [TestCase("hello", "llloh", false)]

        public void IsPermutationTest(string input1, string input2, bool expected)
        {
            //bool result1 = new Q1_02_Check_Permutation().IsPermutation(input1, input2);
            bool result2 = new Q1_02_Check_Permutation().IsPermutationOf(input1, input2);

            Assert.AreEqual(result2, expected);
        }

        [Test]

        [TestCase("Mr John Smith", "Mr%20John%20Smith")]
        [TestCase("Mr John Smith   ", "Mr%20John%20Smith")]
        [TestCase("abc", "abc")]
        [TestCase("ab c", "ab%20c")]
        [TestCase(" ", "%20")] // Failed
        [TestCase(null, null)] // failed
        [TestCase("Mr John Smith", ExpectedResult = "Mr%20John%20Smith")]
        public void Should_replace_space_by_percent20(string input, string ExpectedResult)
        {
            var arr = input.ToCharArray();
            var result = new Q1_03_URLify().URLify(arr, input.Trim().Length);
            Assert.AreEqual(result, ExpectedResult);
        }


        [Test]
        //[TestCase("Mr John Smith", "Mr%20John%20Smith")]
        //[TestCase("Mr John Smith   ", "Mr%20John%20Smith")]
        //[TestCase("abc", "abc")]
        //[TestCase("ab c", "ab%20c")]
        //[TestCase(" ", "%20")] // Failed
        //[TestCase(null, null)] // Failed
        public void Should_Replace_space_by_percent20(string input, string expected)
        {
            string result = new Q1_03_URLify().UrlifySpace(input.Trim());
            Assert.That(result, Is.EqualTo(expected));
        }


        [Test]
        [TestCase("taco cat", true)]
        [TestCase("taco catt", false)]
        [TestCase("tactcoapapa", true)]
        public void Should_Return_true_When_is_Palindrome_permutation(string input, bool expectedResult)
        {
            bool result = Q1_04_Palindrome_Permutation.IsPalindromePermutation(input);
            Assert.AreEqual(result, expectedResult);
        }


        [Test]
        [TestCase("pleq", "ple", true)]
        [TestCase("pale", "ple", true)]
        [TestCase("ple", "pale", true)]
        [TestCase("pales", "pale", true)]
        [TestCase("pale", "bale", true)]
        [TestCase("pale", "bae", false)]
        public void Should_return_true_when_exactly_one_change(string source, string other, bool expected)
        {
            bool result = Q1_05_One_Away_A.OneEditAway(source, other);
            Assert.AreEqual(result, expected);

        }


        [Test]
        [TestCase("  aaa   ", "a3")]
        [TestCase("aa", "aa")]
        [TestCase("", "")]
        [TestCase((string)null, "")]
        [TestCase("aabcccccaaa", "a2b1c5a3")]
        public void Should_trim_source(string input, string expected)
        {
            var result = Q1_06_String_Compression.CompressLowerCase(input);
            Assert.AreEqual(result, expected);
        }



        [Test]
        public void Should_Return_rotated_matrix_by_90_Clockwise()
        {
            var matrix = new int[3][];
            matrix[0] = new[] { 1, 2, 3 };
            matrix[1] = new[] { 4, 5, 6 };
            matrix[2] = new[] { 7, 8, 9 };

            var expexcted = new int[3][];
            expexcted[0] = new[] { 7, 4, 1 };
            expexcted[1] = new[] { 8, 5, 2 };
            expexcted[2] = new[] { 9, 6, 3 };


            var result = Q1_07_Rotate_Matrix.Rotate(matrix);

            // Assert
            Assert.That(result, Is.EqualTo(expexcted));
        }

        [Test]
        public void Should_Return_rotated_matrixOddSize_by_90_Clockwise()
        {
            var matrix = new int[4][];
            matrix[0] = new[] { 1, 2, 3, 4 };
            matrix[1] = new[] { 5, 6, 7, 8 };
            matrix[2] = new[] { 9, 10, 11, 12 };
            matrix[3] = new[] { 13, 14, 15, 16 };

            var expexcted = new int[4][];
            expexcted[0] = new[] { 13, 9, 5, 1 };
            expexcted[1] = new[] { 14, 10, 6, 2 };
            expexcted[2] = new[] { 15, 11, 7, 3 };
            expexcted[3] = new[] { 16, 12, 8, 4 };

             var result = Q1_07_Rotate_Matrix.Rotate(matrix);

            // Assert
            Assert.That(result, Is.EqualTo(expexcted));
        }

    }
}