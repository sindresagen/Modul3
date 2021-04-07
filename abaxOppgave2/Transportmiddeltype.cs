using System;

namespace abaxOppgave2
{
    abstract class Transportmiddeltype : Transportmiddel
    {
        public int MaksFart { get; }
        public string Måleenhet { get; }

        protected Transportmiddeltype(string kjennetegn, int effekt, int maksFart, string måleenhet = "km/t") : base(kjennetegn, effekt)
        {
            MaksFart = maksFart;
            Måleenhet = måleenhet;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Maksfart = {MaksFart}{Måleenhet}");
        }
    }
}