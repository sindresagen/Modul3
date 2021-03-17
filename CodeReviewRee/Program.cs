using System;

namespace CodeReviewRee
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Erik", "Henrik", "Kristian", "Stian", "Mikael", "Angelica", "Sondre", "Theodor", "Sigve" };

            Students.VælkømminTekst(students);
            var userInput = Console.ReadLine();
            if (userInput == "Y" || userInput == "y") Students.studentPlukkern(students);
            else Console.WriteLine("Neivel!");
            Console.WriteLine("Vil du velge på nytt?\r\n(Y / N)");
            var restartPlukker = Console.ReadLine();
            if (restartPlukker == "Y" || restartPlukker == "y") Students.VælkømminTekst(students);
        }
    }
}
