using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Models
{
    internal class Magazine : LibraryItem
    {
        public Magazine(string title, DateTime publicationYear) : base(title, publicationYear)
        {
        }

        public override string Title { get; set; }
        public override DateTime PublicationYear { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"<Magazine> \nTitle: {Title} \nPublication Year: {PublicationYear}");
        }
    }
}
