using System;
using System.ComponentModel;
using System.Text;

namespace abaxOppgave2
{
    class Båt : Transportmiddeltype
    {
        public int Bruttotonnasje { get; }

        public Båt(int bruttotonnasje, string kjennetegn, int effekt, int maksFart, string måleenhet = "knop") : base(kjennetegn, effekt, maksFart, måleenhet)
        {
            Bruttotonnasje = bruttotonnasje;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Båt");
            base.PrintInfo();
            Console.WriteLine($"Bruttotonnasje = {Bruttotonnasje} kg");
        }

        public override void Kjør()
        {
            Console.WriteLine("Båten kjører");
        }

    }
}