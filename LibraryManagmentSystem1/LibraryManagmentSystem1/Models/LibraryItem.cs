using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Models
{
    internal abstract class LibraryItem(string title, DateTime publicationYear)
    {
        public abstract string Title { get; set; }
        public abstract DateTime PublicationYear { get; set; }
        
        public abstract void DisplayInfo();

    }
}
