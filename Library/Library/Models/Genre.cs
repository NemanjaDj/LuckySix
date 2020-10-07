using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Genre
    {
        [Required]
        [Key]
        public int GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }
        public virtual ICollection<BookGenre> BookGenres { get; set; }
    }
}
