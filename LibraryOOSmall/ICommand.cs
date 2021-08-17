using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOOSmall
{
    interface ICommand
    {
        string Name { get; }
        void ExecuteCommand();
    }
}
