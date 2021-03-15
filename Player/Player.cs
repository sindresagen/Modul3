using System;
using System.Collections.Generic;
using System.Text;

namespace Player
{
    class Player
    {
        //fields
        private string Name = "";
        private int Points;
        private readonly Random r = new Random();

        //constructors
        public Player(string name, int points)
        {
            Name = name;
            Points = points;
        }

        //methods
        public void Play(Player spiller)
        {
            int Winner = r.Next(0, 1);
            if (Winner == 0)
            {
                this.Points--;
                spiller.Points++;
            }
            else
            {
                this.Points++;
                spiller.Points--;
            }
        }
        public void ShowNameAndPoints()
        {
            Console.WriteLine($"{this.Name} {this.Points}");
        }
    }
}
