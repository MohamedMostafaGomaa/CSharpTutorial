using ctci.Contracts;
using System;

namespace Chapter01
{
    public class Q1_03_URLify : Question
    {
        int Count_the_number_of_spaces(char[] input)
        {
            var spaceCount = 0;
            foreach (var character in input)
            {
                if (character == ' ')
                    spaceCount++;
            }
            return spaceCount;
        }

        private void ReplaceSpaces(char[] input, int length)
        {
            var space = new[] { '0', '2', '%' };
            var spaceCount = Count_the_number_of_spaces(input);
            // calculate new string size
            var index = length + spaceCount * 2;
            void SetCharsAndMoveIndex(params char[] chars)
            {
                foreach (var c in chars)
                    input[index--] = c;
            }
            // copying the characters backwards and inserting %20
            for (var indexSource = length - 1; indexSource >= 0; indexSource--)
                if (input[indexSource] == ' ')
                    SetCharsAndMoveIndex(space);
                else SetCharsAndMoveIndex(input[indexSource]);
        }


        // Get the array length after adding "%20"
        //Then replacing " " with "%20", Therfore +3 Char for the new string.
        public string URLify(char[] str, int trueLength)
        {
            var spaceCount = 0;
            for (var i = 0; i < trueLength; i++)
            {
                if (str[i] == ' ')
                {
                    spaceCount++;
                }
            }

            var index = trueLength + spaceCount * 2;
            if (trueLength < str.Length)
            {
                str[trueLength] = '\0';
            }

            for (var i = trueLength - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    str[index - 1] = '0';
                    str[index - 2] = '2';
                    str[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    str[index - 1] = str[i];
                    index--;
                }
            }
            return new string(str);
        }

        // Get the array length after adding "%20" ---
        //Then replacing " " with "%20", Therfore +3 Char for the new string.
        public string UrlifySpace(string input)
        {
            if (input == null) return null;

            const string replacer = "%20";
            const char replaced = ' ';
            var newLength = input.Length;

            // Get the array length after adding "%20"
            foreach (var c in input)
            {
                if (c == replaced)
                {
                    newLength += replacer.Length - 1;
                }
            }


            var newStringContent = new char[newLength];

            for (int i = 0, j = 0; i < input.Length; i++)
            {
                if (input[i] == replaced)
                {
                    //Start replacing " " with "%20"
                    for (int k = 0; k < replacer.Length; k++)
                    {
                        newStringContent[j] = replacer[k];
                        j++;
                    }
                }
                else
                {
                    newStringContent[j] = input[i];
                    j++;
                }

            }

            return new string(newStringContent);
        }

        public int Count_the_number_of_spaces2(char[] input)
        {
            var spaceCount = 0;
            foreach (var character in input)
            {
                if (character == ' ')
                    spaceCount++;
            }
            return spaceCount;
        }

        public void ReplaceSpaces2(char[] input, int length)
        {
            var space = new[] { '0', '2', '%' };
            var spaceCount = Count_the_number_of_spaces2(input);
            // calculate new string size
            var index = length + spaceCount * 2;
            void SetCharsAndMoveIndex(params char[] chars)
            {
                foreach (var c in chars)
                    input[index--] = c;
            }
            // copying the characters backwards and inserting %20
            for (var indexSource = length - 1; indexSource >= 0; indexSource--)
                if (input[indexSource] == ' ')
                    SetCharsAndMoveIndex(space);
                else SetCharsAndMoveIndex(input[indexSource]);
        }

        public override void Run()
        {
            const string input = "abc d e f";
            var characterArray = new char[input.Length + 3 * 2 + 1];

            for (var i = 0; i < input.Length; i++)
            {
                characterArray[i] = input[i];
            }

            ReplaceSpaces(characterArray, input.Length);
            Console.WriteLine("{0} -> {1}", input, new string(characterArray));
        }
    }
}