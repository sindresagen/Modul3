using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOOSmall
{
    class BorrowBookCommand : ICommand
    {
        private Library _library;
        public BorrowBookCommand(Library library)
        {
            _library = library;
        }

        public string Name { get; }

        public void ExecuteCommand()
        {
            var customer = _library.GetCustomer();
            var book = _library.GetBook();
            _library.BorrowBook(customer, book);
        }
    }
}
