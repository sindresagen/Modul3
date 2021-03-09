using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // JS:
            // var x = { width: 50, height: 50 };
            // C#:
            //var x = new { Width = 50, Height = 30 };
            //var x = new Box();
            //x.Width = 50;
            //x.Height = 50;
            // Dette er sånn det skal gjøres i C#, det over er bare unntaksvis fornuftig
            var x = new Box { Width = 50, Height = 50 };
            x.Show();
        }
    }
}
