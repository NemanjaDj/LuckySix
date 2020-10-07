using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class NumberOfBooks
    {
        [Required]
        [Key]
        public int NumberOfBooksId { get; set; }
        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int? NumberOfBooksInStore { get; set; }
    }
}
