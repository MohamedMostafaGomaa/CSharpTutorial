using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    public static class StacksAndQueuesSample
    {
        public static bool IsBalancedBrackets(string s)
        {
            char[] BracketsList = s.ToCharArray();

            Stack<char> Brackets = new Stack<char>();

            for (int i = 0; i < BracketsList.Length; i++)
            {
                if (isLeftBracket(BracketsList[i]))
                {
                    Brackets.Push(BracketsList[i]);
                }
                else
                {
                    if (Brackets.Count() == 0 || !IsMatched(Brackets.Peek(), BracketsList[i]))
                        return false;
                    else Brackets.Pop(); ;
                }
            }

            return (Brackets.Count() == 0) ? true : false;
        }

        private static bool isLeftBracket(char c)
        {
            if (c.Equals('{') || c.Equals('[') || c.Equals('('))
                return true;
            else return false;
        }

        private static bool IsMatched(char leftBracket, char rightBracket)
        {
            string brackets = leftBracket.ToString() + rightBracket;

            if (brackets.Equals("{}") || brackets.Equals("[]") || brackets.Equals("()"))
                return true;
            else return false;
        }


    }
}
