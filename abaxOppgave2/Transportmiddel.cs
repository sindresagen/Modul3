using System;
using System.Collections.Generic;

namespace abaxOppgave2
{
    abstract class Transportmiddel
    {
        public string Kjennetegn { get; }
        public int Effekt { get; }
       

        protected Transportmiddel(string kjennetegn, int effekt)
        {
            Kjennetegn = kjennetegn;
            Effekt = effekt;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Kjennetegn = {Kjennetegn}");
            Console.WriteLine($"Effekt = {Effekt}");
        }

        public abstract void Kjør();
    }
}