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

namespace Uppgift_4_8
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

        PostNord postnord = new PostNord();
        Mail SelectedMail;

        //Uppgift 5-6
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "" || txtStreet.Text == "" || txtPostalCode.Text == "" || txtCity.Text == "")
            {
                MessageBox.Show("Du måste fylla i samtliga fält som är obligatoriska*.");
            }
            else
            {
                Mail m = new Mail()
                {
                    Name = txtName.Text,
                    StreetAddress = txtStreet.Text,
                    PostalCode = int.Parse(txtPostalCode.Text),
                    Locality = txtCity.Text,
                    County = txtCounty.Text,
                };

                postnord.Letters.Add(m);

                lstLetters.Items.Refresh();
                lstLetters.ItemsSource = postnord.Letters;
            }
        }

        //Uppgift 7 (testsyfte)
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            List<string> locationsInOstersund = new List<string>() { "Berge", "Bjärme", "Bodal", "Bringåsen", "Brunflo", "Bye", "Böle", "Digernäs", "Erikslund", "Fannbyn", "Fillsta", "Fjäl", "Fåker", "Genvalla", "Gilleråsen", "Gusta", "Gärde", "Handog", "Hara", "Hegled", "Hornsberg", "Husås", "Häggenås", "Härke", "Klocksåsen", "Kläppe", "Klösta", "Knytta", "Lit", "Loke", "Lunne", "Marieby", "Munkflohögen", "målsta", "Norderåsen", "Nyvik", "Näs", "Ope", "Optand", "Orrviken", "Ringsta", "Rossbol", "Sandviken", "Singsjön", "Sjör", "Skickja", "Skute", "Slandrom", "Solberg", "Tandsbyn", "Torvalla by", "Valla", "Åkre", "Ångsta", "Ängsmon", "Östersund", "Österåsen" };

            lstLetters2.Items.Refresh();
            lstLetters2.ItemsSource = postnord.SortLettersToOstersund(locationsInOstersund);
        }

        //Uppgift 8a (testsyfte)
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DateTime arrived = DateTime.Parse(txtArrived.Text);
            DateTime delivered = DateTime.Parse(txtDelivered.Text);

            SelectedMail = (Mail)lstLetters.SelectedItem;

            SelectedMail.Arrived = arrived;
            SelectedMail.Delivered = delivered;

            lstLetters.Items.Refresh();
            lstLetters.ItemsSource = postnord.Letters;
        }

        //Uppgift 8b (testsyfte)
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(postnord.ShowWinners());
        }
    }
}
