using Library_App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library_App.Data
{
    public class LibraryContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-AI19BCB6\SQLEXPRESS;Database=Library;Integrated Security=True");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookOrder> BookOrders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Management> Managements { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
