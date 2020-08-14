using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_App.Models
{
    public enum language
    {
        Azerbaijani,
        Turkish,
        English,
        Russian
    }
    public class Book
    {

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string BookName { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public double Price { get; set; }
        [Required]
        public int Pages { get; set; }
        [Required]
        public int Quantity { get; set; }
        public language Language { get; set; }
        public ICollection<BookOrder> BookOrders { get; set; }
    }
}
