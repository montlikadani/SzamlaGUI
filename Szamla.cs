using System;

namespace Szamla {
    internal class Szamla {

        public readonly int Id;
        public readonly string TulajNev;
        public readonly decimal Egyenleg;
        public readonly DateTime NyitasDatum;

        public Szamla(int id, string owner, decimal money, DateTime nyitas) {
            Id = id;
            TulajNev = owner;
            Egyenleg = money;
            NyitasDatum = nyitas;
        }

        public override string ToString() {
            return TulajNev;
        }
    }
}
