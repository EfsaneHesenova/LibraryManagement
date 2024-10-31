using LibraryManagmentSystem1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Models
{
    internal class Book : LibraryItem
    {
        
        private int _id = 0;
        public int Id { get; set; } 
        public BookJenre Genre { get; set; }
        public override string Title { get; set; }
        public override DateTime PublicationYear { get; set; }
        public LibraryLocation libraryLocation { get; set; }
        public bool IsDeleted { get; set; }

        public Book(string title, DateTime publicationYear, BookJenre genre) : base(title, publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
            Genre = genre;
            Id = _id++;
            IsDeleted = false;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"<Book> \nTitle: {Title} \nGenre: {Genre} \nPublication Year: {PublicationYear}");
        }
    }
}
