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
            if (string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtPrice.Text)
             || string.IsNullOrWhiteSpace(TxtPages.Text) || string.IsNullOrWhiteSpace(TxtQuantity.Text))
            {
                MessageBox.Show("xanalar boş qala bilmez");
                return;
            }
            if (CbxLanguage.SelectedIndex == -1)
            {
                MessageBox.Show($"Dil doğru seçilməmişdir");
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
            TxtPrice.Text = _selectedBook.Price;
            TxtPages.Text= _selectedBook.Pages;
            TxtQuantity.Text = _selectedBook.Quantity;
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
            _selectedBook.Price = TxtPrice.Text;
            _selectedBook.Pages = TxtPages.Text;
            _selectedBook.Quantity = TxtQuantity.Text;
            _selectedBook.language = (language)Cbxlanguage.SelectedItem;
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Kitab haqqında dəyişikliklər yeniləndi");
            FillManagements();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
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
