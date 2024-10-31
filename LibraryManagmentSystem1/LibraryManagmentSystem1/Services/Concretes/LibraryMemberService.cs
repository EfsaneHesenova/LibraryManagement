using LibraryManagmentSystem1.Models;
using LibraryManagmentSystem1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Services.Concretes
{
    internal class LIbraryMemberService : ILibraryMemberService
    {
        public static List<LibraryMember> members;
        

        public void CreateLibraryMember(LibraryMember libraryMember)
        {
           members.Add(libraryMember);
        }

        public void DeleteLibraryMember(LibraryMember libraryMember, bool IsSoftDelete)
        {
            if (IsSoftDelete)
            {
                libraryMember.IsDeleted = true;
            }
            else
            {
                members.Remove(libraryMember);
            }
        }

        public LibraryMember[] GetAllLibraryMember()
        {
            return members.Where(item => item.IsDeleted == false).ToArray();
        }

        public LibraryMember GetLibraryMemberById(int id)
        {
            LibraryMember libraryMember = members.FirstOrDefault(item => item.Id == id && item.IsDeleted == false);
            return libraryMember ?? throw new Exception("Library member not found");
        }
    }
}
