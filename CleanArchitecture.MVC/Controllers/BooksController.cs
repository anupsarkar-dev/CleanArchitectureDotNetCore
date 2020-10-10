using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.App.Interfaces;
using CleanArchitecture.App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.MVC.Controllers
{
    public class BooksController : Controller
    {
        private IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        public IActionResult Index()
        {
            BooksViewModel booksViewModel = bookService.GetBooks();

            return View(booksViewModel);
        }


    }
}
