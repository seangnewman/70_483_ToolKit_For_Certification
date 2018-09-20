using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap5_ComparingCars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cars[] cars =
            {
                new Cars(){ Name = "SSC Ultimate Aero", MaxMph = 257, HorsePower = 1183, Price = 654400m },
                new Cars(){ Name = "Bugatti Veyron", MaxMph = 253, HorsePower = 1001, Price = 170000m },
            };

            // Display the cars unsorted
            DisplayCars(cars, unsortedListView);

            // Sort the array of cars
            Array.Sort(cars);

            // Display the sorted cars
            DisplayCars(cars, sortedListView);
        }

        private void DisplayCars(Cars[] cars, ListView listView)
        {
            listView.Items.Clear();

            foreach(Cars car in cars)
            {
                ListViewItem item = listView.Items.Add(car.Name);

                item.SubItems.Add(car.MaxMph.ToString());
                item.SubItems.Add(car.HorsePower.ToString());
                item.SubItems.Add(car.Price.ToString("C"));
            }

            foreach(ColumnHeader header in listView.Columns)
            {
                header.Width = -2;
            }
        }
    }
}
