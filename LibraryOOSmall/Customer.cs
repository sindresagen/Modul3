using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOOSmall
{
    class Customer
    {
        public List<Book> BorrowedBooks;

        public Customer(params Book[] books)
        {
            BorrowedBooks = new List<Book>(books);
        }

        public void ListBorrowedBooks()
        {
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine("Borrowed book(s):\n" + book.GetDescription() + "\n");
            }
        }
    }
}
