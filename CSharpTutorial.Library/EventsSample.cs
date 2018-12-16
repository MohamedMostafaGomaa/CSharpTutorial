using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Library
{
    public delegate string MyDel(string str);
    public class EventsSample
    {
        event MyDel MyEvent;

        public EventsSample()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }

        public string Run()
        {
            EventsSample obj1 = new EventsSample();
            string result = obj1.MyEvent("Tutorials Point");
            return result;
        }

    }



    class EventProgram
    {
      

    }
}
