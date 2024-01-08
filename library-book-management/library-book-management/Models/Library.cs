using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_book_management.Models
{
    public class Library
    {
        private List<Book> bookList;

        public Library()
        {
            bookList = new List<Book>();
        }

        public void AddBook(Book book)
        {
            bookList.Add(book);
        }

        public void RemoveBook(int bookId)
        {
            int removedBooksCount = bookList.RemoveAll(book => book.GetId() == bookId);

            if (removedBooksCount > 0)
            {
                Console.WriteLine($"Book(s) with the Id:'{bookId}' have been removed\n");
            }
            else
            {
                Console.WriteLine($"No books were found with the Id:'{bookId}'\n");
            }
        }

        public void DisplayBooks() { 
            if(bookList.Count == 0)
            {
               Console.WriteLine("No books found\n");
            } 
            else
            {
                foreach (Book book in bookList)
                {
                    Console.WriteLine(book.GetBook());
                }
            }
        }
    }    
}
