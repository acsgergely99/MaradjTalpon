using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaradjTalpon
{
    class Kerdesek
    {
        public int nehezsegiSzint;
        public string kerdes;
        public string[] valaszok;
        public string kategoria;
        public string helyesValaszok;
        public bool votma;

        public int Nehezseg { get => nehezsegiSzint; set => nehezsegiSzint = value; }
        public string Kerdes { get => kerdes; set => kerdes = value; }
        public string[] Valaszok { get => valaszok; set => valaszok = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        public string HelyesValaszok { get => helyesValaszok; set => helyesValaszok = value; }
        public bool Votma { get => votma; set => votma = value; }

        public Kerdesek(int nehezsegiSzint, string kerdes, string[] valaszok, string helyesValaszok,string kategoria )
        {
            this.valaszok = valaszok;
            this.nehezsegiSzint = nehezsegiSzint;
            this.kerdes = kerdes;
           // this.valaszok[0] = valaszok[0];
            //this.valaszok[1] = valaszok[1];
          //  this.valaszok[2] = valaszok[2];
          //  this.valaszok[3] = valaszok[3];
            this.kategoria = kategoria;
            this.helyesValaszok = helyesValaszok;
            this.votma = false;
        }

        public override string ToString()
        {
            return this.kategoria+" "+this.helyesValaszok+" "+this.kerdes;
        }



    }
}
