using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Hardcodes;
using Library.Models;
using Library.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        //private IBookRepository bookRepository;
        private BookService bookService;

        public BookController()

        {
            this.bookService = new BookService();
            // this.bookRepository = new BookRepository(new ApplicationDbContext());

        }

        public IActionResult Books()
        {
            var books = bookService.ShowBooks();
            return View(books);
        }
        public IActionResult AddBook()
        {
            WritersAndGenres writersAndGenres = new WritersAndGenres();
            writersAndGenres.Genres = bookService.GetAllGenre();
            writersAndGenres.Writer = bookService.GetWriters();
            return View(writersAndGenres);
        }

        [HttpPost]
        public ActionResult AddBook(IFormCollection collection, Book book)
        {
            if (!ModelState.IsValid)
            {
                var model = new WritersAndGenres
                {
                    Book = book,
                    Genres = bookService.GetAllGenre(),
                    Writer = bookService.GetWriters()
                };
            return View("AddBook", model);
            }

            try
            {
                var genreList = collection["bookGenre"];
                var writerId = collection["writerId"];
                bookService.InsertBook(book, writerId, genreList);
                return RedirectToAction("Books");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View();
            }
        }

        public IActionResult BookTemplate(int id)
        {
            var bookrender = bookService.RenderBook(id);
            return View(bookrender);
        }
    }
}