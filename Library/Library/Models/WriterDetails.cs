using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class WriterDetails
    {
        public IEnumerable<Genre> Genres { get; set; }

        public IEnumerable<Book> Books { get; set; }

        public Writer Writer { get; set; }

        public WriterDetails(IEnumerable<Genre> genres, IEnumerable<Book> books, Writer writer)
        {
            this.Genres = genres;
            this.Books = books;
            this.Writer = writer;
        }
    }
}
