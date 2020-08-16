using Library_App.Data;
using Library_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Library_App.Windows
{
    public partial class ReturnBooksWindow : Window
    {
        
        private readonly LibraryContext _context;
        private Order _order;
        
        public ReturnBooksWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            _order = new Order();
        }
        //Search BOOK FROM datagrid pay fine and total price 
        //change status to payed and update information about order
        private void DgReturnBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (DgReturnBooks.SelectedItem == null) return;
            string[] str = DgReturnBooks.SelectedItem.ToString().Split(',', '}', '{');
            string[] StrId = str[str.Length - 2].Split('=');
            int NumberId = Convert.ToInt32(StrId[StrId.Length - 1]);
            _order = _context.Orders.Find(NumberId);
            int diffDate = _order.DeadLine.Date.Subtract(_order.CreatedAt).Days;
            if (diffDate > 7)
            {
                TxtFine.Text = (_order.TotalPrice /100* 0.5 * diffDate).ToString("####0.00");
                TxtTotalPay.Text = ((_order.TotalPrice / 100 * 0.5 * diffDate) + _order.TotalPrice).ToString("####0.00");              
            }
            else
            {
                TxtFine.Text = _order.Fine.ToString("####0.00");
                TxtTotalPay.Text = _order.TotalPrice.ToString("####0.00");
            }

            BtnPay.Visibility = Visibility.Visible;
        }
       //Search CUSTOMER BY FILL METHOD
        private void BtnSearchCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCustomerId.Text))
            {
                MessageBox.Show("Axtarış xanası boş ola bilməz !  " +
                    "Lütfən şəxsiyyətin seriya nömrəsini daxil edin");
                return;
            }
            
            Fill();
            Reset();
        }
        //back to main dashboard window
        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindow dw = new DashboardWindow();
            dw.Show();
            this.Close();
        }
      // ORDER PAY 
        private void BtnPay_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show($"{TxtTotalPay.Text} ", "Məbləği Təsdiqləyin", MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _order.Fine = Convert.ToDouble(TxtFine.Text);
                _order.PaymentStatus = true;
                _order.TotalPrice = Convert.ToDouble(TxtTotalPay.Text);
                _context.SaveChanges();

            }
            Fill();
            Reset();
        }
        //filling data method
        private void Fill()
        {
            var order = from ef in _context.BookOrders
                        join p in _context.Books
                        on ef.BookId equals p.Id
                        join s in _context.Orders
                        on ef.OrderId equals s.Id
                        join t in _context.Customers
                        on s.CustomerId equals t.Id
                        where t.IdCard == TxtCustomerId.Text
                        where s.PaymentStatus == false
                        select new
                        {
                            p.BookName,
                            s.Quantity,
                            s.CreatedAt,
                            s.DeadLine,
                            s.TotalPrice,
                            s.PaymentStatus,
                            s.Fine,
                            t.Surname,
                            t.Phone,
                            t.Name,
                            t.Email,
                            s.Id

                        };
           
            DgReturnBooks.ItemsSource = order.ToList();

            
        }
        //reset method
        private void Reset()
        {
            TxtFine.Text = "0,00";
            TxtTotalPay.Text = "0,00";
        }


    }
}  
