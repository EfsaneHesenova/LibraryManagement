using LibraryManagmentSystem1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Services.Interfaces
{
    internal interface IBookService
    {
        public Book GetBookById(int id);
        public Book[] GetAllBook();
        public void CreateBook(Book book );
        public void DeleteBook(Book book, bool IsSoftDelete);
    }
}
