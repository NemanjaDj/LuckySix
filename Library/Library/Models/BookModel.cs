using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public Book Book { get; set; }

        public Writer Writer { get; set; }

        public int NumberOfBooks { get; set; }
    }
}
