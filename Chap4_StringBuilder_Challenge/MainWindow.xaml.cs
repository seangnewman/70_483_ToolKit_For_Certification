using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chap4_StringBuilder_Challenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder alphabet = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

            StringBuilder line = new StringBuilder();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < alphabet.Length; i++)
            {
                line.Append(alphabet[i]);
                result.AppendLine(line.ToString());

            }

            AlphabetText.Text = result.ToString();
            AlphabetText.Select(0, 0);
        }
    }
}
