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

namespace Uppgift_3
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

        private bool IsBulky(int height, int width)
        {
            if ((height + 2 * width) > 200)
            {
                return true;
            }
            else
                return false;
        }

        private double PriceCalculator(double weight)
        {
            double price = 0;

            if (weight <= 3)
            {
                price = 140;
            }
            else if (weight <= 5)
            {
                price = 167;
            }
            else if (weight <= 10)
            {
                price = 212;
            }
            else if (weight <= 15)
            {
                price = 258;
            }
            else if (weight <= 20)
            {
                price = 298;
            }
            return price;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double weight = double.Parse(txtWeight.Text);
            int height = int.Parse(txtHeight.Text);
            int width = int.Parse(txtWidth.Text);
            double price = PriceCalculator(weight);

            if (IsBulky(height, width))
            {
                price *= 1.45;
            }

            MessageBox.Show($"Paketet väger {weight} kg och kostar {price} kr.");
        }
    }
}
