using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        public int? PageNumber { get; set; }
        [Required]
        public double BookPrice { get; set; }
        [Required]
        public string Description { get; set; }
        [YearValidation]
        public int ReleaseYear { get; set; }
        [Required]
        public string Image { get; set; }
        public ICollection<BookGenre> BookGenres { get; set; }
        public int? WriterId { get; set; }
        public Writer Writer { get; set; }
        public virtual ICollection<BookRent> BookRents { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public NumberOfBooks NumberOfBooks { get; set; }
    }
}
