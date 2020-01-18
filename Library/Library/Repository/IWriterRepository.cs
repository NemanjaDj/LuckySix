using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface IWriterRepository
    {

        Writer GetWriterByName(string writerName);

        IEnumerable<Writer> GetWriters();

        Writer GetWriterById(int writerId);

        Writer GetBookWriter(int bookId);

    }
}
