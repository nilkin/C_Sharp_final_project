﻿using Library_App.Data;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;


namespace Library_App.Windows
{
    /// <summary>
    /// Interaction logic for TrackOrdersWindow.xaml
    /// </summary>
    public partial class TrackOrdersWindow : Window
    {
        private readonly LibraryContext _context;
        public TrackOrdersWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
        }
        //DAILY TRACING TODAY TAB
        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in _context.Customers
                        join o in _context.Orders
                        on c.Id equals o.CustomerId
                        where o.DeadLine.Date == DateTime.Now.Date
                        where o.PaymentStatus == false
                        group o by new
                        {
                            c.Name, 
                            c.Surname,
                            c.Phone,
                            c.Email 
                        }
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
        //back to main dashboard window
        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindow dbw = new DashboardWindow();
            dbw.Show();
            this.Close();
        }
        //DAILY TRACING TOMORROW TAB
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
        //NON PAYED RECEIVABELS TAB
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
