using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Chap7_AsyncWPF
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

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
             GetDataAsync();
        }

        private void GetData()
        {
            lblResult.Content = ReadDataFromIO();
            lblResult2.Content = ReadDataFromIO();  
        }

        private async Task GetDataAsync()
        {
            var task1 = ReadDataFromIOAsync();
            var task2 = ReadDataFromIOAsync();

            // Here we can do more processing
            // that doesn't need the data from the previous calls

            //Now we need the data so we have to wait
            await Task.WhenAll(task1, task2);

            //NOw we have data to show
            lblResult.Content = task1.Result;
            lblResult2.Content = task2.Result;
        }
      
        public static Task<double> ReadDataFromIOAsync()
        {
            return Task.Run(new Func<double>(ReadDataFromIO));
        }

        static double ReadDataFromIO()
        {
            // We are simulating an I/O by putting the current thread to sleep
            Thread.Sleep(1000);
            return 1000d;

        }



         
    }
}
