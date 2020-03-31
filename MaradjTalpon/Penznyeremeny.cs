using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaradjTalpon
{
    class Penznyeremeny
    {
        public static Random rand = new Random();

        public void penzhozzaad()
        {
            int szazft1 = 100, szazft2 = 100, szazhuszonotezerft1 = 125000, szazhuszonotezerft2 = 125000, ketszazotvenezerft1 = 250000, ketszazotvenezerft2 = 250000, otszazezerft1 = 500000, otszazezerft2 = 500000, egymillioft1 = 1000000, egymillioft2 = 1000000;
            penznyeremenyek.Add(szazft1);
            penznyeremenyek.Add(szazft2);
            penznyeremenyek.Add(szazhuszonotezerft1);
            penznyeremenyek.Add(szazhuszonotezerft2);
            penznyeremenyek.Add(ketszazotvenezerft1);
            penznyeremenyek.Add(ketszazotvenezerft2);
            penznyeremenyek.Add(otszazezerft1);
            penznyeremenyek.Add(otszazezerft2);
            penznyeremenyek.Add(egymillioft1);
            penznyeremenyek.Add(egymillioft2);

            rand(Convert.ToInt32(penznyeremenyek));
        }
    }
}
