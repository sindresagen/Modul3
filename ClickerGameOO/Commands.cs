using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ClickerGameOO
{
    class Commands
    {
        private ICommand[] _commands;

        public Commands(ClickerGame game)
        {
            _commands = new ICommand[]
            {
                new ExitCommand(),
                new ClickCommand(game),
                new UpgradeCommand(game),
                new SuperUpradeCommand(game),
            };
        }

        public void Run(char commandChar)
        {
            var command = FindCommand(commandChar);
            if (command != null) command.Run();
        }

        public ICommand FindCommand( char commandChar)
        {
            foreach (var command in _commands)
            {
                if (command.Character == commandChar) return command;
            }

            return null;
        }
    }
}
