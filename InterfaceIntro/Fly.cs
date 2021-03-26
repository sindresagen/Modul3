using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIntro
{
    class Fly : Transportmiddel
    {
        public int Vingespenn { get; }
        public int Lasteevne { get; }
        public int Egenvekt { get; }

        public Fly(string regnr, decimal effekt, decimal? maksFart, Transportmiddeltype? type, int vingespenn, int lasteevne, int egenvekt) : base(regnr, effekt, maksFart, type)
        {
            Vingespenn = vingespenn;
            Lasteevne = lasteevne;
            Egenvekt = egenvekt;
            Enheter.Add(nameof(Vingespenn), "m");
            Enheter.Add(nameof(Lasteevne), "tonn");
            Enheter.Add(nameof(Egenvekt), "tonn");
        }

        public void StartFly()
        {
            Console.WriteLine(nameof(Fly) + " " + Regnr + " har fått beskjed om å fly.");
        }

        public override void ToStringOptional(StringBuilder text)
        {
            base.ToStringOptional(text);
            Add(text, nameof(Vingespenn), Vingespenn);
            Add(text, nameof(Lasteevne), Lasteevne);
            Add(text, nameof(Egenvekt), Egenvekt);
        }
    }
}
