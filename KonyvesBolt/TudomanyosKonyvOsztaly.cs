using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvesBolt
{
    public enum TudomanyTerulet
    {
        Fizika,
        Kémia,
        Biológia,
        Egyéb
    }

    class TudomanyosKonyvOsztaly : KonyvOsztaly
    {
        TudomanyTerulet tudomanyTerulet;
        bool elismert;

        public TudomanyosKonyvOsztaly(string cim, string szerzo, int oldalszam, int ar, int kiadasev,TudomanyTerulet tudomanyTerulet, bool elismert) : base (cim,szerzo,oldalszam,ar,kiadasev)
        {
            this.TudomanyTerulet = tudomanyTerulet;
            this.Elismert = elismert;
        }

        public TudomanyTerulet TudomanyTerulet { get => tudomanyTerulet; set => tudomanyTerulet = value; }
        public bool Elismert { get => elismert; set => elismert = value; }

        public override string ToString()
        {
            return Cim + Szerzo + Oldalszam + Ar + Kiadasev + TudomanyTerulet + elismert;
        }
    }
}
