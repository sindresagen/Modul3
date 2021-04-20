using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOO
{
    class Library
    {
        public List<Book> Books;
        public List<Customer> Customers;


        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void ListBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book.GetDescription() + "\n");
            }
        }

        public void GetBookByCharacter(char character)
        {
            var noBook = true;
            for (int i = 0; i < Books.Count; i++)
            {
                string title = Books[i].GetTitle();
                if (title[0] == character)
                {
                    Console.WriteLine(title);
                    noBook = false;
                }
            }
            if (noBook) Console.WriteLine($"No book matches the character {character}..");
        }

        public void CreateBook(string title, string author, string genre, int pageCount)
        {
            Books.Add(new Book(pageCount, author, title, genre));
            Console.WriteLine($"{title} was added to the library");
        }
    }
}
