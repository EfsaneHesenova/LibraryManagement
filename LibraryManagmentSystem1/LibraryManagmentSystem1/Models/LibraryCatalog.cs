using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagmentSystem1.Exceptions;

namespace LibraryManagmentSystem1.Models
{
    internal class LibraryCatalog
    {
        Book[] books;

        public LibraryCatalog()
        {
            books = new Book[0];
        }
        public Book this[int index]
        {
            get
            {
                if (index < books.Length)
                { 
                    return books[index]; 
                }

                throw new CustomBookError(index);
            }
            
            set
            {
                if (index < books.Length )
                {
                    books[index] = value;
                }
                else
                {
                    throw new CustomBookError(index);
                }
            }
        }
    }

}
