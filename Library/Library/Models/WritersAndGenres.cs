using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class WritersAndGenres
    {
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Writer> Writer { get; set; }
        public Book Book { get; set; }
    }
}
