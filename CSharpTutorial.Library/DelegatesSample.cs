using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


delegate int NumberChanger(int n);
namespace CSharpTutorial.Library
{

    public class DelegatesSample
    {
        int num = 1;
        public DelegatesSample(int number)
        {
            num = number;
        }

        public List<string> run()
        {
            List<string> results = new List<string>();

            /*NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            results.Add(string.Format("Value of Num: {0}", getNum()));
            nc2(5);
            results.Add(string.Format("Value of Num: {0}", getNum()));*/


            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            nc = nc1;
            nc += nc2;

            //calling multicast
            nc(5);
            results.Add(string.Format("Value of Num: {0}", getNum()));

            return results;
        }



        public int AddNum(int p)
        {
            num += p;
            return num;
        }
        public int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public int getNum()
        {
            return num;
        }

    }

}
