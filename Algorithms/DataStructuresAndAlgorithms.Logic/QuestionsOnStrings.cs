using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Logic
{
    //https://www.csharpstar.com/csharp-algorithms/

    public class QuestionsOnStrings
    {
        //How to Print duplicate characters in a String?
        public string RemoveDuplicateChars(string key)
        {
            // --- Removes duplicate chars using string concats. ---
            // Store encountered letters in this string.
            string table = "";

            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char value in key)
            {
                // See if character is in the table.
                if (table.IndexOf(value) == -1)
                {
                    // Append to the table and the result.
                    table += value;
                    result += value;
                }
            }
            return result;
        }


        //Determine if Two Words Are Anagrams of Each Other
        public bool DetermineAnagramsOfTwoWords(string word1, string word2)
        {

            //Add optional validation of input words if needed.  
            //.....  

            //step 1  
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            //Step 2  
            Array.Sort(char1);
            Array.Sort(char2);

            //Step 3  
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);

            //Step 4  
            //ToLower allows to compare the words in same case, in this case, lower case.  
            //ToUpper will also do exact same thing in this context  
            if (NewWord1 == NewWord2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //How to reverse String in C# using Iteration and Recursion
        public string ReverseString(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
                result += word[i];
            return result;
        }

        //Count number of words in a string
        public int CountNumberOfWordsInString(string str)
        {
            int result = 0;

            //Trim whitespace from beginning and end of string
            str = str.Trim();

            //Necessary because foreach will execute once with empty string returning 1
            if (str == "")
                return 0;

            //Ensure there is only one space between each word in the passed string
            while (str.Contains("  "))
                str = str.Replace("  ", " ");

            //Count the words
            foreach (string y in str.Split(' '))
                result++;

            return result;
        }


        //How to check if String is Palindrome
        public bool IsPalindrome(string word)
        {
            //"civic","kayak", "tenet","level"

            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }


        public static bool IsUnique(string s)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (d.ContainsKey(c))
                    return false;
                else
                    d.Add(c, 1);
            }
            return true;
        }

        //Compares each character to every other character without using an additional data structure
        //O(n^2) time complexity
        public static bool IsUnique1(string s)
        {
            string temp1 = "";
            string temp2 = "";

            for (int i = 0; i < s.Length; i++)
            {
                temp1 = s.Substring(i, 1);
                for (int k = 0; k < s.Length; k++)
                {
                    temp2 = s.Substring(k, 1);
                    if ((temp1 == temp2) && (i != k))
                        return false;
                }
            }
            return true;
        }

       

    }
}
