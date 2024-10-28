using LibraryManagmentSystem1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Interfaces
{
    internal interface ILibrarianService
    {
        public  Librarian GetLibrarianById(int id);
        public Librarian[] GetAllLibrarians();
        public void CreateLibrarian(Librarian librarian);
        public void DeleteLibrarian( Librarian librarian, bool IsSoftDelete );
    }
}
