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
using System.Runtime.InteropServices;

namespace WpfApp1
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

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        static extern uint GetShortPathName(string lpszLongPath, char[] lpszShortPath, int cchBuffer);

        private void shortNameButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the long file name
            string longName = fileTextBox.Text;

            // Allocate a buffer to hold the result
            char[] buffer = new char[1024];
            long length = GetShortPathName(longName, buffer, buffer.Length);

            // Get the short name
            string shortName = new string(buffer);
            shortNameTextBox.Text = shortName.Substring(0, (int)length);
             
        }
    }
}
