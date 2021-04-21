using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;

namespace LibraryOOSmall
{
    class Command
    {
        private Library library;
        private Customer customer;

        public bool IsCustomer;
        public bool IsEmployee;


        public Command(Library library, Customer customer)
        {
            this.library = library;
            this.customer = customer;
        }

        public void LibraryHeader()
        {
            Console.Clear();
            Console.WriteLine("===========Library Menu===========\n");
        }

        public void ShowCustomerOptions()
        {
            Console.WriteLine("1: List all available books\n2: Select book to loan\n3: Return borrowed book\n4: Exit.");
        }

        public void ShowEmployeeOptions()
        {
            Console.WriteLine("1: List all available books\n2: Select book to loan\n3: Return borrowed book\n4: Add new book\n5: Exit.");
        }

        public void EmployeeOrCustomer()
        {
            Console.WriteLine("Welcome!\nPick 1 for employee menu\nPick 2 for customer menu.\n");
            var command = Console.ReadLine();
            if (command == "1")
            {
                IsEmployee = true;
                ShowEmployeeOptions();
                var input = Console.ReadLine();
                HandleEmployeeCommand(input);
            }

            if (command == "2")
            {
                IsCustomer = true;
                ShowCustomerOptions();
                var input = Console.ReadLine();
                HandleCustomerCommand(input);
                
            }
            else
            {
                Console.WriteLine("Unknown command, try again.\n");
                EmployeeOrCustomer();
            }
            
        }

        public void HandleEmployeeCommand(string command)
        {
            switch (command)
            {
                case "1":
                    library.ListBooks();
                    //library.ListBorrowedBooks();
                    break;
                case "2":
                    BorrowBook();
                    Console.WriteLine("You borrowed book");
                    break;
                case "3":
                    Console.WriteLine("You returned book");
                    break;
                case "4":
                    GetBookInfo();
                    library.ListBooks();
                    break;
                case "5":
                    Console.WriteLine("Shutting down");
                    EmployeeOrCustomer();
                    IsEmployee = false;
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }

        public void HandleCustomerCommand(string command)
        {
            switch (command)
            {
                case "1":
                    library.ListBooks();
                    //library.ListBorrowedBooks();
                    break;
                case "2":
                    BorrowBook();
                    Console.WriteLine("You borrowed book");
                    break;
                case "3":
                    Console.WriteLine("You returned book");
                    break;
                case "4":
                    EmployeeOrCustomer();
                    IsCustomer = false;
                    break;
                default: 
                    Console.WriteLine("Unknown command");
                    break;
            }
        }

        public void BorrowBook()
        {
            //library.Customers.Add(customer);
            library.ListBooks();
            Console.WriteLine("Choose a book to borrow");
            var bookTitle = Console.ReadLine();
            var book = FindBookInLibrary(library, bookTitle);
            library.Customers[0].BorrowedBooks.Add(book);
            library.Books.Remove(book);
            ShowAllBooks(library);
            //library.BorrowedBooks.Add(new Book());
            //library.Books.RemoveAt(Int32.Parse(input ?? throw new InvalidOperationException()));
        }

        public void ShowAllBooks(Library library)
        {
            library.ListBooks();
            customer.ListBorrowedBooks();
        }

        private static Book FindBookInLibrary(Library library, string bookTitle)
        {
            foreach (var book in library.Books)
            {
                if (book._title == bookTitle) return book;
            }

            return null;
        }

        public void GetBookInfo()
        {
            var title = AskForBookInfo("title");
            var author = AskForBookInfo("author");
            var genre = AskForBookInfo("genre");
            var pageCount = Int32.Parse(AskForBookInfo("page count"));
            library.CreateBook(title, author, genre, pageCount);
        }

        public string AskForBookInfo(string info)
        {
            Console.WriteLine($"Which {info} would you like to add?");
            return Console.ReadLine();
        }
    }
}
