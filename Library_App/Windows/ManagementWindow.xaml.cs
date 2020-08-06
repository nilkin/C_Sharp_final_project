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
    public partial class ManagementWindow : Window
    {
        private readonly LibraryContext _context;
        private Management _management;
        private Management _selectedManagement;
        public ManagementWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            _management = new Management();
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
    && string.IsNullOrEmpty(TxtUsername.Text) && string.IsNullOrEmpty(TxtPassword.Text)&& string.IsNullOrEmpty((string)CbxPosition.SelectedItem))
            {
                MessageBox.Show("bos ola bilmez");
                return;
            }
            //if ()
            //{

            //}
            _management = new Management
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                UserName = TxtUsername.Text,
                Parol = TxtPassword.Text,
                Position = (Positions)CbxPosition.SelectedItem
            };
            _context.Managements.Add(_management);

            _context.SaveChanges();
            MessageBox.Show($"{TxtUsername.Text} adli istifadəçi {(Positions)CbxPosition.SelectedItem} statusu ilə əlavə edildi");
            Reset();
            FillManagements();
        }

        private void FillManagements()
        {
            DgPerson.ItemsSource = _context.Managements.ToList();
        }
        private void DgPerson_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgPerson.SelectedItem == null) return;

            _selectedManagement = (Management)DgPerson.SelectedItem;

            TxtName.Text = _selectedManagement.Name;
            TxtSurname.Text = _selectedManagement.Surname;
            TxtUsername.Text= _selectedManagement.UserName;
            TxtPassword.Text = _selectedManagement.Parol;
            CbxPosition.SelectedItem = _selectedManagement.Position;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            _selectedManagement.Name = TxtName.Text;
            _selectedManagement.Surname = TxtSurname.Text;
            _selectedManagement.UserName = TxtUsername.Text;
            _selectedManagement.Parol = TxtPassword.Text;
            _selectedManagement.Position = (Positions)CbxPosition.SelectedItem;

            _context.SaveChanges();
            Reset();
            MessageBox.Show("İdarəçi dəyişiklikləri yeniləndi");
            FillManagements();
        }

        private void Reset()
        {
            TxtName.Clear();
            TxtSurname.Clear();
            TxtUsername.Clear();
            TxtPassword.Clear();
            CbxPosition.SelectedItem = null;
        }

        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {
            FillManagements();
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Silməyə əminsiniz?", _selectedManagement.ToString(), MessageBoxButton.OKCancel);

            if (r == MessageBoxResult.OK)
            {
                _context.Managements.Remove(_selectedManagement);
                _context.SaveChanges();

                Reset();

                MessageBox.Show($"{_selectedManagement.UserName } adlı İdarəçi silindi") ;
                FillManagements();
            }
        }
    }
}
