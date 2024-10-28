using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Models
{
    internal class DVD : LibraryItem
    {
        public DVD(string title, DateTime publicationYear) : base(title, publicationYear)
        {
        }

        public override string Title { get; set; }
        public override DateTime PublicationYear { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"<DVD> \nTitle: {Title} \nPublication Year: {PublicationYear}");
        }
    }
}
