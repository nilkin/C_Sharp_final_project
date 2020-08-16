using Library_App.Data;
using Library_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library_App.Windows
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        private readonly LibraryContext _context;
        private Management _management;
        public DashboardWindow()
        {
            InitializeComponent();
            _management = new Management();
            _context = new LibraryContext();

        }
        //Book add
        private void BtnBooks_Click(object sender, RoutedEventArgs e)
        {
            BookWindow bw = new BookWindow();
            bw.Show();
            this.Close();
        }
        //Customers add
        private void BtnCustomers_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow cw = new CustomerWindow();
            cw.Show();
            this.Close();
        }
        //Management add
        private void BtnManagement_Click(object sender, RoutedEventArgs e)
        {
            if (_context.Managements.Any(r => r.Position==0 ))
            {
                ManagementWindow mw = new ManagementWindow();
                mw.Show();
                this.Close();
            }
            else
            {
              
            }

        }
        // Returns show order details
        private void BtnReturns_Click(object sender, RoutedEventArgs e)
        {
            ReturnBooksWindow rbw = new ReturnBooksWindow();
            rbw.Show();
            this.Close();
        }
        //Creating new Orders
        private void BtnNewOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderdWindow ow = new OrderdWindow();
            ow.Show();
            this.Close();
        }
        //Cheking Reports
        private void BtnDailyReports_Click(object sender, RoutedEventArgs e)
        {
            ReportsWindow rw = new ReportsWindow();
            rw.Show();
            this.Close();
        }
        //Cheking daily Tracking books
        private void BtnDailyTracking_Click(object sender, RoutedEventArgs e)
        {
            TrackOrdersWindow tow = new TrackOrdersWindow();
            tow.Show();
            this.Close();
        }
        //EXIT
        private void BtnLogOut_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            lw.Show();
            this.Close();
        }
    }
}
