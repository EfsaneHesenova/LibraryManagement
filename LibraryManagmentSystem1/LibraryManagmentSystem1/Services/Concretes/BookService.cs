using LibraryManagmentSystem1.Models;
using LibraryManagmentSystem1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Services.Concretes
{
    internal class BookService : IBookService
    {
        public static List<Book> books;
        public void CreateBook(Book book)
        {
            books.Add(book);
        }

        public void DeleteBook(Book book, bool IsSoftDelete)
        {
            if (IsSoftDelete)
            {
                book.IsDeleted = true;
            }
            else
            {
                books.Remove(book);
            }
        }

        public Book[] GetAllBook()
        {
            return books.Where(item => item.IsDeleted = false).ToArray();
        }
        
        public Book GetBookById(int id)
        {
            Book book = books.FirstOrDefault(item => item.Id == id && item.IsDeleted == false);
            return book?? throw new Exception("Book not found");
        }
    }
}
