using CleanArchitecture.App.Interfaces;
using CleanArchitecture.App.ViewModels;
using CleanArchitecture.Domain.Inferfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.App.Services
{
    public class BookService : IBookService
    {

        public IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public BooksViewModel GetBooks()
        {
            return new BooksViewModel { Books = _bookRepository.GetBooks() };
        }


    }
}
