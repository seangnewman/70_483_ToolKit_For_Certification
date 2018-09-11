using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap6_Covariance_And_Cntravariance
{
    public partial class Form1 : Form
    {
        class Person
        {
            public string Name;

            // A method that returns a string
            public delegate string GetStringDelegate();

            // A static method
            public static string StaticName()
            {
                return "Static";
            }

            // Return this instance name
            public string GetName()
            {
                return Name;
            }

            //Variables to hold GetStringDelegate
            public GetStringDelegate StaticMethod;
            public GetStringDelegate InstanceMethod;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Make some persons
            Person alice = new Person() { Name = "Alice" };
            Person bob = new Person() { Name = "Bob" };

            //Make Alice's InstanceMethod varialble refer to ther own GetName method
            alice.InstanceMethod = alice.GetName;
            alice.StaticMethod = Person.StaticName;

            // Make Bob's InstanceMethod variable refer to Alice's GetName method
            bob.InstanceMethod = bob.GetName;
            bob.StaticMethod = Person.StaticName;

            // Demonstrate the methods
            string result = "";

            result += "Alice's InstanceMethod returns : " + alice.InstanceMethod() +
                Environment.NewLine;
            result += "Bob's InstanceMethod returns : " + bob.InstanceMethod() +
                Environment.NewLine;

            result += "Alice's StaticMethod returns : " + alice.StaticMethod() +
                Environment.NewLine;

            result += "Bob's StaticMethod returns : " + bob.StaticMethod() +
               Environment.NewLine;

            resultsTextBox.Text = result;
            resultsTextBox.Select(0, 0);

        }

       
    }
}
