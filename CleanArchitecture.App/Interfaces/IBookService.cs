using CleanArchitecture.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.App.Interfaces
{
    public interface IBookService
    {
        BooksViewModel GetBooks(); 

    }
}
