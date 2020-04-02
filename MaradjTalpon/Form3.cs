using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace MaradjTalpon
{

    public partial class Form3 : Form
    {
        MySqlConnection conn;
        //static List<Kerdesek> txtKerdesek;
        public static string passzLehetosegek = "2";
        public static List<int> eddigMegnyert = new List<int>();
        public static List<int> penznyeremenyek = new List<int>();
        public static int penznyeremeny = 0;
        private int nyeremenyindex;
        KerdesBeolvasas beOlvasClass = new KerdesBeolvasas();
        private static List<Kerdesek> kerdesekClass = new List<Kerdesek>();
        public static bool indexertek = false;
        public static string ert = "";

        Random random = new Random();
        public Form3(string uj_jatekos,string uj_lakhely)
        {            
            InitializeComponent();
            Osszegek();
            ertek();
            conn = new MySqlConnection("Server=localhost; Port=3306; Database=maradj_talpon; Uid=root; Pwd=;");
            conn.Open();
            FoJatekosTextBox.Text = uj_jatekos;
            JatekosLakhelyTextBox.Text = uj_lakhely;
            PasszolasiLehetosegTextBox.Text = passzLehetosegek;
            PenznyeremenyTextBox.Text = eddigiOsszeg()+"";
            Refresh();
        }

        public void PasszolasiLehetosegTextBox_TextChanged(object sender, EventArgs e)
        {
            int passz = Convert.ToInt32(PasszolasiLehetosegTextBox.Text);
            if (passz > 0)
            {
                passz--;
                PasszolasiLehetosegTextBox.Text = passzLehetosegek;
            }
            //string passz = "2";
            //MaradjTalpon.Passzolas.passzolasiLehetoseg = passz;
            //passz = Convert.ToString(passzLehetosegek);
            //passzLehetosegek = PasszolasiLehetosegTextBox.Text;           
        }
        public void PenznyeremenyTextBox_TextChanged(object sender, EventArgs e)
        {          
            PenznyeremenyTextBox.Text = eddigiOsszeg()+"";
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

        public List<int> Penznyeremenyek { get => penznyeremenyek; set => penznyeremenyek = value; }

        public string KategoriaChoose(string kivalasztottKategoria)
        {
            foreach (var item in KerdesBeolvasas.kerd)
            {
                if (item.Kategoria == "BIOLÓGIA" && BioszRadioButton.Checked)
                {
                    if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
                    {
                        KategoriaGroupBox.Enabled = false;
                    }
                    kivalasztottKategoria = item.Kategoria;
                    return item.Kategoria;
                }
            }
            return kivalasztottKategoria;
        }
        private void Button_Jatekos1_Click(object sender, EventArgs e)
        {
            ert = "1";
            indexertek = true;
            this.Hide();
            Button_Jatekos1.BackColor = Color.Green;
            Button_Jatekos1.Enabled = false;
           // Form3.passzLehetosegek =PasszolasiLehetosegTextBox.Text;
            Form4 ujform = new Form4(Form3.passzLehetosegek);
            nyeremenyindex = random.Next(0, penznyeremenyek.Count);
            penznyeremeny = penznyeremenyek[nyeremenyindex];
            ujform.ShowDialog();
            if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
            {
                KategoriaGroupBox.Enabled = false;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);

        }
        private void Button_Jatekos2_Click(object sender, EventArgs e)
        {
            ert = "2";
            indexertek = true;
            this.Hide();
            Button_Jatekos2.BackColor = Color.Green;
            Button_Jatekos2.Enabled = false;
           // Form3.passzLehetosegek = PasszolasiLehetosegTextBox.Text;
            Form4 ujform = new Form4(Form3.passzLehetosegek);
            nyeremenyindex = random.Next(0, penznyeremenyek.Count);
            penznyeremeny = penznyeremenyek[nyeremenyindex];
            ujform.ShowDialog();
            if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
            {
                KategoriaGroupBox.Enabled = false;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos3_Click(object sender, EventArgs e)
        {
            ert = "3";
            indexertek = true;
            this.Hide();
            Button_Jatekos3.BackColor = Color.Green;
            Button_Jatekos3.Enabled = false;
           // Form3.passzLehetosegek = PasszolasiLehetosegTextBox.Text;
            Form4 ujform = new Form4(Form3.passzLehetosegek);
            nyeremenyindex = random.Next(0, penznyeremenyek.Count);
            penznyeremeny = penznyeremenyek[nyeremenyindex];
            ujform.ShowDialog();
            if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
            {
                KategoriaGroupBox.Enabled = false;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos4_Click(object sender, EventArgs e)
        {
            ert = "4";
            indexertek = true;
            this.Hide();
            Button_Jatekos4.BackColor = Color.Green;
            Button_Jatekos4.Enabled = false;
         //   Form3.passzLehetosegek = PasszolasiLehetosegTextBox.Text;
            Form4 ujform = new Form4(Form3.passzLehetosegek);
            nyeremenyindex = random.Next(0, penznyeremenyek.Count);
            penznyeremeny = penznyeremenyek[nyeremenyindex];
            ujform.ShowDialog();
            if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
            {
                KategoriaGroupBox.Enabled = false;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos5_Click(object sender, EventArgs e)
        {
            ert = "5";
            indexertek = true;
            this.Hide();
            Button_Jatekos5.BackColor = Color.Green;
            Button_Jatekos5.Enabled = false;
          //  Form3.passzLehetosegek = PasszolasiLehetosegTextBox.Text;
            Form4 ujform = new Form4(Form3.passzLehetosegek);
            nyeremenyindex = random.Next(0, penznyeremenyek.Count);
            penznyeremeny = penznyeremenyek[nyeremenyindex];
            ujform.ShowDialog();
            if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
            {
                KategoriaGroupBox.Enabled = false;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos6_Click(object sender, EventArgs e)
        {
            ert = "6";
            indexertek = true;
            this.Hide();
            Button_Jatekos6.BackColor = Color.Green;
            Button_Jatekos6.Enabled = false;
         //   Form3.passzLehetosegek = PasszolasiLehetosegTextBox.Text;
            Form4 ujform = new Form4(Form3.passzLehetosegek);
            nyeremenyindex = random.Next(0, penznyeremenyek.Count);
            penznyeremeny = penznyeremenyek[nyeremenyindex];
            ujform.ShowDialog();
            if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
            {
                KategoriaGroupBox.Enabled = false;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos7_Click(object sender, EventArgs e)
        {
            ert = "7";
            indexertek = true;
            this.Hide();
            Button_Jatekos7.BackColor = Color.Green;
            Button_Jatekos7.Enabled = false;
         //   Form3.passzLehetosegek = PasszolasiLehetosegTextBox.Text;
            Form4 ujform = new Form4(Form3.passzLehetosegek);
            nyeremenyindex = random.Next(0, penznyeremenyek.Count);
            penznyeremeny = penznyeremenyek[nyeremenyindex];
            ujform.ShowDialog();
            if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
            {
                KategoriaGroupBox.Enabled = false;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos8_Click(object sender, EventArgs e)
        {
            ert = "8";
            indexertek = true;
            this.Hide();
            Button_Jatekos8.BackColor = Color.Green;
            Button_Jatekos8.Enabled = false;
        //    Form3.passzLehetosegek = PasszolasiLehetosegTextBox.Text;
            Form4 ujform = new Form4(Form3.passzLehetosegek);
            nyeremenyindex = random.Next(0, penznyeremenyek.Count);
            penznyeremeny = penznyeremenyek[nyeremenyindex];
            ujform.ShowDialog();
            if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
            {
                KategoriaGroupBox.Enabled = false;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos9_Click(object sender, EventArgs e)
        {
            ert = "9";
            indexertek = true;
            this.Hide();
            Button_Jatekos9.BackColor = Color.Green;
            Button_Jatekos9.Enabled = false;
         //   Form3.passzLehetosegek = PasszolasiLehetosegTextBox.Text;
            Form4 ujform = new Form4(Form3.passzLehetosegek);
            nyeremenyindex = random.Next(0, penznyeremenyek.Count);
            penznyeremeny = penznyeremenyek[nyeremenyindex];
            ujform.ShowDialog();
            if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
            {
                KategoriaGroupBox.Enabled = false;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos10_Click(object sender, EventArgs e)
        {
            ert = "10";
            indexertek = true;
            this.Hide();
            Button_Jatekos10.BackColor = Color.Green;
            Button_Jatekos10.Enabled = false;
        //    Form3.passzLehetosegek = PasszolasiLehetosegTextBox.Text;
            Form4 ujform = new Form4(Form3.passzLehetosegek);
            nyeremenyindex = random.Next(0, penznyeremenyek.Count);
            penznyeremeny = penznyeremenyek[nyeremenyindex];
            ujform.ShowDialog();
            if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
            {
                KategoriaGroupBox.Enabled = false;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);

        }

        private void KilepesButton_Click(object sender, EventArgs e)
        {
            Program.belepoForm.Close();
            Close();
        }

        private void KategoriaGroupBox_Enter(object sender, EventArgs e)
        {

        }
        public void Osszegek()
        {
            penznyeremenyek.Add(100);
            penznyeremenyek.Add(100);
            penznyeremenyek.Add(125000);
            penznyeremenyek.Add(125000);
            penznyeremenyek.Add(125000);
            penznyeremenyek.Add(250000);
            penznyeremenyek.Add(250000);
            penznyeremenyek.Add(500000);
            penznyeremenyek.Add(500000);
            penznyeremenyek.Add(1000000);
            penznyeremenyek.Add(1000000);

        }

        private int eddigiOsszeg()
        {
            return eddigMegnyert.Sum();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        public void ertek()
        {
            if (indexertek == true && ert == "1")
            {
                Button_Jatekos1.BackColor = Color.Green;
                Button_Jatekos1.Enabled = false;
            }
            if (indexertek == true && ert == "2")
            {
                Button_Jatekos2.BackColor = Color.Green;
                Button_Jatekos2.Enabled = false;
            }
            if (indexertek == true && ert == "3")
            {
                Button_Jatekos3.BackColor = Color.Green;
                Button_Jatekos3.Enabled = false;
            }
            if (indexertek == true && ert == "4")
            {
                Button_Jatekos4.BackColor = Color.Green;
                Button_Jatekos4.Enabled = false;
            }
            if (indexertek == true && ert == "5")
            {
                Button_Jatekos5.BackColor = Color.Green;
                Button_Jatekos5.Enabled = false;
            }
            if (indexertek == true && ert == "6")
            {
                Button_Jatekos6.BackColor = Color.Green;
                Button_Jatekos6.Enabled = false;
            }
            if (indexertek == true && ert == "7")
            {
                Button_Jatekos7.BackColor = Color.Green;
                Button_Jatekos7.Enabled = false;
            }
            if (indexertek == true && ert == "8")
            {
                Button_Jatekos8.BackColor = Color.Green;
                Button_Jatekos8.Enabled = false;
            }
            if (indexertek == true && ert == "9")
            {
                Button_Jatekos9.BackColor = Color.Green;
                Button_Jatekos9.Enabled = false;
            }
            if (indexertek == true && ert == "10")
            {
                Button_Jatekos10.BackColor = Color.Green;
                Button_Jatekos10.Enabled = false;
            }
        }
    }      
}
/*public List<Kerdesek> kerdesKivalaszto()
        {
            int randomSzam = rand.Next(0, osszKerdesek.Count);
            while (osszKerdesek[randomSzam].Votma == true && osszKerdesek[randomSzam].Nehezseg != 1)        
        }*/
