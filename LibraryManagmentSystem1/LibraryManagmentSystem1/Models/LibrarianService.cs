using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagmentSystem1.Interfaces;
namespace LibraryManagmentSystem1.Models
{
    internal class LibrarianService : ILibrarianService
    {
        Librarian[] librarians = new Librarian[0];
        public void CreateLibrarian(Librarian librarian)
        {
            Array.Resize(ref librarians, librarians.Length + 1);
            librarians[^1] = librarian;
        }

        public void DeleteLibrarian(Librarian librarian, bool IsSoftDelete)
        {
            int index = -1;

            for (int i = 0; i < librarians.Length; i++)
            {
                if(librarians[i] == librarian)
                {
                    index = i;
                    break;
                }
            }

            if (index >= 0)
            {
                if (IsSoftDelete)
                {
                    librarians[index].IsDeleted = true;
                }
                else
                {
                    for (int i = index; i < librarians.Length - 1; i++)
                    {
                        librarians[i] = librarians[i + 1];
                    }
                    Array.Resize(ref librarians, librarians.Length - 1);
                }
            }
            else
            {
                throw new Exception("Librarian not found.");
            }

        }

        public Librarian[] GetAllLibrarians()
        {
            int count = 0;

            foreach (Librarian librarian in librarians)
            {
                if (librarian != null && !librarian.IsDeleted)
                {
                    count++;
                }
            }

            Librarian[] activeLibrarians = new Librarian[count];
            int index = 0;

            foreach (Librarian librarian in librarians)
            {
                if (librarian != null && !librarian.IsDeleted)
                {
                    activeLibrarians[index++] = librarian;
                }
            }

            return activeLibrarians;
        }

        public Librarian GetLibrarianById(int id)
        {
            foreach (Librarian? librarian in librarians)
            {
                if (librarian != null && librarian.Id == id && !librarian.IsDeleted)
                {
                    return librarian;
                }
            }
            throw new Exception("Librarian not found.");
        }
    }
}
