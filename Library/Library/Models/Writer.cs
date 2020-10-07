using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Writer
    {
        [Required]
        [Key]
        public int WriterId { get; set; }
        [Required]
        public string WriterName { get; set; }
        public int? YearOfBirth { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
