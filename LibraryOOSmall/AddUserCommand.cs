using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOOSmall
{
    class AddUserCommand : ICommand
    {
        private Library _library;
        public AddUserCommand(Library library)
        {
            _library = library;
        }

        public string Name { get; }

        public void ExecuteCommand()
        {
            Console.WriteLine("Write in the ID you wish:");
            var id = Int32.Parse(Console.ReadLine());
            var customer = new Customer(id);

            _library.AddCustomer(customer);
            Console.WriteLine($"Id is {customer.Id}");
        }
    }
}
