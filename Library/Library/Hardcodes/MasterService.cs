using Library.Data;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Hardcodes
{
    abstract public class WriterService
    {
        protected IBookRepository bookRepository;
        protected IWriterRepository writerRepository;

        public WriterService()
        {
            this.bookRepository = new BookRepository(new ApplicationDbContext());
            this.writerRepository = new WriterRepository(new ApplicationDbContext());
        }


    }
}
