using System;

namespace InterfaceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var bil1 = new Bil("NF123456", 147, 200, Transportmiddeltype.LettKjøretøy, "grønn");
            bil1.Print();
            var bil2 = new Bil("NF654321", 195, 150, Transportmiddeltype.LettKjøretøy, "blå");
            bil2.Print();
            bil2.Kjør();
            bil1.Sammenlign(bil2, "Bil 1 og bil 2 ");

            var fly1 = new Fly("LN1234", 1000, 0, Transportmiddeltype.JetFly, 30, 2, 10);
            fly1.Print();
            fly1.StartFly();

            var båt = new Båt("ABC123", 100, 30, Transportmiddeltype.Båt, 500);
            båt.Print();
        }
    }
}
