using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStartDelegateExample
{
    // Step 1: Create a callback delegate. The actual callback method
    // signature should match with the signature of this delegate.
    public delegate void SumOfNumbersCallback(int sumOfNumbers);
    class Program
    {
        // Callback method that will receive the sum of numbers
        public static void PrintSumOfNumbers(int sum)
        {
            Console.WriteLine("Sum of numbers is " + sum);
        }
        static void Main(string[] args)
        {
            // Prompt the user for the target number
            Console.WriteLine("Please enter the target number");
            // Read from the console and store it in target variable
            int target = Convert.ToInt32(Console.ReadLine());

            // Create an instance of callback delegate and to it's constructor
            // pass the name of the callback function (PrintSumOfNumbers)
            SumOfNumbersCallback callbackMethod = new SumOfNumbersCallback(PrintSumOfNumbers);

            // Create an instance of Number class and to it's constrcutor pass the target
            // number and the instance of callback delegate
            Number number = new Number(target, callbackMethod);

            // Create an instance of Thread class and specify the Thread function to invoke
            Thread T1 = new Thread(new ThreadStart(number.ComputeSumOfNumbers));
            T1.Start();
        }

        static void PassParameterizedThreadStart()
        {
            /*Console.WriteLine("Please enter the target number");
            object target = Console.ReadLine();

            // Create an instance ParameterizedThreadStart delegate
            ParameterizedThreadStart parameterizedThreadStart =
                new ParameterizedThreadStart(Number.PrintNumbers);
            Thread T1 = new Thread(parameterizedThreadStart);
            // Pass the traget number to the start function, which
            // will then be passed automatically to PrintNumbers() function
            T1.Start(target);*/
        }

        //static void PassDataToThreadInTypeSafeManner()
        //{
        //    // Prompt the user for the target number
        //    Console.WriteLine("Please enter the target number");
        //    // Read from the console and store it in target variable
        //    int target = Convert.ToInt32(Console.ReadLine());

        //    // Create an instance of the Number class, passing it
        //    // the target number that was read from the console
        //    Number number = new Number(target);
        //    // Specify the Thread function
        //    Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
        //    // Alternatively we can just use Thread class constructor as shown below
        //    // Thread T1 = new Thread(number.PrintNumbers);
        //    T1.Start();
        //}


    }

    // Step 2: Create Number class to compute the sum of numbers and
    // to call the callback method
    class Number
    {
        // The traget number this class needs to compute the sum of numbers
        int _target;

        // Delegate to call when the the Thread function completes                 
        // computing the sum of numbers
        SumOfNumbersCallback _callbackMethod;

        // Constructor to initialize the target number and the callback delegateinitialize
        public Number(int target, SumOfNumbersCallback callbackMethod)
        {
            this._target = target;
            this._callbackMethod = callbackMethod;
        }

        // This thread function computes the sum of numbers and then invokes
        // the callback method passing it the sum of numbers
        public void ComputeSumOfNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= _target; i++)
            {
                sum = sum + i;
            }

            if (_callbackMethod != null)
            {
                _callbackMethod(sum);
            }
        }
    }
}
    /*class Number
    {
        //public static void PrintNumbers(object target)
        //{
        //    int number = 0;
        //    if (int.TryParse(target.ToString(), out number))
        //    {
        //        for (int i = 1; i <= number; i++)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}


        int _target;
        // When an instance is created, the target number needs to be specified
        public Number(int target)
        {
            // The targer number is then stored in the class private variable _target
            this._target = target;
        }

        // Function prints the numbers from 1 to the traget number that the user provided
        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }*/
