using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOO
{
    class CustomerIdGenerator
    {
        public static int Id = 111111111;

        public static int Generate()
        {
            Id++;
            return Id;
        }
    }
}
