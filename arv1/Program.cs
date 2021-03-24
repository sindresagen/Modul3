﻿using System;
using System.Threading;

namespace arv1
{
    class Program
    {
        private static int _width = 50;
        private static int _height = 20;

        static void Main(string[] args)
        {
            var shapes = CreateTriangles();
            while (true)
            {
                Show(shapes);
                foreach (var box in shapes)
                {
                    triangle.Move();
                }
                Thread.Sleep(300);
            }
        }

        private static Triangle[] CreateTriangles()
        {
            var random = new Random();
            var triangles = new Triangle[3];
            for (var i = 0; i < triangles.Length; i++)
            {
                triangles[i] = new Triangle(random, _height);
            }

            return triangles;
        }

        private static void Show(Triangle[] triangles)
        {
            Console.Clear();
            for (var row = 0; row < _height; row++)
            {
                for (var col = 0; col < _width; col++)
                {
                    var hasFoundCharacterToPrint = false;
                    foreach (var box in triangles)
                    {
                        var character = box.GetCharacter(row, col);
                        if (charater != null)
                        {
                            Console.Write(character);
                            hasFoundCharacterToPrint = true;
                            break;
                        }
                    }
                    if (!hasFoundCharacterToPrint) Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        private static void Show(Box[] boxes)
        {
            Console.Clear();
            for (var row = 0; row < _height; row++)
            {
                for (var col = 0; col < _width; col++)
                {
                    var hasFoundCharacterToPrint = false;
                    foreach (var box in boxes)
                    {
                        var character = box.GetCharacter(row, col);
                        if (charater != null)
                        {
                            Console.Write(character);
                            hasFoundCharacterToPrint = true;
                            break;
                        }
                    }
                    if (!hasFoundCharacterToPrint) Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
