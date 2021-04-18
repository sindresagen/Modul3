using System;
using System.Collections.Generic;

namespace LibraryOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(400, "JK Rowling", "Harry Potter and the Philosophers Stone", "Fantasy");
            Book book2 = new Book(420, "JK Rowling", "Harry Plopper and the Final Solution", "Fantasy");
            Library library = new Library(book1, book2);
            
            
            

            var doneTask = false;

            while (doneTask == false)
            {
                var command = new Command(library);
                command.LibraryWorkerOrCustomerMenu();

            }

        }
    }
}
