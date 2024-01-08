using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_book_management.Models
{
    public class Book
    {
        private int Id;
        private string Title;
        private string Author;
        private int Year;

        public Book(int id, string title, string author, int year)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
        }

        public int GetId ()
        {
            return Id;
        }

        public string GetBook()
        {
            return $"Title: {Title}\nAuthor: {Author}\nYear of publication: {Year}\n";
        }
    }
}
