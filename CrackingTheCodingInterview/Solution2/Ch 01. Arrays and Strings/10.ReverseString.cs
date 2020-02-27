using NUnit.Framework;
using System;

namespace ArraysAndStrings
{
    // Write code to reverse a C-Style String. (C-String means that “abcd” is represented as
    // five characters, including the null character.)
    public static class ReverseStringExt
    {
        public static string ReverseString(this string source)
        {
            char[] sourceAsArray = source.ToCharArray();
            for (int i = 0, j = sourceAsArray.Length - 1; i <= j; i++, j--)
            {
                var tmp = sourceAsArray[j];
                sourceAsArray[j] = sourceAsArray[i];
                sourceAsArray[i] = tmp;
            }
            return new string(sourceAsArray);
        }

        public static bool isSubstring(string str1, string str2)
        {
            char[] str1Arr = str1.ToCharArray();
            char[] str2Arr = str2.ToCharArray();

            Array.Sort(str1Arr);
            Array.Sort(str2Arr);

            str1 = new string(str1Arr);
            str2 = new string(str2Arr);

            if (str1.Contains(str2))
                return true;
            else if (str2.Contains(str1))
                return true;
            else return false;
        }

    }

    public class ReverseStringTest
    {
        [TestCase("", ExpectedResult = "")]
        [TestCase("a", ExpectedResult = "a")]
        [TestCase("ab", ExpectedResult = "ba")]
        [TestCase("abc", ExpectedResult = "cba")]
        [TestCase("Fizz", ExpectedResult = "zziF")]
        public string ReverseString_Test(string source)
        {
            return source.ReverseString();
        }


        //[TestCase("",  "", true)]
        //[TestCase("a",  "a", true)]
        [TestCase("waterbottle", "erbottlewat", true)]
        [TestCase("egypt", "egypte", true)]
        [TestCase("egypt", "canada", false)]
        //[TestCase("abc", "cba", true)]
        //[TestCase("Fizz", "zziF", true)]
        public void ReverseString_Test2(string source1, string source2, bool expected)
        {
            var result = ReverseStringExt.isSubstring(source1, source2);
            Assert.AreEqual(result, expected);
        }
    }
}
