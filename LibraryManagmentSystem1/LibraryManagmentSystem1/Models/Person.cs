using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Models
{
    public abstract class Person(string name)
    {

        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
    }
}
