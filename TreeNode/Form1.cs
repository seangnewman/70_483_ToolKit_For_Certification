using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeNode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Build the tree
            TreeNode president = new TreeNode("President");
            TreeNode sales = president.AddChild("VP Sales");
            sales.AddChild("Domestic Sales");
            sales.AddChild("International Sales");

            TreeNode manager = new TreeNode("Manager");
            sales = manager.AddChild("Sales Manager");
            sales.AddChild("Region Sales");
            sales.AddChild("Regional Sales");

            // Display the tree
            string text = "";
            IEnumerator<TreeNode> enumerator = manager.GetEnumerator();

            while (enumerator.MoveNext())
            {
                text += new string(' ', 4 * enumerator.Current.Depth) +
                    enumerator.Current.Text + Environment.NewLine;

                text = text.Substring(0, text.Length - Environment.NewLine.Length);

                treeTextBox.Text = text;
                treeTextBox.Select(0, 0);
            }

           
        }
    }
}
