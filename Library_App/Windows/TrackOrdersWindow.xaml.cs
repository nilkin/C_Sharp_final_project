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
            var query = from c in _context.Customers
                        join o in _context.Orders
                        on c.Id equals o.CustomerId
                        where o.DeadLine.Date == DateTime.Now.Date
                        where o.PaymentStatus == false
                        group o by new { c.Name, c.Surname, c.Phone, c.Email }
                        into g
                        select new
                        {
                            g.Key.Name,
                            g.Key.Surname,
                            g.Key.Phone,
                            g.Key.Email,
                            Quantity = g.Sum(x => x.Quantity),
                        };
            DgtToDay.ItemsSource = query.ToList();



        }

        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindow dbw = new DashboardWindow();
            dbw.Show();
            this.Close();
        }

        private void BtnShow2_Click(object sender, RoutedEventArgs e)
        {

            var query = from c in _context.Customers
                        join o in _context.Orders
                        on c.Id equals o.CustomerId
                        where o.DeadLine.Date >= DateTime.Now.Date
                        where o.PaymentStatus == false
                        group o by new { c.Name, c.Surname, c.Phone, c.Email }
                        into g
                        select new
                        {
                            g.Key.Name,
                            g.Key.Surname,
                            g.Key.Phone,
                            g.Key.Email,
                            Quantity = g.Sum(x => x.Quantity),

                        };


            DgtTomorrow.ItemsSource = query.ToList();
        }
        private void BtnShow3_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in _context.Customers
                        join o in _context.Orders
                        on c.Id equals o.CustomerId
                        where o.DeadLine.Date <= DateTime.Now.Date
                        where o.PaymentStatus == false
                        group o by new { c.Name, c.Surname, c.Phone, c.Email }
                        into g
                        select new
                        {
                            g.Key.Name,
                            g.Key.Surname,
                            g.Key.Phone,
                            g.Key.Email,
                            Quantity = g.Sum(x => x.Quantity),
                        };
            DgtPast.ItemsSource = query.ToList();

           
        }
    } 
}
