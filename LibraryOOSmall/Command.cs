using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOOSmall
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
            Console.WriteLine("===========Library Menu===========\n");
        }

        
    }
}
