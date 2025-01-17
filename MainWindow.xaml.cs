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
using WPF_App.Orderstuff;
using Microsoft.EntityFrameworkCore;
using WPF_App.StockStuff;
namespace WPF_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// https://codverter.com/src/sqltoclass
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //string connectionString = @"Data Source=DESKTOP-CPTE25K\SQLEXPRESS;Initial Catalog=WpfAppDb;Integrated Security=True";
            
            using (Connection db = new Connection(Connection.connectionString))
            {
                //try
                //{
                
                //}
                //catch (Exception)
                //{

                //    MessageBox.Show("curstock");
                //}//var x = db.Add
                
            }
        }
        /// <summary>
        /// By clicking these buttons proper page will be displayed in MainFrame 
        /// </summary>
        
        private void productsWindowClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ProductPage();
        }

        private void OrdersWindow_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new OrderPage();
        }

        private void StockWindow_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new StockPage();
        }
    }
}
