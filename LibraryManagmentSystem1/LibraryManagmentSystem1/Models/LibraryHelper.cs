using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Models
{
    internal static class LibraryHelper
    {
        public static int CalculateAge(this LibraryItem item)
        {
            int age;
           return age = DateTime.Now.Year - item.PublicationYear.Year;
        }

        public static string ToTitleCase(this LibraryItem item)
        {
            StringBuilder sb = new StringBuilder();
            string word = item.Title;

            sb.Append(char.ToUpper(word[0]));
            sb.Append(word.Substring(1, word.Length - 1).ToLower());
            return sb.ToString();
        }
    }
}
