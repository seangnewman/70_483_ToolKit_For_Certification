using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap5_ICloneable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person ann = new Person()
            {
                FirstName = "Ann",
                LastName = "Archer",
                Manager = null
            };

            Person bob = new Person()
            {
                FirstName = "Bob",
                LastName = "Baker",
                Manager = "ann"
            };

            Person archie = (Person)bob.Clone();

            lblFirstName.Text = archie.FirstName;
            lblLastName.Text = archie.LastName;
        }
    }
}
