using System;
using System.Collections.Generic;
using System.Text;

namespace ClickerGameOO
{
    class ClickerGame
    {
        public int Points { get; private set; } = 0;
        int _pointsPerClick = 1;
        int _pointsPerClickIncrease = 1;

        public void Click()
        {
            Points += _pointsPerClick;
        }

        public void Upgrade()
        {
            if (Points < 10) return;
            Points -= 10;
            _pointsPerClick += _pointsPerClickIncrease;
        }

        public void SuperUpgrade()
        {
            if (Points < 100) return;
            Points -= 100;
            _pointsPerClickIncrease++;
        }
    }
}
