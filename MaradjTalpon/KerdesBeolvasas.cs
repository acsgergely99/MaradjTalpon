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
        public static List<int>[] kategoriaTomb = new List<int>[20];
        public static Random rand;
        public string[] tomb;

        internal List<Kerdesek> Kerd { get => kerd; set => kerd = value; }

        public KerdesBeolvasas()
        {
           Kerd = Beolvas();
         
        }

        public List<Kerdesek> Beolvas()
        {

            for (int i = 0; i < 20; i++)
            {
                kategoriaTomb[i] = new List<int>();
            }


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
                Pakolgat(kategoriAA, txt.Count);

            }
            return txt;
        }

        private void Pakolgat(String kategoria, int listahossz)
        {
            if(kategoria == "BIOLÓGIA")
            {
                kategoriaTomb[0].Add(listahossz-1);
            }
            else if (kategoria == "NYELV")
            {
                kategoriaTomb[1].Add(listahossz - 1);
            }
            else if (kategoria == "SPORT")
            {
                kategoriaTomb[2].Add(listahossz - 1);
            }
            else if (kategoria == "FILM")
            {
                kategoriaTomb[3].Add(listahossz - 1);
            }
            else if (kategoria == "TECHNIKA")
            {
                kategoriaTomb[4].Add(listahossz - 1);
            }
            else if (kategoria == "ÁLTALÁNOS")
            {
                kategoriaTomb[5].Add(listahossz - 1);
            }
            else if (kategoria == "IRODALOM")
            {
                kategoriaTomb[6].Add(listahossz - 1);
            }
            else if (kategoria == "ZENE")
            {
                kategoriaTomb[7].Add(listahossz - 1);
            }
            else if (kategoria == "MAGYARORSZÁG")
            {
                kategoriaTomb[8].Add(listahossz - 1);
            }
            else if (kategoria == "KONYHA")
            {
                kategoriaTomb[9].Add(listahossz - 1);
            }
            else if (kategoria == "TUDOMÁNY")
            {
                kategoriaTomb[10].Add(listahossz - 1);
            }
            else if (kategoria == "KÉPZŐMŰVÉSZET")
            {
                kategoriaTomb[11].Add(listahossz - 1);
            }
            else if (kategoria == "TÖRTÉNELEM")
            {
                kategoriaTomb[12].Add(listahossz - 1);
            }
            else if (kategoria == "VALLÁS")
            {
                kategoriaTomb[13].Add(listahossz - 1);
            }
            else if (kategoria == "JÁTÉK")
            {
                kategoriaTomb[14].Add(listahossz - 1);
            }
            else if (kategoria == "ORSZÁGOK")
            {
                kategoriaTomb[15].Add(listahossz - 1);
            }
            else if (kategoria == "SZÍNHÁZ")
            {
                kategoriaTomb[16].Add(listahossz - 1);
            }
            else if (kategoria == "OPERA")
            {
                kategoriaTomb[17].Add(listahossz - 1);
            }
            else if (kategoria == "ÉPÍTÉSZET")
            {
                kategoriaTomb[18].Add(listahossz - 1);
            }
            else if (kategoria == "FÖLDRAJZ")
            {
                kategoriaTomb[19].Add(listahossz - 1);
            }
        }


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
