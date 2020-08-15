using System;
using System.Collections.Generic;
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
        public DashboardWindow()
        {
            InitializeComponent();
        }

        private void BtnBooks_Click(object sender, RoutedEventArgs e)
        {
            BookWindow bw = new BookWindow();
            bw.Show();
            this.Close();
        }

        private void BtnCustomers_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow cw = new CustomerWindow();
            cw.Show();
            this.Close();
        }

        private void BtnManagement_Click(object sender, RoutedEventArgs e)
        {
            ManagementWindow mw = new ManagementWindow();
            mw.Show();
            this.Close();
        }

        private void BtnReturns_Click(object sender, RoutedEventArgs e)
        {
            ReturnBooksWindow rbw = new ReturnBooksWindow();
            rbw.Show();
            this.Close();
        }

        private void BtnNewOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderdWindow ow = new OrderdWindow();
            ow.Show();
            this.Close();
        }

        private void BtnDailyReports_Click(object sender, RoutedEventArgs e)
        {
            ReportsWindow rw = new ReportsWindow();
            rw.Show();
            this.Close();
        }

        private void BtnDailyTracking_Click(object sender, RoutedEventArgs e)
        {
            TrackOrdersWindow tow = new TrackOrdersWindow();
            tow.Show();
            this.Close();
        }

        private void BtnLogOut_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            lw.Show();
            this.Close();
        }
    }
}
