using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;

namespace LibraryOO
{
    class Command
    {
        private Library library;

        public Command(Library library)
        {
            this.library = library;
        }
        public void LibraryHeader()
        {
            Console.Clear();
            Console.WriteLine("******Library menu******\n");
        }

        public bool YouWorkHereBro()
        {
            Console.WriteLine("Do you work here bro?\n(Y/N)");
            return YayNay();
        }

        public bool YayNay()
        {
            if (Console.ReadKey().Key == ConsoleKey.Y) return true;
            return false;
        }

        public void LibraryWorkerOrCustomerMenu()
        {
            if (YouWorkHereBro()) EmployeeMenu();
            else CustomerMenu();
        }

        private void CustomerMenu()
        {
            LibraryHeader();
            ShowCustomerOptions();
            var command = GetCustomerCommand();
            HandleCustomerCommand(command);
        }

        public string GetCustomerCommand()
        {
            return Console.ReadLine();
        }

        public void HandleCustomerCommand(string command)
        {
            if (ValidateCustomerCommand(command) == false) CustomerMenu();
            else if (command == "1") ValidateCharacter(GetCharacter());
            else if (command == "2") library.ListBooks();
            //else if (command == "3") 
            //else if (command == "4") 
            else if (command == "5") Environment.Exit(-1);
        }

        private string GetCharacter()
        {
            return Console.ReadLine().ToUpper();
        }

        public char ValidateCharacter(string character)
        {
            if (character == null) return 'A';
            else if (character.Length > 1) return 'A';
            else return Convert.ToChar(character);
        }

        public bool ValidateCustomerCommand(string command)
        {
            return "12345".Contains(command) && command.Length == 1;
        }

        public void ShowCustomerOptions()
        {
            Console.WriteLine("1: List available books by first character\n2: List all available books\n3: Select book to loan\n4: Return borrowed book\n5: Exit.");
        }

        public void EmployeeMenu()
        {
            LibraryHeader();
            Console.WriteLine("Do you want to add a new book?\n(Y/N)");
            
            if (YayNay())
            {
                GetBookInfo();
            }
            library.ListBooks();
        }

        private void GetBookInfo()
        {
            var title = AskForBookInfo("title");
            var author = AskForBookInfo("author");
            var genre = AskForBookInfo("genre");
            var pagecount = Int32.Parse(AskForBookInfo("page count"));
            library.CreateBook(title, author, genre, pagecount);
        }

        public string AskForBookInfo(string info)
        {
            Console.WriteLine($"Which {info} would you like to add?");
            return Console.ReadLine();
        }




        

    }
}
