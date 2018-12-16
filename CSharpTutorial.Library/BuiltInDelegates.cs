using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Library
{
    public class BuiltInDelegates
    {


        #region Func 

        static int Sum(int x, int y)
        {
            return x + y;
        }

        public int CheckFunc(int x, int y)
        {
            Func<int, int, int> add = Sum;

            int result = add(x, y);

            return result;
        }


        public int CheckFuncWithAnonmousMethod()
        {

            Func<int,int,int> getRandomNumber = delegate (int x,int y)
            {
                Random rnd = new Random();
                return rnd.Next(x,y );
            };

            return getRandomNumber(1,100);
        }


        public int CheckFuncWithLambdaExpression()
        {
            Func<int> getRandomNumber = () => new Random().Next(1, 100);
            return getRandomNumber();

            //Or 
            //Func<int, int, int> Sum = (x, y) => x + y;

            //return Sum(10,10);

        }


        #endregion


        #region Action


        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        public void CheckAction()
        {

            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);

            //Or

            Action<int> printActionDel2 = new Action<int>(ConsolePrint);

            //Anonymous method with Action delegate

            Action<int> printActionDel3 = delegate (int i)
            {
                Console.WriteLine(i);
            };

            printActionDel(10);

        }



        #endregion


        #region Predicate 

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        
        public void CheckPredicate()
        {

            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("hello world!!");

            //Anonymous method with Predicate delegate
            Predicate<string> isUpper2 = delegate (string s) { return s.Equals(s.ToUpper()); };
            bool result2 = isUpper("hello world!!");

            //Lambda Exp with Predicate delegate
            Predicate<string> isUpper3 = s => s.Equals(s.ToUpper());
            bool result3 = isUpper("hello world!!");

        }

        #endregion
    }
}
