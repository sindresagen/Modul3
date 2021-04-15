using System;
using System.Collections.Generic;
using System.Text;

namespace ClickerGameOO
{
    class ExitCommand : ICommand
    {
        public char Character { get; } = 'X';

        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
