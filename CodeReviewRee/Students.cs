using System;
using System.Collections.Generic;
using System.Text;

namespace CodeReviewRee
{
    class Students
    {
        public static void studentPlukkern(string[] students)
        { 
        Random r = new Random();

        int index1 = r.Next(students.Length);
        int index2 = r.Next(students.Length);

        Console.WriteLine($"De neste studentene til å bli fugged er {students[index1]} og {students[index2]}!!1!");
    }

    public static void VælkømminTekst(string[] students)
    {
    Console.Write("Hei!\r\nVil du velge to stakkarer som skal vise frem neste uke?\r\n(Y / N)\r\n");
    }
}
}
