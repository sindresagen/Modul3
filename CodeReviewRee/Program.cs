using System;

namespace CodeReviewRee
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Sindre", "Agith", "Bjørn", "Mikael" };
            var Kjør = true;
            while (Kjør)
            {
                Students.VælkømminTekst(students);
                var userInput = Console.ReadLine().ToUpper();
                if (userInput == "Y") Students.studentPlukkern(students);
                else Console.WriteLine("Neivel!");
                Console.WriteLine("Vil du velge på nytt?\r\n(Y / N)");
                var restartPlukker = Console.ReadLine().ToUpper();
                if (restartPlukker == "N") Kjør = false;
            }
        }
    }
}
