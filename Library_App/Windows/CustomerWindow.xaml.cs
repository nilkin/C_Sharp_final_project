using Library_App.Data;
using Library_App.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Library_App.Windows
{
    public partial class CustomerWindow :  Window 
    {
        private readonly LibraryContext _context;
        private Customer _customer;
        private Customer _selectedCustomer;
        
        public CustomerWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            _customer = new Customer();
            
        }
        //add to Datbase
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Double Number;
            if (Double.TryParse(TxtName.Text, out Number) && Double.TryParse(TxtSurname.Text, out Number))
            {
                MessageBox.Show("Ad ve Soyad rəqəmlərdən ibarət ola bilmez");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtSurname.Text)
            || string.IsNullOrWhiteSpace(TxtPhone.Text) || string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtIdCard.Text))
            {
                MessageBox.Show("xanalar boş qala bilmez");
                return;
            }
            if ((_context.Customers.Any(r => r.Email == TxtEmail.Text)) || (_context.Customers.Any(r => r.IdCard == TxtIdCard.Text)))
            {
                MessageBox.Show($"Bu Username mövcüddür");
                return;
            }
            string[] words = TxtPhone.Text.Split('+', ' ');
            string PhoneStr = string.Join("", words);
            if (!Double.TryParse(PhoneStr, out Number))
            {
                MessageBox.Show("Telefon nömrəsi yalnız rəqəm ola bilər");
                return;
            }
            _customer = new Customer
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                Phone = "+"+ PhoneStr,
                Email = TxtEmail.Text,
                IdCard = TxtIdCard.Text
            };
            _context.Customers.Add(_customer);
            _context.SaveChanges();
            MessageBox.Show($"{ TxtName.Text} adli müştəri əlavə edildi");
            Reset(); 
            FillCustomers();

        }
        //select from DataGrid
        private void DgPerson_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgPerson.SelectedItem == null) return;

            _selectedCustomer = (Customer)DgPerson.SelectedItem;

            TxtName.Text = _selectedCustomer.Name;
            TxtSurname.Text = _selectedCustomer.Surname;
            TxtPhone.Text = _selectedCustomer.Phone;
            TxtEmail.Text = _selectedCustomer.Email;
            TxtIdCard.Text = _selectedCustomer.IdCard;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
        }
        //delete from DataBase
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Silməyə əminsiniz?", _selectedCustomer.ToString(), MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _context.Customers.Remove(_selectedCustomer);
                _context.SaveChanges();
                Reset();
                MessageBox.Show($"{_selectedCustomer.Name}adlı istifadəçi silindi");
                FillCustomers();
            }
        }
        //update from DataGrid add to DB
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Double Number;
            string[] words = TxtPhone.Text.Split('+', ' ');
            string PhoneStr = string.Join("", words);
            if (!Double.TryParse(PhoneStr, out Number))
            {
                MessageBox.Show("Telefon nömrəsi yalnız rəqəmlərdən ibarət ola bilər");
                return;
            }
            _selectedCustomer.Name = TxtName.Text;
            _selectedCustomer.Surname = TxtSurname.Text;
            _selectedCustomer.Phone = "+" + PhoneStr;
            _selectedCustomer.Email = TxtEmail.Text;
            _selectedCustomer.IdCard = TxtIdCard.Text;
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Müştəri məlumatları yeniləndi");
            FillCustomers();
        }
        //read from DataBase
        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {
            FillCustomers();
            Reset();
        }
        //back to main dashboard window
        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindow dw = new DashboardWindow();
            dw.Show();
            this.Close();
        }
        //filling data method
        private void FillCustomers()
        {
            DgPerson.ItemsSource = _context.Customers.ToList();

        }
        //reset method
        private void Reset()
        {
            TxtName.Clear();
            TxtSurname.Clear();
            TxtPhone.Clear();
            TxtEmail.Clear();
            TxtIdCard.Clear();
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;
            BtnRead.Visibility = Visibility.Hidden;
        }




    }
}
