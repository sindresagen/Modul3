using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOOSmall
{
    public static class IdGenerator
    {
        public static int Id = 111;

        public static int Generate()
        {
            Id++;
            return Id;
        }
    }
}
