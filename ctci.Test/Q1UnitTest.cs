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
        public void IsUniqueCharsTest( string input , bool expected)
        {
            bool result = new Q1_01_Is_Unique().HasUniqueChar(input.ToLower());

            Assert.AreEqual(result, expected);
        }



        [Test]
        [TestCase("apple", "papel", true)]
        public void IsPermutationTest(string input1, string input2 , bool expected)
        {
            bool result = new Q1_02_Check_Permutation().IsPermutation2(input1, input2);

            Assert.AreEqual(result, expected);
        }


    }
}