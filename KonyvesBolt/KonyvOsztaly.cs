using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvesBolt
{

    class KonyvOsztaly
    {
        string cim;
        string szerzo;
        int oldalszam;
        int ar;
        int kiadasev;

        public KonyvOsztaly(string cim, string szerzo, int oldalszam, int ar, int kiadasev)
        {
            this.Cim = cim;
            this.Szerzo = szerzo;
            this.Oldalszam = oldalszam;
            this.Ar = ar;
            this.Kiadasev = kiadasev;
        }

        public string Cim  {get => cim; set => cim = value;}   
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public int Oldalszam { get => oldalszam; set => oldalszam = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Kiadasev { get => kiadasev; set => kiadasev = value; }

        public override string ToString()
        {
            return cim;
        }
    }
}
