using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.App.ViewModels
{
    public class BooksViewModel
    {
        public IEnumerable<Books> Books { get; set; }
    
    }
}
