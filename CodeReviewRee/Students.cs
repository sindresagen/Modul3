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

        int index1 = r.Next(0, students.Length);
        //int index2 = r.Next(0, students.Length);

        Console.WriteLine($"Den neste stakkaren er {students[index1]}");
    }

    public static void VælkømminTekst(string[] students)
    {
    Console.Write("Hei!\r\nVil du velge en stakkar som skal vise frem neste uke?\r\n(Y / N)\r\n");
    }

}
}
