using LibraryManagmentSystem1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Services.Interfaces
{
    internal interface ILibraryMemberService
    {
        public LibraryMember GetLibraryMemberById(int id);
        public LibraryMember[] GetAllLibraryMember();
        public void CreateLibraryMember(LibraryMember libraryMember);
        public void DeleteLibraryMember(LibraryMember libraryMember, bool IsSoftDelete);
    }
}
