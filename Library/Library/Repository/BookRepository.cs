using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Models;

namespace Library.Repository
{
    public class BookRepository : IBookRepository
    {

        public ApplicationDbContext applicationDbContext;

        public BookRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public void AddBookGenre(int bookId, int genreId)
        {
            BookGenre bookGenre = new BookGenre();
            bookGenre.BookId = bookId;
            bookGenre.GenreId = genreId;
            applicationDbContext.Add(bookGenre);
            applicationDbContext.SaveChanges();
        }

        public Book getBookById(int bookId)
        {
            return applicationDbContext.Books.FirstOrDefault(b => b.BookId == bookId);
        }

        public Genre getGenreById(int genreId)
        {
            return applicationDbContext.Genres.Where(g => g.GenreId == genreId).FirstOrDefault();
        }

        public Genre getGenreByName(string genreName)
        {
            return applicationDbContext.Genres.Where(g => g.GenreName == genreName).FirstOrDefault();
        }


        public void InsertBook(Book book)
        {
            applicationDbContext.Add(book);
            applicationDbContext.SaveChanges();
        }

        public IEnumerable<Models.Book> ShowBooks()
        {
            return applicationDbContext.Books.ToList();
        }


        public List<int> GetGenresId(int bookId)
        {
            return applicationDbContext.BookGenre.Where(bg => bg.BookId == bookId).Select(bg => bg.GenreId).ToList();
        }

        public void AddNumberOfBooks(int bookId, int? numberOfBooks)
        {
            NumberOfBooks bookCounter = new NumberOfBooks();
            bookCounter.BookId = bookId;
            bookCounter.NumberOfBooksInStore = numberOfBooks;
            applicationDbContext.NumberOfBooks.Add(bookCounter);
            applicationDbContext.SaveChanges();
        }

        public int? NumberOfBook(int bookId)
        {
            return applicationDbContext.NumberOfBooks.Where(nb => nb.BookId == bookId).Select(nb => nb.NumberOfBooksInStore).FirstOrDefault();
        }

        public List<Genre> GetAllGenres()
        {
            return applicationDbContext.Genres.ToList();
        }

        public List<Book> FindBookByName(string bookName)
        {
            return applicationDbContext.Books.Where(b => b.BookName.Contains(bookName)).ToList();
        }
    }
}
