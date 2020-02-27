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
    public partial class ThreadingExample : Form
    {
        public ThreadingExample()
        {
            InitializeComponent();
        }

        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            btnTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            // Create another THREAD to offload the work of
            // executing the time consuming method to it.
            // As a result the UI thread, is free to execute the
            // rest of the code and our application is more responsive.
            //Thread backGroundThread = new Thread(DoTimeConsumingWork);
            //backGroundThread.Start();
            DoTimeConsumingWork();

            btnTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBoxNumbers.Items.Add(i);
            }
        }

        private void DoTimeConsumingWork()
        {
            // Make the thread sleep, to introduce artifical latency
            Thread.Sleep(5000);
        }
    }
}
