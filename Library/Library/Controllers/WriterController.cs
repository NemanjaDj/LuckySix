using Library.Hardcodes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class WriterController : Controller
    {
        private BookService bookService;

        public WriterController()
        {
            bookService = new BookService();
        }

        public IActionResult Writers()
        {
            var writers = bookService.GetWriters();
            return View(writers);
        }

    }
}
