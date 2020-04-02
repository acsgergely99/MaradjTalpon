using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace MaradjTalpon
{
    public partial class Form4 : Form
    {

        Timer timer = new Timer();
        public int quick = 1200;
        public int quick2 = 300;
        public int quick3 = 3000;

        public static int penzNyeremeny;
        public Random random = new Random();
        public Random random2 = new Random();
        public string betu = "";
        KerdesBeolvasas BEOLVAS = new KerdesBeolvasas();
        private int hanysor;
        public int adottValasz;

        public bool tippeltunk = false;
        public bool buul = false;
        public bool buul2 = false;

        public Form4(string PasszolasiLehetoseg)
        {

            InitializeComponent();
           
            hanysor = random.Next(0, 5000);
            szoveg();
            ParbajPasszTextBox.Text = PasszolasiLehetoseg;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1; //1second           
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }
        private void t_Tick(object sender, EventArgs e)
        {
            quick--;
            quick2--;
            Ido.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            if (Ido.Text == "0:00")
            {
                t.Stop();
                if (ParbajPasszTextBox.Text == "2")
                {
                    ParbajPasszTextBox.Text = "1";
                    Form3.passzLehetosegek = "1";
                    hanysor = random.Next(0, 5000);
                    szoveg();
                    quick = 1200;
                    t.Start();
                    if (buul)
                    {
                        ParbajPasszTextBox.Text = "2";
                        Form3.passzLehetosegek = "2";
                    }
                }
                else if (ParbajPasszTextBox.Text == "1")
                {
                    ParbajPasszTextBox.Text = "0";
                    Form3.passzLehetosegek = "0";
                    hanysor = random.Next(0, 5000);
                    szoveg();
                    quick = 1200;
                    t.Start();
                    if (buul)
                    {
                        ParbajPasszTextBox.Text = "1";
                        Form3.passzLehetosegek = "1";
                    }
                }
                else if (ParbajPasszTextBox.Text == "0")
                {                  
                    if (buul)
                    {
                        ParbajPasszTextBox.Text = "0";
                        Form3.passzLehetosegek = "0";
                    }
                    else
                    {
                        ujJatek();
                    }
                }
            }
            else if (tippeltunk)
            {
                if (quick2 == 0)
                {
                    joValasz();
                }
            }
        }
        public void szoveg()
        {
            try
            {
                KerdesekLabel.Text = BEOLVAS.getKerdes(hanysor);
                ValaszlehetosegGomb1.Text = BEOLVAS.Valasz1(hanysor);
                ValaszlehetosegGomb2.Text = BEOLVAS.Valasz2(hanysor);
                ValaszlehetosegGomb3.Text = BEOLVAS.Valasz3(hanysor);
                ValaszlehetosegGomb4.Text = BEOLVAS.Valasz4(hanysor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void szoveg2()
        {
            ValaszlehetosegGomb1.BackColor = Color.White;
            ValaszlehetosegGomb2.BackColor = Color.White;
            ValaszlehetosegGomb3.BackColor = Color.White;
            ValaszlehetosegGomb4.BackColor = Color.White;
        }

        public void joValasz()
        {
            string helyes = BEOLVAS.helyesValasz(hanysor);
            if (helyes.Equals(betu))
            {
                buul = true;
                if (betu == "A")
                {
                    ValaszlehetosegGomb1.BackColor = Color.Green;
                }
                else if (betu == "B")
                {
                    ValaszlehetosegGomb2.BackColor = Color.Green;
                }
                else if (betu == "C")
                {
                    ValaszlehetosegGomb3.BackColor = Color.Green;
                }
                else if (betu == "D")
                {
                    ValaszlehetosegGomb4.BackColor = Color.Green;
                }
                t.Stop();                
                DialogResult result = MessageBox.Show("Gratulálok jól tippeltél a nyereményed " + Form3.penznyeremeny, "" ,MessageBoxButtons.OK);
                Form3.eddigMegnyert.Add(Form3.penznyeremeny);               
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Program.foablak = new Form3(Program.fo_jatekos_nev, Program.fo_jatekos_lakhely);
                    Program.foablak.Show();
                }
            }
            else
            {
                if (helyes == "A")
                {
                    ValaszlehetosegGomb1.BackColor = Color.Green;
                    HelytelenValasz();
                }
                else if (helyes == "B")
                {
                    ValaszlehetosegGomb2.BackColor = Color.Green;
                    HelytelenValasz();

                }
                else if (helyes == "C")
                {
                    ValaszlehetosegGomb3.BackColor = Color.Green;
                    HelytelenValasz();
                }
                else if (helyes == "D")
                {
                    ValaszlehetosegGomb4.BackColor = Color.Green;
                    HelytelenValasz();
                }
            }
        }
        private void ValaszlehetosegGomb1_Click(object sender, EventArgs e)
        {
            //t.Stop();
            tippeltunk = true;
            betu = "A";

            ValaszlehetosegGomb1.BackColor = Color.Orange;
            ValaszlehetosegGomb2.Enabled = false;
            ValaszlehetosegGomb2.BackColor = Color.White;
            ValaszlehetosegGomb1.Enabled = false;
            ValaszlehetosegGomb3.BackColor = Color.White;
            ValaszlehetosegGomb3.Enabled = false;
            ValaszlehetosegGomb4.BackColor = Color.White;
            ValaszlehetosegGomb4.Enabled = false;

            quick = 180;
            quick2 = 130;

        }

        private void ValaszlehetosegGomb2_Click(object sender, EventArgs e)
        {
            //t.Stop();
            tippeltunk = true;
            betu = "B";

            ValaszlehetosegGomb1.BackColor = Color.White;
            ValaszlehetosegGomb2.Enabled = false;
            ValaszlehetosegGomb2.BackColor = Color.Orange;
            ValaszlehetosegGomb1.Enabled = false;
            ValaszlehetosegGomb3.BackColor = Color.White;
            ValaszlehetosegGomb3.Enabled = false;
            ValaszlehetosegGomb4.BackColor = Color.White;
            ValaszlehetosegGomb4.Enabled = false;

            quick = 180;
            quick2 = 130;

        }

        private void ValaszlehetosegGomb3_Click(object sender, EventArgs e)
        {
            //t.Stop();
            tippeltunk = true;
            betu = "C";

            ValaszlehetosegGomb1.BackColor = Color.White;
            ValaszlehetosegGomb2.Enabled = false;
            ValaszlehetosegGomb2.BackColor = Color.White;
            ValaszlehetosegGomb1.Enabled = false;
            ValaszlehetosegGomb3.BackColor = Color.Orange;
            ValaszlehetosegGomb3.Enabled = false;
            ValaszlehetosegGomb4.BackColor = Color.White;
            ValaszlehetosegGomb4.Enabled = false;

            quick = 180;
            quick2 = 130;

        }

        private void ValaszlehetosegGomb4_Click(object sender, EventArgs e)
        {
            //t.Stop();
            tippeltunk = true;
            betu = "D";

            ValaszlehetosegGomb1.BackColor = Color.White;
            ValaszlehetosegGomb2.Enabled = false;
            ValaszlehetosegGomb2.BackColor = Color.White;
            ValaszlehetosegGomb1.Enabled = false;
            ValaszlehetosegGomb3.BackColor = Color.White;
            ValaszlehetosegGomb3.Enabled = false;
            ValaszlehetosegGomb4.BackColor = Color.Orange;
            ValaszlehetosegGomb4.Enabled = false;

            quick = 180;
            quick2 = 130;

        }
       
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void KilepesButton_Click(object sender, EventArgs e)
        {
            Program.belepoForm.Close();
            Close();
        }

        private void PasszButton_Click(object sender, EventArgs e)
        {
            if (ParbajPasszTextBox.Text == "2")
            {
                Form3.passzLehetosegek = "1";
                ParbajPasszTextBox.Text = "1";
                hanysor = random.Next(0, 5000);
                szoveg();
                quick = 1200;
            }
            else if (ParbajPasszTextBox.Text == "1")
            {
                Form3.passzLehetosegek = "0";
                ParbajPasszTextBox.Text = "0";
                hanysor = random.Next(0, 5000);
                szoveg();
                quick = 1200;
            }
            else if (ParbajPasszTextBox.Text == "0")
            {
                t.Stop();
                DialogResult result = MessageBox.Show("Elfogytak a passzolási lehetőségeid", "", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    t.Start();
                }
            }
        }
        public void HelytelenValasz()
        {
            t.Stop();
            if (ParbajPasszTextBox.Text != "0")
            {
                DialogResult result = MessageBox.Show("Nem adtál jó választ a kérdésre ezért elvesztetted egy passz lehetőséged,jöhet a következő kérdés?", "", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    quick = 1200;
                    t.Start();
                    ValaszlehetosegGomb1.BackColor = Color.Blue;
                    ValaszlehetosegGomb2.Enabled = true;
                    ValaszlehetosegGomb2.BackColor = Color.Blue;
                    ValaszlehetosegGomb1.Enabled = true;
                    ValaszlehetosegGomb3.BackColor = Color.Blue;
                    ValaszlehetosegGomb3.Enabled = true;
                    ValaszlehetosegGomb4.BackColor = Color.Blue;
                    ValaszlehetosegGomb4.Enabled = true;
                    hanysor = random.Next(0, 5000);
                    szoveg();
                    valt();
                }
            }
            else if (ParbajPasszTextBox.Text == "0")
            {
                ujJatek();
            }
        }
        public void valt()
        {
            if (ParbajPasszTextBox.Text == "2")
            {
                ParbajPasszTextBox.Text = "1";
                Form3.passzLehetosegek = "1";

            }
            else if (ParbajPasszTextBox.Text == "1")
            {
                ParbajPasszTextBox.Text = "0";
                Form3.passzLehetosegek = "0";
            }
           
        }
        public void ujJatek()
        {
            quick = 0;
            t.Stop();
            DialogResult result = MessageBox.Show("Passzlehetőség nélkül lejárt az időd vagy rosszul válaszoltál a kérdésre, ezért vesztettél.", "Szeretnél új játékot kezdeni?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Program.foablak.Close();
                this.Close();
                Form3.passzLehetosegek = "2";
                Form3.penznyeremeny = 0;
                Program.foablak = new Form3(Program.fo_jatekos_nev, Program.fo_jatekos_lakhely);
                Program.foablak.Show();
                
            }
            else 
            {
                Program.belepoForm.Close();
                Close();
            }
        }
        //public void Osszegek()
        //{
        //    penznyeremenyek.Add(100);
        //    penznyeremenyek.Add(100);

        //    penzNyeremenyek.Add(125000);
        //    penzNyeremenyek.Add(125000);
        //    penzNyeremenyek.Add(125000);
        //    penzNyeremenyek.Add(250000);
        //    penzNyeremenyek.Add(250000);
        //    penzNyeremenyek.Add(500000);
        //    penzNyeremenyek.Add(500000);
        //    penzNyeremenyek.Add(1000000);
        //    penzNyeremenyek.Add(1000000);
     
        //}


    }
}