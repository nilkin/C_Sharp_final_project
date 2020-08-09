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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly LibraryContext _context;
        private Management _management;
        public LoginWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            _management = new Management();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (_context.Managements.Any(r => r.UserName == TxtLogin.Text)
                && _context.Managements.Any(r => r.Parol == TxtPassword.Text))
            {
                DashboardWindow dw = new DashboardWindow();
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
