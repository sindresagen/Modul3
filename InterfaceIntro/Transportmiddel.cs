using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InterfaceIntro
{
    class Transportmiddel
    {
        public string Regnr { get; }
        public decimal Effekt { get; }
        public decimal? MaksFart { get; }
        public Transportmiddeltype? Type { get; }

        protected Dictionary<string, string> Enheter = new Dictionary<string, string>
        {
            {nameof(MaksFart), "km/t" },
            {nameof(Effekt), "kw" },
        };

        public Transportmiddel(string regnr, decimal effekt, decimal? maksFart, Transportmiddeltype? type)
        {
            Regnr = regnr;
            Effekt = effekt;
            MaksFart = maksFart;
            Type = type;
        }

        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine(GetType().Name);
            Add(text, nameof(Regnr), Regnr);
            Add(text, nameof(MaksFart), MaksFart);
            Add(text, nameof(Effekt), Effekt);
            ToStringOptional(text);
            return text.ToString();
        }

        protected void Add(StringBuilder text, string name, object value)
        {
            if (value == null) return;
            text.Append(" ");
            text.Append(name);
            text.Append("=");
            text.Append(value);
            if (Enheter.ContainsKey(name)) text.Append(Enheter[name]);
            text.AppendLine();
        }

        public virtual void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(Transportmiddeltype), Type);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Transportmiddel);
        }

        private bool Equals(Transportmiddel transportmiddel)
        {
            return transportmiddel != null && GetType() == transportmiddel.GetType() && Regnr == transportmiddel.Regnr;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public void Sammenlign(Transportmiddel transportmiddel2, string prefix)
        {
            var erLike = Equals(transportmiddel2);
            var erLikeTekst = erLike ? string.Empty : "Ikke ";
            Console.Write(prefix);
            Console.WriteLine("er {0}samme kjøretøy.", erLikeTekst);
            Console.WriteLine();
        }
    }
}
