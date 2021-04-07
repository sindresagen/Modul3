using System;
using System.ComponentModel;
using System.Text;

namespace abaxOppgave2
{
    class Bil : Transportmiddeltype
    {
        public string Farge { get; }
        public bool Lettkjøretøy { get; }

        public Bil(string farge, string kjennetegn, int effekt, int maksFart, bool lettkjøretøy) : base(kjennetegn, effekt, maksFart)
        {
            Farge = farge;
            Lettkjøretøy = Lettkjøretøy;
        }

        public override void Kjør()
        {
            Console.WriteLine("Bilen kjører");
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Bil");
            base.PrintInfo();
            Console.WriteLine($"Farge = {Farge}");
            if (Lettkjøretøy) Console.WriteLine("Lettkjøretøy");
            Console.WriteLine();
        }
    }
}