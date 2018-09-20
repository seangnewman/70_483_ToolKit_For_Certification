using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap5_Demonstrating_Constructors
{
    public partial class Form1 : Form
    {
        public static string Results = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make some Persons
            Results += String.Format("Making Person(Bea) {0}", Environment.NewLine);
            Person bea = new Person("Bea");
            Results += Environment.NewLine;

            Results += String.Format("Making Person(Al, Able) {0}", Environment.NewLine);
            Person al = new Person("Al", "Able");
            Results += Environment.NewLine;

            // Make some Employees
            Results += String.Format("Making Employee(Carl) {0}", Environment.NewLine);
            Person carl = new Employee("Carl");
            Results += Environment.NewLine;

            Results += String.Format("Making Employee(Deb, Dart) {0}", Environment.NewLine);
            Person deb = new Employee("Deb", "Dart");
            Results += Environment.NewLine;

            Results += String.Format("Making Employee(Ed, Eager, IT) {0}", Environment.NewLine);
            Person ed = new Employee("Ed", "Eager", "IT");
            Results += Environment.NewLine;

            // Display the results
            txtResults.Text = Results;
            txtResults.Select(0, 0);
        }
    }
}
