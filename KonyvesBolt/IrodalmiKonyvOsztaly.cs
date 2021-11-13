using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvesBolt
{
    public enum Kategoria
    {
        Vers,
        Novella,
        Elbeszélés,
        Egyéb
    }
    class IrodalmiKonyvOsztaly : KonyvOsztaly
    {
        Kategoria kategoria;

        public IrodalmiKonyvOsztaly(string cim, string szerzo, int oldalszam, int ar, int kiadasev,Kategoria kategoria) : base (cim,szerzo,oldalszam,ar,kiadasev)
        {
            this.Kategoria = kategoria;
        }

        public Kategoria Kategoria { get => kategoria; set => kategoria = value; }

        public override string ToString()
        {
            return Cim + Szerzo + Oldalszam + Ar + Kiadasev + Kategoria;
        }
    }
}
