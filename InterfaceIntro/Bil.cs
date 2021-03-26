using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIntro
{
    class Bil : Transportmiddel
    {
        public string Farge { get; }

        public Bil(string regnr, decimal effekt, decimal? maksFart, Transportmiddeltype? type, string farge) : base(regnr, effekt, maksFart, type)
        {
            Farge = farge;
        }

        public void Kjør()
        {
            Console.WriteLine(nameof(Bil) + " " + Regnr + " har fått beskjed om å kjøre.");
        }

        public override void ToStringOptional(StringBuilder text)
        {
            base.ToStringOptional(text);
            Add(text, nameof(Farge), Farge);
        }
    }
}
