using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Models
{
    public sealed class LibraryMember : Person
    {


        public DateTime MemberShipDate { get; set; }
        private static int _id = 0;
        public override int Id { get; set; }
        public override string Name { get; set; }
        public bool IsDeleted { get; set; }
        public LibraryMember(string name, DateTime memberShipDate) : base(name)
        {
            Name = name;
            MemberShipDate = memberShipDate;
            IsDeleted = false;
        }
    }
}
