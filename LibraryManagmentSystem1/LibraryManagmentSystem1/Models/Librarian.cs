using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Models
{
    internal class Librarian : Person
    {

        private static int _id = 0;
        public override int Id { get; set; }
        public override string Name { get; set; }
        public DateTime HareDate { get; set; }
        public bool IsDeleted { get; set; }
        public Librarian(string name, DateTime hareDate) : base(name)
        {
            Name = name;
            HareDate = hareDate;
            Id = _id++;
            IsDeleted = false;
        }
    }
}
