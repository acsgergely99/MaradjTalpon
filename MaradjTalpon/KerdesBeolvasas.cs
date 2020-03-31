using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaradjTalpon
{
    class KerdesBeolvasas
    {
   
       
        public static List<Kerdesek> kerd;
        public static Random rand;
        public string[] tomb;

        internal List<Kerdesek> Kerd { get => kerd; set => kerd = value; }

        public KerdesBeolvasas()
        {
           Kerd= Beolvas();
        }


        public List<Kerdesek> Beolvas()
        {
            List<Kerdesek> txt = new List<Kerdesek>();
            StreamReader sr = new StreamReader("kerdes.txt", Encoding.UTF8);
            Kerdesek k;
            int kerdesNehezseg;
            string kerdes, helyesValasz, kategoriAA;
            // tomb = sr.ReadToEnd().Split('\n');
            while (!sr.EndOfStream)
            { 
                string[] sor =sr.ReadLine().Split(';');
                Console.WriteLine(sor);
                List<string> valaszlehetosegek = new List<string>();
                valaszlehetosegek.Add(sor[2]);
                valaszlehetosegek.Add(sor[3]);
                valaszlehetosegek.Add(sor[4]);
                valaszlehetosegek.Add(sor[5]);
                kerdesNehezseg = int.Parse(sor[0]);
                kerdes = sor[1];
                helyesValasz = sor[6];
                kategoriAA = sor[7];
                string[] valaszok = valaszlehetosegek.ToArray();
                k = new Kerdesek(kerdesNehezseg, kerdes, valaszok, helyesValasz, kategoriAA);
                txt.Add(k);
            }
            return txt;
        }
      /*  public int SorHozzaad(int veletlen)
        {
            
            return rand.Next(0,4999);
        }*/
        public string getKerdes(int sor)
        {
            string kerdes = "";
            kerdes = Kerd[sor].Kerdes;
            return kerdes;
        }
        public string Valasz1(int sor)
        {
            string valasz1 = "";
            valasz1 = Kerd[sor].Valaszok[0];
            return valasz1;
        }
        public string Valasz2(int sor)
        {
            string valasz2 = "";
            valasz2 = Kerd[sor].Valaszok[1];
            return valasz2;
        }
        public string Valasz3(int sor)
        {
            string valasz3 = "";
            valasz3 = Kerd[sor].Valaszok[2];
            return valasz3;
        }
        public string Valasz4(int sor)
        {
            string valasz4 = "";
            valasz4 = Kerd[sor].Valaszok[3];
            return valasz4;
        }
        public string helyesValasz(int sor)
        {
            string valasz = "";
            valasz = Kerd[sor].HelyesValaszok;
            return valasz;
        }
        public string Kategoriak(int sor)
        {
            string kategoria = "";
            kategoria = Kerd[sor].Kategoria;
            return kategoria;
        }
    }
}
