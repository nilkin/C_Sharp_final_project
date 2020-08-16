using Library_App.Data;
using Library_App.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
        //add to Datbase
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {// VALIDATION check
            Double Number;
            if (Double.TryParse(TxtName.Text, out Number) || Double.TryParse(TxtSurname.Text, out Number))
            {
                MessageBox.Show("Ad ve Soyad reqem ola bilmez");
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtSurname.Text)
             || string.IsNullOrWhiteSpace(TxtUsername.Text) || string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                MessageBox.Show("xanalar boş qala bilmez");
                return;
            }
            if (CbxPosition.SelectedIndex == -1)
            {
                MessageBox.Show($"Position seçilmemişdir");
                return;
            }
            if (_context.Managements.Any(r => r.UserName == TxtUsername.Text)) 
            {
                MessageBox.Show($"Bu Username mövcüddür");
                return;
            }
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
        //select from DataGrid
        private void DgPerson_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgPerson.SelectedItem == null) return;

            _selectedManagement = (Management)DgPerson.SelectedItem;

            TxtName.Text = _selectedManagement.Name;
            TxtSurname.Text = _selectedManagement.Surname;
            TxtUsername.Text= _selectedManagement.UserName;
            TxtPassword.Text = _selectedManagement.Parol;
            CbxPosition.SelectedItem = _selectedManagement.Position;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
        }
        //update from DataGrid add to DB
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
        //read from DataBase
        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {
            FillManagements();
            Reset();
        }
        //delete from DataBase
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
        //back to main dashboard window
        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindow dw = new DashboardWindow();
            dw.Show();
            this.Close();
        }
        //filling data method
        private void FillManagements()
        {
            DgPerson.ItemsSource = _context.Managements.ToList();
        }
        //reset method
        private void Reset()
        {
            TxtName.Clear();
            TxtSurname.Clear();
            TxtUsername.Clear();
            TxtPassword.Clear();
            CbxPosition.SelectedItem = null;
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;
            BtnRead.Visibility = Visibility.Hidden;
        }
        


    }
}
