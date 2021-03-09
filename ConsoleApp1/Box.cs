using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Box
    {
        public int Width;
        public int Height;

        internal void Show()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Bredden er " + Width + " og høyden er " + Height);
        }
    }
}
