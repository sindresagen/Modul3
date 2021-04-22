using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOOSmall
{
    class Library
    {
        public List<Book> Books;
        public List<Customer> Customers = new List<Customer>();

        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
            
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public Customer GetCustomer()
        {
            Console.WriteLine("What's your user id?");
            var id = Int32.Parse(Console.ReadLine()); //?? throw new InvalidOperationException()
            var customer = GetCustomerById(id);
            return customer;
        }

        private Customer GetCustomerById(int id)
        {
            foreach (var customer in Customers)
            {
                if (customer.Id == id) return customer;
            }

            return null;
        }

        public Customer CheckUser()
        {
            Console.WriteLine("What is your user id?");
            var id = Int32.Parse(Console.ReadLine());
            foreach (var customer in Customers)
            {
                if (customer.Id == id) return customer;
            }

            return null;
        }

        public void BorrowBook(Customer customer, Book book)
        {
            customer.BorrowedBooks.Add(book);
            Books.Remove(book);
        }

        public void ReturnBook(Customer customer, Book book)
        {
            Books.Add(book);
            customer.BorrowedBooks.Remove(book);
        }
        

        public Book GetBook()
        {
            ListBooks();
            Console.WriteLine("Type the ID of the book you want to loan:");
            var id = Int32.Parse(Console.ReadLine());
            var book = GetBookById(id);
            return book;
        }

        public Book GetBorrowedBook()
        {
            ListBorrowedBooks();
            Console.WriteLine("Type the ID of the book you want to return:");
            var id = Int32.Parse(Console.ReadLine());
            var book = GetBookById(id);
            return book;
        }

        public void ListBorrowedBooks()
        {
            var customer = CheckUser();
            if (customer != null) ListCustomerBooks(customer);
        }

        public void ListCustomerBooks(Customer customer)
        {
            Console.WriteLine($"Customer {customer.Id} has these books:\n");
            foreach (var book in customer.BorrowedBooks)
            {
                Console.WriteLine(book.GetDescription() + "\n");
            }
        }

        private Book GetBookById(int id)
        {
            foreach (var book in Books)
            {
                if (book._id == id) return book;
            }

            return null;
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
