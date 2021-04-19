﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOOSmall
{
    class Library
    {
        public List<Book> Books;
        public List<Customer> Customers;

        public Library()
        {
            Books = new List<Book>();
        }

        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
        }

        public void ListBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book.GetDescription() + "\n");
            }
        }

        public void CreateBook(string title, string author, string genre, int pageCount)
        {
            Books.Add(new Book(title, author, genre, pageCount));
            Console.WriteLine($"{title} was added to the library");
        }
    }
}