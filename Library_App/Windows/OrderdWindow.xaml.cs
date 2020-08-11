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

    }
    private void DgOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void BtnSearchCustomer_Click(object sender, RoutedEventArgs e)
        {
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
                    TxtCustomerId.Text = $"{obj.Name + " " + obj.Surname }";                   
                    CustId = obj.Id;
                }
                return;                
            }
            else
            {
                MessageBox.Show($"daxil etdiyiniz {TxtCustomerId.Text} seriya bazada mövcud deyil");
            }
        }
        private void BtnSearchBook_Click(object sender, RoutedEventArgs e)
        {
            if (_context.Books.Any(r => r.Name == TxtBookName.Text))
            {
                var ObjResult = from b in _context.Books where b.Name == TxtBookName.Text  
                                         select new { 
                                             b.Name,
                                             b.Id,
                                             b.Price      
                                         };
                foreach (var obj in ObjResult)
                {
                    TxtBookName.Text = $"{obj.Name}";
                    BkId = obj.Id;
                    _bookprice = obj.Price;
                }
                return;
            }
            else
            {
                MessageBox.Show($"daxil etdiyiniz {TxtBookName.Text } kitab bazada mövcud deyil");
            }
        }
        private void BtnAddOrder_Click(object sender, RoutedEventArgs e)
        {
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

            var order = (from ef in _context.BookOrders
                          join p in _context.Books
                          on ef.BookId equals p.Id
                          join s in _context.Orders
                          on ef.OrderId equals s.Id
                          join t in _context.Customers
                          on s.CustomerId equals t.Id
                          where t.Id == CustId
                          select new
                          {
                             p.Name,
                             s.Quantity,
                             s.CreatedAt,
                             s.DeadLine,
                             s.TotalPrice                            
                          });

            DgOrder.ItemsSource = order.ToList();
            //TxtTotalprice.Content = 
        }



        //private void myUpDownControl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        //{
        //    ContentControl content = new ContentControl();
        //    content = (ContentControl)(_bookprice * myUpDownControl.Value);

        //    TxtTotalprice.Content = content;
        //}
    }
}
