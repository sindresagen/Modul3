using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOOSmall
{
    class Customer
    {
        
        public List<Book> BorrowedBooks = new List<Book>();
        public int Id { get; private set; } = IdGenerator.Generate();

        public Customer(int id)
        {
            Id = id;
        }

    }
}
