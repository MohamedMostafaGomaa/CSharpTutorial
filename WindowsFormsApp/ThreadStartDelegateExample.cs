using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ThreadStartDelegateExample : Form
    {
        public ThreadStartDelegateExample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread T1 = new Thread(Number.PrintNumbers);

            //Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));

            //Thread T1 = new Thread(Number.PrintNumbers);
            //Thread T1 = new Thread(delegate() { Number.PrintNumbers(); });
            //

            T1.Start();
        }
    }

    class Number
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
