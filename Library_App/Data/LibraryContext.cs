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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Management>().HasData(
                new Management
                {
                    Id = 1,
                    Name ="admin",
                    Surname="admin",    
                    UserName = "admin",
                    Parol = "admin",
                    Position = Positions.Admin
                }
                
                );
        }

    }
}
