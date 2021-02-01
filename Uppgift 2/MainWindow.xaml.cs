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

namespace Uppgift_2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int weight = int.Parse(txtWeight.Text);
            int costPerStamp = 11;
            int price = 0;

            if (weight <= 50)
            {
                price = 1 * costPerStamp;
            }
            else if (weight <= 100)
            {
                price = 2 * costPerStamp;
            }
            else if (weight <= 250)
            {
                price = 4 * costPerStamp;
            }
            else if (weight <= 500)
            {
                price = 6 * costPerStamp;
            }
            else if (weight <= 1000)
            {
                price = 8 * costPerStamp;
            }
            else if (weight <= 2000)
            {
                price = 10 * costPerStamp;
            }
            else
            {
                MessageBox.Show("Försändelsen väger för mycket och måste skickas som paket.");
            }

            lblInfo.Content = $"Brevet väger {weight} gram, kostar {price} kr och måste skickas med {price / 11} st frimärken.";
        }
    }
}
