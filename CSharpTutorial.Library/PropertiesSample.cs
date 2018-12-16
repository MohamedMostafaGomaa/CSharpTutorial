using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Library
{
    public class PropertiesSample
    {
        public List<string> Execute()
        {
            List<string> results = new List<string>();
            // Create a new Student object:
            Student s = new Student();

            // Setting code, name and the age of the student
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 9;
            results.Add(string.Format("Student Info:- {0}", s));

            //let us increase age
            s.Age += 1;
            results.Add(string.Format("Student Info:- {0}", s));

            return results;


        }
    }

    public abstract class Person
    {
        public abstract string Name
        {
            get;
            set;
        }
        public abstract int Age
        {
            get;
            set;
        }
    }
    class Student : Person
    {
        private string code = "N.A";
        private string name = "N.A";
        private int age = 0;

        // Declare a Code property of type string:
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        // Declare a Name property of type string:
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Declare a Age property of type int:
        public override int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }

    class ExampleDemo
    {
        public static void Main()
        {

        }
    }
}
