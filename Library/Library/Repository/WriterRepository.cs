using Library.Data;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class WriterRepository : IWriterRepository
    {
        public ApplicationDbContext applicationDbContext;

        public WriterRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public Writer GetWriterById(int writerId)
        {
            return applicationDbContext.Writers.Where(w => w.WriterId == writerId).FirstOrDefault();
        }

        public Writer GetWriterByName(string writerName)
        {
            return applicationDbContext.Writers.FirstOrDefault(w => w.WriterName == writerName);
        }

        public IEnumerable<Writer> GetWriters()
        {
            return applicationDbContext.Writers.ToList();
        }
        public Writer GetBookWriter(int bookId)
        {
            return applicationDbContext.Books.Where(b => b.BookId == bookId).Select(b => b.Writer).FirstOrDefault();
        }

        public void InsertWriter(Writer writer)
        {
            applicationDbContext.Writers.Add(writer);
            applicationDbContext.SaveChanges();
        }
    }
}
