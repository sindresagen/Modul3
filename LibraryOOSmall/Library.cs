using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOOSmall
{
    class Library
    {
        public List<Book> Books;
        public List<Book> BorrowedBooks;
        public List<Customer> Customers;

        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
            BorrowedBooks = new List<Book>(books);
        }

        public void ListBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book.GetDescription() + "\n");
            }
        }

        public void ListBorrowedBooks()
        {
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine("Borrowed book(s):\n" + book.GetDescription() + "\n");
            }
        }

        public void CreateBook(string title, string author, string genre, int pageCount)
        {
            Books.Add(new Book(title, author, genre, pageCount));
            Console.WriteLine($"{title} was added to the library");
        }
    }
}
