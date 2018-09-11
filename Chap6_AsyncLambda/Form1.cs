using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap6_AsyncLambda
{
    public partial class Form1 : Form
    {
        private int Trials;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            runAsyncButton.Click += async (button, buttonArgs) =>
            {
                int trial = ++Trials;
                statusLabel.Text = "Running trial " + trial.ToString() + "...";

                await DoSomethingAsync();

                statusLabel.Text = "Done with trail " + trial.ToString();
            };
           
        }

        async static Task DoSomethingAsync()
        {
            //In this example, just waste some time
            await Task.Delay(4000);
        }
    }
}
