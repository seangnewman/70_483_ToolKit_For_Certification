using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap5_IDisposable
{
    public partial class Form1 : Form
    {
        private int ObjectNumber = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void createAndDisposeButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            using (DisposableClass obj = new DisposableClass())
            {
                obj.Name = String.Format("CreateAndDispose {0}", ObjectNumber.ToString());
                ObjectNumber++;

            }

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Make an object
            DisposableClass obj = new DisposableClass();
            obj.Name = String.Format("Create {0}", ObjectNumber.ToString());
            ObjectNumber++;

        }

        private void collectGarbageButton_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
