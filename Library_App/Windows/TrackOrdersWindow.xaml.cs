using Library_App.Data;
using Library_App.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using Syncfusion.Windows.Shared;

namespace Library_App.Windows
{
    /// <summary>
    /// Interaction logic for TrackOrdersWindow.xaml
    /// </summary>
    public partial class TrackOrdersWindow : Window
    {
        private readonly LibraryContext _context;
        private Order _order;
        public TrackOrdersWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            _order = new Order();
        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            var order = from ef in _context.Orders
                        join t in _context.Customers
                        on ef.CustomerId equals t.Id
                        where ef.DeadLine.Date == DateTime.Now.Date
                        where ef.PaymentStatus == false
                        select new
                        {
                            t.Name,
                            t.Surname,
                            t.Phone,
                            t.Email,
                            ef.Quantity,
                            ef.DeadLine
                        };
            DgtPast.ItemsSource = order.ToList();

        }

        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindow dbw = new DashboardWindow();
            dbw.Show();
            this.Close();
        }

        private void BtnShow2_Click(object sender, RoutedEventArgs e)
        {
            var order = from ef in _context.Orders
                        join t in _context.Customers
                        on ef.CustomerId equals t.Id
                        where ef.DeadLine.Date >= DateTime.Now.Date
                        where ef.PaymentStatus == false
                        select new
                        {
                            t.Name,
                            t.Surname,
                            t.Phone,
                            t.Email,
                            ef.Quantity,
                            ef.DeadLine
                        };
            DgtTomorrow.ItemsSource = order.ToList();
        }
        private void BtnShow3_Click(object sender, RoutedEventArgs e)
        {

            var order = from o in _context.Orders
                        join c in _context.Customers
                        on o.CustomerId equals c.Id
                        group o by o.CustomerId into g

                        select new 
                        {

                            Quantity = g.Sum(x => x.Quantity),

                        };

            DgtNonReturnable.ItemsSource = order.ToList();

            //foreach (var item in order)
            //{
            //    MessageBox.Show(item.Quantity.ToString());
            //};
        }
    } 
}
