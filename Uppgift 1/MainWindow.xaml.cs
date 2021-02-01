﻿using System;
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

namespace Uppgift_1
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

        private bool IsLetter(double weight)
        {
            if (weight <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double weight = double.Parse(txtWeight.Text);

            if (IsLetter(weight))
            {
                MessageBox.Show($"Föremålet väger {weight} kg och kan skickas som brev.");
            }
            else if (!IsLetter(weight))
            {
                MessageBox.Show($"Föremålet väger {weight} kg och måste skickas som paket.");
            }
        }
    }
}
