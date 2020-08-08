using Library_App.Data;
using Library_App.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace Library_App.Windows
{
    public partial class BookWindow : Window
    {
        private readonly LibraryContext _context;
        private Book _book;
        private Book _selectedBook;
        public BookWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            _book = new Book();
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtPrice.Text)
            || string.IsNullOrWhiteSpace(TxtPages.Text) || string.IsNullOrWhiteSpace(TxtQuantity.Text))
            {
                MessageBox.Show("xanalar boş qala bilmez");
                return;
            }
            Double Number;
            if (!Double.TryParse(TxtPrice.Text, out Number)
                || !Double.TryParse(TxtPages.Text, out Number)
                || !Double.TryParse(TxtQuantity.Text, out Number))
            {
                LblPrice.Foreground = new SolidColorBrush(Colors.Red);
               LblQuantity.Foreground = new SolidColorBrush(Colors.Red);
                LblPages.Foreground = new SolidColorBrush(Colors.Red);
                MessageBox.Show("Lütfən doğru emsalı daxil edin");
                return;
            }
            else
            {
                LblPrice.Foreground = new SolidColorBrush(Colors.Black);
                LblQuantity.Foreground = new SolidColorBrush(Colors.Black);
                LblPages.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (CbxLanguage.SelectedIndex == -1)
            {
                MessageBox.Show("Dil seçilməmişdir");
                return;
            }
            if (_context.Managements.Any(r => r.UserName == TxtName.Text))
            {
                MessageBox.Show($"{TxtName.Text} adlı kitab mövcüddür");
                return;
            }
            _book = new Book
            {
                Name = TxtName.Text,
                Price = Convert.ToDouble(TxtPrice.Text),
                Pages = Convert.ToInt32(TxtPages.Text),
                Quantity= Convert.ToInt32(TxtQuantity.Text),
                Language = (language)CbxLanguage.SelectedItem
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
            MessageBox.Show($"{TxtName.Text} adli kitab əlavə edildi");
            Reset();
            FillManagements();
        }
        private void DgPerson_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgPerson.SelectedItem == null) return;

            _selectedBook = (Book)DgPerson.SelectedItem;

            TxtName.Text = _selectedBook.Name;
            TxtPrice.Text = _selectedBook.Price.ToString();
            TxtPages.Text= _selectedBook.Pages.ToString();
            TxtQuantity.Text = _selectedBook.Quantity.ToString();
            CbxLanguage.SelectedItem = _selectedBook.Language;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
        }
        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {
            FillManagements();
            Reset();
        }
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            _selectedBook.Name = TxtName.Text;
            _selectedBook.Price = Convert.ToDouble(TxtPrice.Text);
            _selectedBook.Pages = Convert.ToInt32(TxtPages.Text);
            _selectedBook.Quantity = Convert.ToInt32(TxtQuantity.Text);
            _selectedBook.Language = (language)CbxLanguage.SelectedItem;
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Kitab haqqında dəyişikliklər yeniləndi");
            FillManagements();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Silməyə əminsiniz?", _selectedBook.ToString(), MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _context.Books.Remove(_selectedBook);
                _context.SaveChanges();
                Reset();
                MessageBox.Show($"{_selectedBook.Name } adlı kitab silindi") ;
                FillManagements();
            }
        }

        private void Reset()
        {
            TxtName.Clear();
            TxtPages.Clear();
            TxtPrice.Clear();
            TxtQuantity.Clear();
            CbxLanguage.SelectedItem = null;
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;
            BtnRead.Visibility = Visibility.Hidden;
        }
        private void FillManagements()
        {
            DgPerson.ItemsSource = _context.Books.ToList();
        }
    }
}
