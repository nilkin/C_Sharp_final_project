using ClosedXML.Excel;
using Library_App.Data;
using Microsoft.Win32;
using System.Linq;
using System.Windows;


namespace Library_App.Windows
{

    public partial class ReportsWindow : Window
    {
        private readonly LibraryContext _context;
       
        public ReportsWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            
        }
 //JOIN AND GROUPED TABLES FOR PRESENTING BETWEEN 2 DATES PAYED ORDERS
        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DpStart.ToString()) || string.IsNullOrWhiteSpace(DpEnd.ToString()))
            {
                MessageBox.Show("Tarixlər seçilməmişdir !");
                return;
            }
            var query = from ef in _context.BookOrders
                        join p in _context.Books
                        on ef.BookId equals p.Id
                        join s in _context.Orders
                        on ef.OrderId equals s.Id
                        join t in _context.Customers
                        on s.CustomerId equals t.Id
                        where s.CreatedAt.Date >= DpStart.SelectedDate
                        where s.DeadLine.Date <= DpEnd.SelectedDate
                        where s.PaymentStatus == true
                        group s by new
                        {
                            s.Customer.Name,
                            s.Customer.Surname,
                            s.Customer.Phone,
                            s.Customer.Email,
                            s.CreatedAt,
                            s.DeadLine,
                            s.Fine,
                            s.Quantity,
                            s.TotalPrice,
                            p.BookName
                        }
                                     into g
                        select new
                        {
                            g.Key.Name,
                            g.Key.Surname,
                            g.Key.Phone,
                            g.Key.Email,
                            g.Key.CreatedAt,
                            g.Key.DeadLine,
                            g.Key.Fine,
                            Quantity = g.Sum(x => x.Quantity),
                            g.Key.TotalPrice,
                            g.Key.BookName,


                        };


            DgtReport.ItemsSource = query.ToList();
            Save_As.Visibility = Visibility.Visible;
        }
        //JOIN AND GROUPED TABLES FOR PRESENTING BETWEEN 2 DATES RECEIVABLE ORDERS
        private void BtnShowReceiv_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DpStart.ToString()) || string.IsNullOrWhiteSpace(DpEnd.ToString()))
            {
                MessageBox.Show("Tarixlər seçilməmişdir !");
                return;
            }
            var query = from ef in _context.BookOrders
                        join p in _context.Books
                        on ef.BookId equals p.Id
                        join s in _context.Orders
                        on ef.OrderId equals s.Id
                        join t in _context.Customers
                        on s.CustomerId equals t.Id
                        where s.CreatedAt.Date >= DpStart.SelectedDate
                        where s.DeadLine.Date <= DpEnd.SelectedDate
                        where s.PaymentStatus == false
                        group s by new
                        {
                            s.Customer.Name,
                            s.Customer.Surname,
                            s.Customer.Phone,
                            s.Customer.Email,
                            s.CreatedAt,
                            s.DeadLine,
                            s.Fine,
                            s.Quantity,
                            s.TotalPrice,
                            p.BookName
                        }
                        into g
                        select new
                        {
                            g.Key.Name,
                            g.Key.Surname,
                            g.Key.Phone,
                            g.Key.Email,
                            g.Key.CreatedAt,
                            g.Key.DeadLine,
                            g.Key.Fine,
                            Quantity = g.Sum(x => x.Quantity),
                            g.Key.TotalPrice,
                            g.Key.BookName,
                        };
            DgtReport.ItemsSource = query.ToList();

            BtnSaveAs.Visibility = Visibility.Visible;
        }
        //back to main dashboard window
        private void BtnBackMeny_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindow dw = new DashboardWindow();
            dw.Show();
            this.Close();

        }
      //EXPORT TO XML PAYED ORDERS
        private void Save_As_Click(object sender, RoutedEventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Orders");

                worksheet.Cell("A1").SetValue(DgtName.Header);
                worksheet.Cell("B1").SetValue(DgtSurname.Header);
                worksheet.Cell("C1").SetValue(DgtPhone.Header);
                worksheet.Cell("D1").SetValue(DgtEmail.Header);
                worksheet.Cell("E1").SetValue(DgtBookName.Header);
                worksheet.Cell("F1").SetValue(DgtQuantity.Header);
                worksheet.Cell("G1").SetValue(DgtCreatedAt.Header);
                worksheet.Cell("H1").SetValue(DgtDeadLine.Header);
                worksheet.Cell("I1").SetValue(DgtFine.Header);
                worksheet.Cell("J1").SetValue(DgtTotalPrice.Header);

                worksheet.Cell("A1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("B1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("C1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("D1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("E1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("F1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("G1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("H1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("I1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("J1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));

                worksheet.Cell("A1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("B1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("C1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("D1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("E1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("F1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("G1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("H1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("I1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("J1").Style.Font.SetFontColor(XLColor.White);

                int row = 2;


                var query = from ef in _context.BookOrders
                            join p in _context.Books
                            on ef.BookId equals p.Id
                            join s in _context.Orders
                            on ef.OrderId equals s.Id
                            join t in _context.Customers
                            on s.CustomerId equals t.Id
                            where s.CreatedAt.Date >= DpStart.SelectedDate
                            where s.DeadLine.Date <= DpEnd.SelectedDate
                            where s.PaymentStatus == true
                            group s by new
                            {
                                s.Customer.Name,
                                s.Customer.Surname,
                                s.Customer.Phone,
                                s.Customer.Email,
                                s.CreatedAt,
                                s.DeadLine,
                                s.Fine,
                                s.Quantity,
                                s.TotalPrice,
                                p.BookName
                            }
                                        into g
                            select new
                            {
                                g.Key.Name,
                                g.Key.Surname,
                                g.Key.Phone,
                                g.Key.Email,
                                g.Key.CreatedAt,
                                g.Key.DeadLine,
                                g.Key.Fine,
                                Quantity = g.Sum(x => x.Quantity),
                                g.Key.TotalPrice,
                                g.Key.BookName,
                            };


                DgtReport.ItemsSource = query.ToList();

                foreach (var item in query.ToList())
                {
                    worksheet.Cell("A" + row).Value = item.Name;
                    worksheet.Cell("B" + row).Value = item.Surname;
                    worksheet.Cell("C" + row).Value = item.Phone;
                    worksheet.Cell("D" + row).Value = item.Email;
                    worksheet.Cell("E" + row).Value = item.BookName;
                    worksheet.Cell("F" + row).Value = item.Quantity;
                    worksheet.Cell("G" + row).Value = item.CreatedAt;
                    worksheet.Cell("H" + row).Value = item.DeadLine;
                    worksheet.Cell("I" + row).Value = item.Fine;
                    worksheet.Cell("J" + row).Value = item.TotalPrice;
                    row++;

                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Excel_Table";
                saveFileDialog.Filter = "Text files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "") return;
                string result = saveFileDialog.FileName;
                workbook.SaveAs(@"" + result);
                MessageBox.Show(result);
                Save_As.Visibility = Visibility.Hidden;
            }
        }
      // EXPORT TO XML RECEIVABLE ORDERS
        private void BtnSaveAs_Click(object sender, RoutedEventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Orders");

                worksheet.Cell("A1").SetValue(DgtName.Header);
                worksheet.Cell("B1").SetValue(DgtSurname.Header);
                worksheet.Cell("C1").SetValue(DgtPhone.Header);
                worksheet.Cell("D1").SetValue(DgtEmail.Header);
                worksheet.Cell("E1").SetValue(DgtBookName.Header);
                worksheet.Cell("F1").SetValue(DgtQuantity.Header);
                worksheet.Cell("G1").SetValue(DgtCreatedAt.Header);
                worksheet.Cell("H1").SetValue(DgtDeadLine.Header);
                worksheet.Cell("I1").SetValue(DgtFine.Header);
                worksheet.Cell("J1").SetValue(DgtTotalPrice.Header);

                worksheet.Cell("A1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("B1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("C1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("D1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("E1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("F1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("G1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("H1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("I1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("J1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));

                worksheet.Cell("A1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("B1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("C1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("D1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("E1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("F1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("G1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("H1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("I1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("J1").Style.Font.SetFontColor(XLColor.White);

                int row = 2;


                var query = from ef in _context.BookOrders
                            join p in _context.Books
                            on ef.BookId equals p.Id
                            join s in _context.Orders
                            on ef.OrderId equals s.Id
                            join t in _context.Customers
                            on s.CustomerId equals t.Id
                            where s.CreatedAt.Date >= DpStart.SelectedDate
                            where s.DeadLine.Date <= DpEnd.SelectedDate
                            where s.PaymentStatus == false
                            group s by new
                            {
                                s.Customer.Name,
                                s.Customer.Surname,
                                s.Customer.Phone,
                                s.Customer.Email,
                                s.CreatedAt,
                                s.DeadLine,
                                s.Fine,
                                s.Quantity,
                                s.TotalPrice,
                                p.BookName
                            }
                                        into g
                            select new
                            {
                                g.Key.Name,
                                g.Key.Surname,
                                g.Key.Phone,
                                g.Key.Email,
                                g.Key.CreatedAt,
                                g.Key.DeadLine,
                                g.Key.Fine,
                                Quantity = g.Sum(x => x.Quantity),
                                g.Key.TotalPrice,
                                g.Key.BookName,
                            };


                DgtReport.ItemsSource = query.ToList();

                foreach (var item in query.ToList())
                {
                    worksheet.Cell("A" + row).Value = item.Name;
                    worksheet.Cell("B" + row).Value = item.Surname;
                    worksheet.Cell("C" + row).Value = item.Phone;
                    worksheet.Cell("D" + row).Value = item.Email;
                    worksheet.Cell("E" + row).Value = item.BookName;
                    worksheet.Cell("F" + row).Value = item.Quantity;
                    worksheet.Cell("G" + row).Value = item.CreatedAt;
                    worksheet.Cell("H" + row).Value = item.DeadLine;
                    worksheet.Cell("I" + row).Value = item.Fine;
                    worksheet.Cell("J" + row).Value = item.TotalPrice;
                    row++;

                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Excel_Table";
                saveFileDialog.Filter = "Text files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "") return;
                    string result = saveFileDialog.FileName;
                
                    workbook.SaveAs(@"" + result);
                MessageBox.Show(result);

                BtnSaveAs.Visibility = Visibility.Hidden;
            }
        }
    }
}
