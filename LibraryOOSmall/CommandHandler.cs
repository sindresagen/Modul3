using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;

namespace LibraryOOSmall
{
    class CommandHandler
    {
        public Library _library;
        private AddUserCommand _addUser;
        private GetBookInfoCommand _getBookInfo;
        private ReturnBookCommand _returnBook;
        private BorrowBookCommand _borrowBook;

        public bool IsCustomer;
        public bool IsEmployee;


        public CommandHandler(Library library)
        {
            _library = library;
            _addUser = new AddUserCommand(_library);
            _getBookInfo = new GetBookInfoCommand(_library);
            _returnBook = new ReturnBookCommand(_library);
            _borrowBook = new BorrowBookCommand(_library);
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

        public void AddUser()
        {
            _addUser.ExecuteCommand();
        }

        public void HandleEmployeeCommand(string command)
        {
            switch (command)
            {
                case "1":
                    _library.ListBooks();
                    break;
                case "2":
                    BorrowBook();
                    Console.WriteLine("You borrowed book");
                    break;
                case "3":
                    _library.GetBorrowedBook();
                    ReturnBook();
                    Console.WriteLine("You returned book");
                    break;
                case "4":
                    GetBookInfo();
                    _library.ListBooks();
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
                    _library.ListBooks();
                    break;
                case "2":
                    BorrowBook();
                    Console.WriteLine("You borrowed book");
                    break;
                case "3":
                    _library.GetBorrowedBook();
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
            _borrowBook.ExecuteCommand();
        }

        public void ReturnBook()
        {
            _returnBook.ExecuteCommand();
        }


        public void GetBookInfo()
        {
            _getBookInfo.ExecuteCommand();
        }

    }
}
