using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIntro
{
    class Båt : Transportmiddel
    {
        public decimal Bruttotonnasje;

        public Båt(string regnr, decimal effekt, decimal? maksFart, Transportmiddeltype? type, decimal bruttotonnasje) : base(regnr, effekt, maksFart, type)
        {
            Bruttotonnasje = bruttotonnasje;
            Enheter.Add(nameof(Bruttotonnasje), "kg");
            Enheter[nameof(MaksFart)] = "knop";
        }

        public override void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(Bruttotonnasje), Bruttotonnasje);
        }
    }
}
