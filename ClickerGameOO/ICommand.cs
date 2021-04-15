using System;
using System.Collections.Generic;
using System.Text;

namespace ClickerGameOO
{
    interface ICommand
    {
        void Run();
        char Character { get; }
    }
}
