using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaradjTalpon
{
    static class Program
    {

        public static Form belepoForm = null;
        public static Form Form2 = null;
        public static Form foablak = null;
        public static Form parbaj = null;
        public static string fo_jatekos_nev;
        public static string fo_jatekos_lakhely;
       // public static int PasszolasiLehetosegek;
        [STAThread]
        static void Main()
        {
            List<int> valaszadasok = new List<int>();
            //try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                belepoForm = new MaradjTalponAlkalmazas();
                Form2 = new Form2();
                //foablak = new Form3();
                //parbaj = new Form4();
                
                Application.Run(belepoForm);
            }
            /*catch (Exception)
            {
                MessageBox.Show("Hiba az adatbázis kapcsolódásakor!");
            }*/
        }
    }
}
