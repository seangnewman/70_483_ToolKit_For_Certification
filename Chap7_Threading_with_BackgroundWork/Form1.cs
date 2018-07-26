using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap7_Threading_with_BackgroundWork
{
    public partial class Form1 : Form
    {

        private BackgroundWorker worker;

        public Form1()
        {
            InitializeComponent();

            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }

        void worker_RunWorkerCompleted(object Sender, RunWorkerCompletedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>( UpdateLabel), e.Result.ToString());

            }
            else
            {
                UpdateLabel(e.Result.ToString());
            }

            
        }

        private void UpdateLabel (string text)
        {
            lblResult.Text = text;
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = DoIntensiveCalculations();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static double DoIntensiveCalculations()
        {
            // We are simulating intensive calculations
            // by performing nonsense divisions
            double result = 1000000000d;
            var maxValue = Int32.MaxValue;

            for (int i = 1; i < maxValue; i++)
            {
                result /= i;
                //Console.WriteLine("The result is {0}", i);
            }
            return result + 10d;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }
    }
}
