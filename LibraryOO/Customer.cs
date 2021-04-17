using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOO
{
    class Customer
    {
        private int _Id;
        private List<Book> loanedBooks = new List<Book>();

        public Customer()
        {
            _Id = CustomerIdGenerator.Generate();
        }

        public void ShowId()
        {
            Console.WriteLine(_Id);
        }
    }
}
