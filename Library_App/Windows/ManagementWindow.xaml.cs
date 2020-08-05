using Library_App.Data;
using Library_App.Models;
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
    public partial class ManagementWindow : Window
    {
        private readonly LibraryContext _context;
        
        public ManagementWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Double Number;
            if (Double.TryParse(TxtName.Text, out Number) && Double.TryParse(TxtSurname.Text, out Number))
            {
                MessageBox.Show("Ad ve Soyad reqem ola bilmez");
                return;
            }

            if (string.IsNullOrEmpty(TxtName.Text) && string.IsNullOrEmpty(TxtSurname.Text)
    && string.IsNullOrEmpty(TxtUsername.Text) && string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("bos ola bilmez");
                return;
            }
            Management management = new Management
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                UserName = TxtUsername.Text,
                Parol = TxtPassword.Text,
                Position = (Positions)CbxPosition.SelectedItem
            };
            _context.Managements.Add(management);
            _context.SaveChanges();
            MessageBox.Show($"{TxtUsername.Text} adli istifadəçi {(Positions)CbxPosition.SelectedItem} əlavə edildi");
            Reset();
        }

        private void Reset()
        {
            TxtName.Clear();
            TxtSurname.Clear();
            TxtUsername.Clear();
            TxtPassword.Clear();
            CbxPosition.SelectedItem = null;
        }
    }
}
