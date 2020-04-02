using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaradjTalpon
{
    class Nyeremeny
    {
        private List<string> nyeremenyek = new List<string>();

        public List<string> Nyeremenyek { get => nyeremenyek; set => nyeremenyek = value; }

        public void szamok()
        {
            //string[] szamok = new string[10];
            //szamok[0] = Convert.ToString(100);
            //szamok[1] = Convert.ToString(100);
            //szamok[2] = Convert.ToString(125000);
            //szamok[3] = Convert.ToString(125000);
            //szamok[4] = Convert.ToString(250000);
            //szamok[5] = Convert.ToString(250000);
            //szamok[6] = Convert.ToString(500000);
            //szamok[7] = Convert.ToString(500000);
            //szamok[8] = Convert.ToString(1000000);
            //szamok[9] = Convert.ToString(1000000);
            //szamok.Add(nyeremenyek);
            string szazFT = "100", szazFT2 = "100";
            string szazhuszonotezerFT = "125 000", szazhuszonotezerFT2 = "125 000";
            string ketszazotvenezerFT = "250 000", ketszazotvenezerFT2 = "250 000";
            string otszazezerFT = "500 000", otszazezerFT2 = "500 000";
            string egymillioFT = "1 000 000", egymillioFT2 = "1 000 000";
            Nyeremenyek.Add(szazFT + szazFT2 + szazhuszonotezerFT + szazhuszonotezerFT2 + ketszazotvenezerFT + ketszazotvenezerFT2 + otszazezerFT + otszazezerFT2 + egymillioFT + egymillioFT2);
        }
    }
}
