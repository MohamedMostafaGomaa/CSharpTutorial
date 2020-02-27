using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ArraysAndStrings
{
    public static class StringCompressionExt
    {
        public static string CompressLowerCase(this string source)
        {
            if (string.IsNullOrEmpty(source)) return string.Empty;

            source = source.Trim().ToLowerInvariant();
            var dest = new StringBuilder();

            var lastChar = source[0];
            var count = 0;
            foreach (var c in source)
            {
                if (lastChar != c)
                {
                    dest.AppendFormat("{0}{1}", lastChar, count);
                    lastChar = c;
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            dest.AppendFormat("{0}{1}", lastChar, count);

            return dest.Length < source.Length ? dest.ToString() : source;
        }

        public static string CompressLowerCase2(string source)
        {

            char[] sourceArr = source.ToCharArray();

            Dictionary<char, int> sourceCharactersCount = new Dictionary<char, int>();

            Hashtable ht = new Hashtable();

            for (int i = 0; i < sourceArr.Length - 1; i++)
            {
                if (ht.ContainsKey(sourceArr[i]))
                {

                    int count = int.Parse(ht[sourceArr[i]].ToString());
                    ht[sourceArr[i]] = count + 1;


                }
                else
                {
                    ht.Add(sourceArr[i], 1);
                }

            }

            StringBuilder strbuilder = new StringBuilder();

            foreach (DictionaryEntry item in ht)
            {
                strbuilder.Append(item.Key.ToString() + item.Value.ToString());
            }


            return strbuilder.ToString();
        }


        public static string CompressLowerCase3(string source)
        {

            char[] sourceArr = source.ToCharArray();

            string last = string.Empty;
            int count = 0;

            StringBuilder strbuilder = new StringBuilder();
            for (int i = 0; i < sourceArr.Length; i++)
            {
                string current = sourceArr[i].ToString();
                if (last == current)
                {
                    count++;
                    if (i == sourceArr.Length - 1)
                    {
                        strbuilder.Append(current + count.ToString());
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(last))
                        strbuilder.Append(last + count.ToString());
                    last = current;
                    count = 1;
                }

            }

            return strbuilder.ToString();
        }
    }


    public class StringCompressionTest
    {
        [TestCase("  aaa   ", ExpectedResult = "a3")]
        public string Should_trim_source(string input)
        {
            return input.CompressLowerCase();
        }

        [TestCase("aa", ExpectedResult = "aa")]
        public string Should_return_source_when_compressed_is_not_less(string input)
        {
            return input.CompressLowerCase();
        }

        [TestCase("", ExpectedResult = "")]
        [TestCase((string)null, ExpectedResult = "")]
        public string Should_return_empty_when_null_or_empty(string input)
        {
            return input.CompressLowerCase();
        }

        [TestCase("aabcccccaaa", ExpectedResult = "a2b1c5a3")]
        public string Should_count_each_group_of_charByHashTable(string input)
        {
            var result = StringCompressionExt.CompressLowerCase2(input);

            return result;

        }


        [TestCase("aabcccccaaa", ExpectedResult = "a2b1c5a3")]
        public string Should_count_each_group_of_char(string input)
        {
            var result = StringCompressionExt.CompressLowerCase3(input);
            return result;

        }
    }
}
