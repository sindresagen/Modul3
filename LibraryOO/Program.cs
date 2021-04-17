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
            var c1 = new Customer();
            var c2 = new Customer();
            var c3 = new Customer();
            var c4 = new Customer();
            var c5 = new Customer();
            var customerList = new List<Customer>() {c1, c2, c3, c4, c5};
            foreach (var customer in customerList)
            {
                customer.ShowId();
            }
            var command = new Command(library);
            Console.WriteLine(command.YouWorkHereBro());
            

            var doneTask = false;

            while (doneTask == false)
            {
                

            }

        }
    }
}
