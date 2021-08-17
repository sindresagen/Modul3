using System;

namespace LibraryOOSmall
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter and the Philosophers Stone", "JK Rowling",  "Fantasy", 400);
            Book book2 = new Book("Harry Plopper and the Prisoner from Azkaban", "JK Rowling",  "Fantasy", 410);
            Book book3 = new Book("The Lord of the Rings Trilogy", "J.R. Tolkien", "Fantasy", 800);
            Book book4 = new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy", 450);
            Library library = new Library(book1, book2, book3, book4);

            while (true)
            {
                var command = new CommandHandler(library);
                command.LibraryHeader();
                command.EmployeeOrCustomer();

                while (command.IsEmployee)
                {
                    command.ShowEmployeeOptions();
                }

                while (command.IsCustomer)
                {
                    command.EmployeeOrCustomer();
                }


            }
        }

        
    }
}
