using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Models
{
    internal class Book : LibraryItem
    {
        public Book(string title, DateTime publicationYear, string genre) : base(title, publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
            Genre = genre;

        }

        public string Genre { get; set; }
        public override string Title { get; set; }
        public override DateTime PublicationYear { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"<Book> \nTitle: {Title} \nGenre: {Genre} \nPublication Year: {PublicationYear}");
        }
    }
}
