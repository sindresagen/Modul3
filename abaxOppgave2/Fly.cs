using System;

namespace abaxOppgave2
{
    class Fly : Transportmiddel
    {
        public int Vingespenn { get; }
        public int Lasteevne { get; }
        public int Egenvekt { get; }

        public Fly(string kjennetegn, int effekt, int vingespenn, int lasteevne, int egenvekt) : base(kjennetegn, effekt)
        {
            Vingespenn = vingespenn;
            Lasteevne = lasteevne;
            Egenvekt = egenvekt;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Fly");
            base.PrintInfo();
            Console.WriteLine($"Vingespenn = {Vingespenn} m");
            Console.WriteLine($"Lasteevne = {Lasteevne} tonn");
            Console.WriteLine($"Egenvekt = {Egenvekt} tonn");
        }

        public override void Kjør()
        {
            Console.WriteLine("Flyet letter");
        }
    }
}