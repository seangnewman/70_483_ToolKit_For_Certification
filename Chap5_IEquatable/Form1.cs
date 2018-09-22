using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap5_IEquatable
{
    public partial class Form1 : Form
    {
        // The List of Persons
        private List<Person> People = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Make the new Person
            Person person = new Person()
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text
            };

            if (People.Contains(person))
            {
                MessageBox.Show("The list contains this person.");
            }
            else
            {
                People.Add(person);
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                firstNameTextBox.Focus();
            }
        }


    }


 }
    

