using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaradjTalpon
{
    class Fo_jatekos
    {
        int id;
        string nev;
        string lakhely;

        public Fo_jatekos(int id, string nev, string lakhely)
        {
            this.Id = id;
            this.Nev = nev;
            this.Lakhely = lakhely;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Lakhely { get => lakhely; set => lakhely = value; }
    }
}
