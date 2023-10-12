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

namespace Lab2._1
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

        private async void SlowWork(object sender, RoutedEventArgs e)
        {
            btn.IsEnabled = false;

            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                rtb.AppendText(rnd.Next(100).ToString() + "\t");
                await Task.Delay(150);
            }

            btn.IsEnabled = true;
        }
    }
}
