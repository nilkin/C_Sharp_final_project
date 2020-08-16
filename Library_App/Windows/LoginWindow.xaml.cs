using Library_App.Data;
using Library_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows;


namespace Library_App.Windows
{

    public partial class LoginWindow : Window
    {
        private readonly LibraryContext _context;

        public LoginWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            
        }
        // CHEKING USER PAROL, PASSWORD  AND sTATUS OFF USERS
        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (_context.Managements.Any(r => r.UserName == TxtLogin.Text && r.Parol == TxtPassword.Password && r.Position == Positions.Admin))
              
            {
                DashboardWindow dw = new DashboardWindow();
                dw.BtnDailyReports.IsEnabled = true;
                dw.BtnManagement.IsEnabled = true;
                dw.Show();
                this.Close();
              
            }
            else if (_context.Managements.Any(r => r.UserName == TxtLogin.Text && r.Parol == TxtPassword.Password && r.Position == Positions.User))
            {
                DashboardWindow dw = new DashboardWindow();
                dw.BtnDailyReports.IsEnabled = false;
                dw.BtnManagement.IsEnabled = false;
                dw.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır");
            }


        }
    }
}
