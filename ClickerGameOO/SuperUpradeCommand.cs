using System;
using System.Collections.Generic;
using System.Text;

namespace ClickerGameOO
{
    class SuperUpradeCommand : ICommand
    {
        private ClickerGame _game;
        public char Character { get; } = 'S';

        public SuperUpradeCommand(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.SuperUpgrade();
        }
    }
}
