using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Inferfaces
{
    public interface IBookRepository
    {
        IEnumerable<Books> GetBooks();
    }
}
