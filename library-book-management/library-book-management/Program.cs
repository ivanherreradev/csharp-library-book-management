using library_book_management.Models;

Library library = new Library();

Book book1 = new Book(1, "Harry Potter and the philosopher's stone", "J. K. Rowling", 1997);
Book book2 = new Book(2, "Harry Potter and the secret chamber", "J. K. Rowling", 1998);

Console.WriteLine("--- Add Books ---");
library.AddBook(book1);
library.AddBook(book2);

library.DisplayBooks();

Console.WriteLine("--- Try remove invalid ID ---");
library.RemoveBook(9);

Console.WriteLine("--- Remove book with ID 1 ---");
library.RemoveBook(1);

library.DisplayBooks();
