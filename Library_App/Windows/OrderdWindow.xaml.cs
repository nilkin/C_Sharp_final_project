using Library_App.Data;
using Library_App.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace Library_App.Windows
{
    public partial class OrderdWindow : Window
    {
        private readonly LibraryContext _context;
        private Order _selectedOrder;
        private Customer _customer;
        private Order _order;
        private BookOrder _bookorder;
        int CustId;
        int BkId;
        double _bookprice;
        public OrderdWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            _customer = new Customer();
            _order = new Order();
            _bookorder = new BookOrder();
            _selectedOrder = new Order();
        }
        private void DgOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BtnDelete.Visibility = Visibility;
            if (DgOrder.SelectedItem == null) return;

        }
        private void BtnSearchCustomer_Click(object sender, RoutedEventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(TxtCustomerId.Text))
            {
                MessageBox.Show("Sifarişçi İd-si daxil edilməmişdir !  " +
                    "Lütfən İd-ni daxil edin");
                return;
            }

            if (_context.Customers.Any(r => r.IdCard == TxtCustomerId.Text))
            {
         var anonymousObjResult = from c in _context.Customers
                                             where c.IdCard == TxtCustomerId.Text
                                             select new
                                             {
                                                 c.Name,
                                                 c.Surname,
                                                 c.Id
                                             };
                foreach (var obj in anonymousObjResult)
                    {
                    LblResultCustomerName.Content = $"{obj.Name + " " + obj.Surname }";
                    TxtCustomerId.Clear();                    
                    CustId = obj.Id;
                }
                return;                
            }
            else
            {
                MessageBox.Show($"daxil etdiyiniz {TxtCustomerId.Text} seriya nömrəsli müştəri bazada mövcud deyil");
            }
        }
        private void BtnSearchBook_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBookName.Text))
            {
                MessageBox.Show("Kitabın adı daxil edilməmişdir !   " +
                    "Lütfən Kitab adını daxil edin");
                return;
            }

            if (_context.Books.Any(r => r.BookName == TxtBookName.Text))
            {
                var ObjResult = from b in _context.Books where b.BookName == TxtBookName.Text  
                                         select new { 
                                             b.BookName,
                                             b.Id,
                                             b.Price      
                                         };
                foreach (var obj in ObjResult)
                {
                    LblResultBookName.Content = $"{obj.BookName}";
                    TxtBookName.Clear();
                   BkId = obj.Id;
                    _bookprice = obj.Price;
                }
                myUpDownControl.IsReadOnly = false;
            }
            else
            {
                MessageBox.Show($"daxil etdiyiniz {TxtBookName.Text } kitab bazada mövcud deyil");
            }
        }
        private void BtnAddOrder_Click(object sender, RoutedEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(LblResultCustomerName.Content.ToString()) || string.IsNullOrWhiteSpace(LblResultBookName.Content.ToString()))
            {
                MessageBox.Show("Sifarişçi və ya Kitab seçilməmişdir !");
                return;
            }
            if (string.IsNullOrWhiteSpace(DtpCreatedAt.Text) || string.IsNullOrWhiteSpace(DtpDeadline.Text))
            {
                MessageBox.Show("Tarix seçilməmişdir !");
                return;
            }
            if (myUpDownControl.Value == 0)
            {
                MessageBox.Show("Lütfən məbləğ seçin !");
                return;
            }
            _order = new Order
            {
                CreatedAt = (DateTime)DtpCreatedAt.SelectedDate,
                DeadLine = (DateTime)DtpDeadline.SelectedDate,
                CustomerId = CustId,
                Quantity = (int)myUpDownControl.Value,
                TotalPrice = _bookprice * (double)myUpDownControl.Value
            };

            _context.Orders.Add(_order);
            _context.SaveChanges();

            _bookorder = new BookOrder
            {
                BookId = BkId,
                OrderId = _order.Id
            };
            _context.BookOrders.Add(_bookorder);
            _context.SaveChanges();

            MessageBox.Show("Sifarişiniz daxil edildi");
            FillOrder();
            Reset();
        }
        private void myUpDownControl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (LblTotalprice != null)
            {
                LblTotalprice.Content = _bookprice*myUpDownControl.Value;
            }
            
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (DgOrder.SelectedItem == null) return;
            //Bu hissede order daxilinde olan kitabin id sini elde etmekcun currentItem stringe cevirib 
            // = ve } isarelerine gore stringlere bolub id nomresini goturdum
            //sebeb datagridin type orderin typina uygun gelmirdi

            string[] SearchId = DgOrder.SelectedItem.ToString().Split('=', '}');
            int IdNumber = Convert.ToInt32(SearchId[SearchId.Length - 2]);

            MessageBoxResult r = MessageBox.Show("Silməyə əminsiniz?", IdNumber.ToString(), MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                var CustOrder = _context.Orders.Find(IdNumber);
                _context.Orders.Remove(CustOrder);

                _context.SaveChanges();
            }
            FillOrder();
            Reset();
        }
        private void FillOrder()
        {
            var order = from ef in _context.BookOrders
                        join p in _context.Books
                        on ef.BookId equals p.Id
                        join s in _context.Orders
                        on ef.OrderId equals s.Id
                        join t in _context.Customers
                        on s.CustomerId equals t.Id
                        where t.Id == CustId
                        select new
                        {
                            p.BookName,
                            s.Quantity,
                            s.CreatedAt,
                            s.DeadLine,
                            s.TotalPrice,
                            s.Id
                        };

            DgOrder.ItemsSource = order.ToList();
        }
        private void Reset()
        {
            LblResultCustomerName.Content = null;
            LblResultBookName.Content = null;
            DtpCreatedAt.SelectedDate = null;
            DtpDeadline.SelectedDate = null;
            myUpDownControl.Value = 0;
            BtnDelete.Visibility = Visibility.Hidden;
            myUpDownControl.IsReadOnly = true;
        }

    }
}
