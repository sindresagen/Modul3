using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;

namespace LibraryOOSmall
{
    class CommandHandler
    {
        private Library library;

        public bool IsCustomer;
        public bool IsEmployee;


        public CommandHandler(Library library)
        {
            this.library = library;
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
            Console.WriteLine("Hello! Type adduser to add new user\n");
            var command = Console.ReadLine();
            if (command == "adduser") AddUser();
            
            Console.WriteLine("Welcome!\nPick 1 for employee menu\nPick 2 for customer menu.\n");
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

        private void AddUser()
        {
            Console.WriteLine("Write in the ID you wish:");
            var id = Int32.Parse(Console.ReadLine());
            var customer = new Customer(id);

            library.AddCustomer(customer);
            Console.WriteLine($"Id er {customer.Id}");
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
                    library.GetBorrowedBook();
                    ReturnBook();
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
                    library.GetBorrowedBook();
                    ReturnBook();
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
            //Prøver å lage funksjon til å ta ut en bok fra lista med bøker.

            //library.Customers.Add(customer);
           
            var customer = library.GetCustomer();
            var book = library.GetBook();
            library.BorrowBook(customer, book);
            
            //ShowAllBooks(library,);
            //library.Books.RemoveAt(Int32.Parse(input ?? throw new InvalidOperationException()));
        }

        public void ReturnBook()
        {
            var customer = library.GetCustomer();
            var book = library.GetBook();
            library.ReturnBook(customer, book);
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
