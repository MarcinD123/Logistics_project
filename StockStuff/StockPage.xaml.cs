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

namespace WPF_App.StockStuff
{
    /// <summary>
    /// Interaction logic for StockPage.xaml
    /// </summary>
    public partial class StockPage : Page
    {
        public StockPage()
        {
            InitializeComponent();


        }

        private void stockUpdate_Click(object sender, RoutedEventArgs e)
        {
            stockFrame.Content = new StockManipulation();

        }

        private void everyshopstock_Click(object sender, RoutedEventArgs e)
        {
            stockFrame.Content = new StockDataPage();
        }
        // public Microsoft.EntityFrameworkCore.DbSet<Stock>  dupa {get;set;}




    }
}
