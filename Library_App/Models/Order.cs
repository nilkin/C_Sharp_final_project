﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library_App.Models
{
    public class Order
    {
        public Order()
        {
            CreatedAt = DateTime.Now;
        }
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public double TotalPrice { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; } 
        public DateTime DeadLine { get; set; } 
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<BookOrder> BookOrders { get; set; }



    }
}