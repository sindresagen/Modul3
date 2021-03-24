using System;
using System.Collections.Generic;
using System.Text;

namespace arv1
{
    class Box
    {
        public int directionX { get; private set; }
        public int directionY { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        private int _minimumSize = 3;

        public Box(Random random, int maxX, int maxY)
        {
            directionX = random.Next(0, 2);
            directionY = random.Next(0, 2);
            X = random.Next(0, maxX - _minimumSize);
            Y = random.Next(0, maxY - _minimumSize);
            Width = random.Next(_minimumSize, maxX - X);
            Height = random.Next(_minimumSize, maxY - Y);
        }

        public Box(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public string GetCharacter(int row, int col)
        {
            // Top left
            if (row == Y && col == X) return "";
            // Top right
            if (row == Y && col == X + Width) return "";
            // Bottom left
            if (row == Y + Height && col == X) return "";
            // Bottom right
            if (row == Y + Height && col == X + Width) return "";

            // Top line
            if (row == Y && col > X && col < X + Width) return "";
            // Bottom line
            if (row == Y + Height && col > X && col < X + Width) return "";
        }
    }
}
