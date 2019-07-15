using System;
using ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ch_01.Arrays_and_Strings.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public bool HasUniqueChar_test()
        {
            string input = "abcda";
            //return input.HasUniqueChar();
            return UniqueChar.HasUniqueChar(input);
        }
    }
}
