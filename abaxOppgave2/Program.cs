using System;

namespace abaxOppgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bil1 = new Bil("Grønn", "NF123456", 147, 200, true);
            bil1.PrintInfo();

            var bil2 = new Bil("Blå", "NF654321", 150, 195, true);
            bil2.PrintInfo();

            var fly = new Fly("LN1234", 1000, 30, 2, 10);
            fly.PrintInfo();

            bil1.Kjør();
            fly.Kjør();

            var båt = new Båt(500, "ABC123", 100, 30);
            båt.PrintInfo();

            båt.Kjør();
        }
    }
}
