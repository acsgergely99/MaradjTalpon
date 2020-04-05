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
        Random random = new Random();
        KerdesBeolvasas beOlvasClass = new KerdesBeolvasas();
        private static List<Kerdesek> kerdesekClass = new List<Kerdesek>();
        public static List<bool> indexertekek = new List<bool>();
        public static string ert = "";
        public static bool indexertek = false;
        public static int max2 = 0;
        public static int nyertMeccsek;

        public static int ertekatad;
        public static List<string> szamindex = new List<string>();
        public List<Button> gombLista = new List<Button>();
        public static int valtozoSzam;

        public Form3(string uj_jatekos, string uj_lakhely)
        {
            InitializeComponent();
            Osszegek();

            conn = new MySqlConnection("Server=localhost; Port=3306; Database=maradj_talpon; Uid=root; Pwd=;");
            conn.Open();
            FoJatekosTextBox.Text = uj_jatekos;
            JatekosLakhelyTextBox.Text = uj_lakhely;
            PasszolasiLehetosegTextBox.Text = passzLehetosegek;
            PenznyeremenyTextBox.Text = eddigiOsszeg() + "";
            KategoriaChoose();
            kategoriaLetilt();
            probaGomb();

            segito();
            megNyerted();
        }

        public void PasszolasiLehetosegTextBox_TextChanged(object sender, EventArgs e)
        {
            int passz = Convert.ToInt32(PasszolasiLehetosegTextBox.Text);
            if (passz > 0)
            {
                passz--;
                PasszolasiLehetosegTextBox.Text = passzLehetosegek;
            }       
        }
        public void PenznyeremenyTextBox_TextChanged(object sender, EventArgs e)
        {
            PenznyeremenyTextBox.Text = eddigiOsszeg() + "";
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

        private void Button_Jatekos1_Click(object sender, EventArgs e)
        {
            KategoriaChoose();
            ert = "1";
            szamindex.Add(ert);
            this.Hide();
            Button_Jatekos1.BackColor = Color.Green;
            Button_Jatekos1.Enabled = false;
            // Form3.passzLehetosegek =PasszolasiLehetosegTextBox.Text;
            Form4 ujform = new Form4(Form3.passzLehetosegek);
            nyeremenyindex = random.Next(0, penznyeremenyek.Count);
            penznyeremeny = penznyeremenyek[nyeremenyindex];
            indexertek = true;
            ujform.ShowDialog();
            if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
            {
                max2++;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }
        private void Button_Jatekos2_Click(object sender, EventArgs e)
        {
            KategoriaChoose();
            ert = "2";
            szamindex.Add(ert);
            this.Hide();
            Button_Jatekos2.BackColor = Color.Green;
            Button_Jatekos2.Enabled = false;
            // Form3.passzLehetosegek = PasszolasiLehetosegTextBox.Text;
            Form4 ujform = new Form4(Form3.passzLehetosegek);
            nyeremenyindex = random.Next(0, penznyeremenyek.Count);
            penznyeremeny = penznyeremenyek[nyeremenyindex];
            indexertek = true;
            ujform.ShowDialog();
            if (BioszRadioButton.Checked || ToriRadioButton.Checked || NyelvRadioButton.Checked || SportRadioButton.Checked || MagyarorszagRadioButton.Checked || TechnikaRadioButton.Checked || FilmRadioButton.Checked || JatekRadioButton.Checked || OrszagokRadioButton.Checked || FoldrajzRadioButton.Checked || AltalanosRadioButton.Checked || IrodalomRadioButton.Checked || ZeneRadioButton.Checked || TudomanyRadioButton.Checked || KonyhaRadioButton.Checked || KepzomuveszetRadioButton.Checked || VallasRadioButton.Checked || EpiteszetRadioButton.Checked || SzinhazRadioButton.Checked || OperaRadioButton.Checked)
            {
                max2++;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);

        }

        private void Button_Jatekos3_Click(object sender, EventArgs e)
        {
            KategoriaChoose();
            ert = "3";
            szamindex.Add(ert);
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
                max2++;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos4_Click(object sender, EventArgs e)
        {
            KategoriaChoose();
            ert = "4";
            szamindex.Add(ert);
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
                max2++;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos5_Click(object sender, EventArgs e)
        {
            KategoriaChoose();
            ert = "5";
            szamindex.Add(ert);
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
                max2++;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos6_Click(object sender, EventArgs e)
        {
            KategoriaChoose();
            ert = "6";
            szamindex.Add(ert);
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
                max2++;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos7_Click(object sender, EventArgs e)
        {
            KategoriaChoose();
            ert = "7";
            szamindex.Add(ert);
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
                max2++;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos8_Click(object sender, EventArgs e)
        {
            KategoriaChoose();
            ert = "8";
            szamindex.Add(ert);
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
                max2++;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos9_Click(object sender, EventArgs e)
        {
            KategoriaChoose();
            ert = "9";
            szamindex.Add(ert);
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
                max2++;
            }
            penznyeremenyek.RemoveAt(nyeremenyindex);
        }

        private void Button_Jatekos10_Click(object sender, EventArgs e)
        {
            KategoriaChoose();
            ert = "10";
            szamindex.Add(ert);
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
                max2++;
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

        public void KategoriaChoose()
        {
            foreach (var item in KerdesBeolvasas.kerd)
            {
                if (BioszRadioButton.Checked)
                {
                    item.Kategoria = "BIOLÓGIA";  
                    
                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[0].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[0][val];
                }
                else if (NyelvRadioButton.Checked)
                {
                    item.Kategoria = "NYELV";   
                    
                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[1].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[1][val];
                }
                else if (SportRadioButton.Checked)
                {
                    item.Kategoria = "SPORT";  
                    
                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[2].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[2][val];
                }
                else if (FilmRadioButton.Checked)
                {
                    item.Kategoria = "FILM";     
                    
                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[3].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[3][val];
                }
                else if (TechnikaRadioButton.Checked)
                {
                    item.Kategoria = "TECHNIKA";
                    
                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[4].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[4][val];
                }
                else if (AltalanosRadioButton.Checked)
                {
                    item.Kategoria = "ÁLTALÁNOS";   
                    
                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[5].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[5][val];
                }
                else if (IrodalomRadioButton.Checked)
                {
                    item.Kategoria = "IRODALOM";   
                    
                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[6].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[6][val];
                }
                else if (ZeneRadioButton.Checked)
                {
                    item.Kategoria = "ZENE";    
                    
                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[7].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[7][val];
                }
                else if (MagyarorszagRadioButton.Checked)
                {
                    item.Kategoria = "MAGYARORSZÁG";   
                    
                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[8].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[8][val];
                }
                else if (KonyhaRadioButton.Checked)
                {
                    item.Kategoria = "KONYHA";
                    
                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[9].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[9][val];
                }
                else if (TudomanyRadioButton.Checked)
                {
                    item.Kategoria = "TUDOMÁNY";

                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[10].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[10][val];
                }
                else if (KepzomuveszetRadioButton.Checked)
                {
                    item.Kategoria = "KÉPZŐMŰVÉSZET";

                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[11].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[11][val];
                }
                else if (ToriRadioButton.Checked)
                {
                    item.Kategoria = "TÖRTÉNELEM";

                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[12].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[12][val];
                }
                else if (VallasRadioButton.Checked)
                {
                    item.Kategoria = "VALLÁS";

                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[13].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[13][val];
                }
                else if (JatekRadioButton.Checked)
                {
                    item.Kategoria = "JÁTÉK";

                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[14].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[14][val];
                }
                else if (OrszagokRadioButton.Checked)
                {
                    item.Kategoria = "ORSZÁGOK";

                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[15].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[15][val];
                }
                else if (SzinhazRadioButton.Checked)
                {
                    item.Kategoria = "SZÍNHÁZ";

                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[16].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[16][val];
                }
                else if (OperaRadioButton.Checked)
                {
                    item.Kategoria = "OPERA";

                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[17].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[17][val];
                }
                else if (EpiteszetRadioButton.Checked)
                {
                    item.Kategoria = "ÉPÍTÉSZET";

                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[18].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[18][val];
                }
                else if (FoldrajzRadioButton.Checked)
                {
                    item.Kategoria = "FÖLDRAJZ";

                    int val = random.Next(0, KerdesBeolvasas.kategoriaTomb[19].Count);
                    Form4.hanysor = KerdesBeolvasas.kategoriaTomb[19][val];
                }
            }
        }

        public void probaGomb()
        {
            gombLista.Add(Button_Jatekos1);
            gombLista.Add(Button_Jatekos2);
            gombLista.Add(Button_Jatekos3);
            gombLista.Add(Button_Jatekos4);
            gombLista.Add(Button_Jatekos5);
            gombLista.Add(Button_Jatekos6);
            gombLista.Add(Button_Jatekos7);
            gombLista.Add(Button_Jatekos8);
            gombLista.Add(Button_Jatekos9);
            gombLista.Add(Button_Jatekos10);
        }

        public void segito()
        {
            for (int i = 1; i < 11; i++)
            {
                Beallit(gombLista[i - 1], i + "");
            }
        }

        public void Beallit(Button button, string szam)
        {

            if (szamindex.Contains(szam))
            {
                button.BackColor = Color.Green;
                button.Enabled = false;
            }
            else
            {
                button.BackColor = Color.Red;
                button.Enabled = true;
            }
        }

        private void kategoriaLetilt()
        {
            if (max2 == 2)
            {
                KategoriaGroupBox.Enabled = false;
            }
        }
       
        private void megNyerted()
        {
            DialogResult result = MessageBox.Show("GRATULÁLOK MEGNYERTED AZ EGÉSZ JÁTÉKOT, 25 MILLIÓ FORINTAL LETTÉL GAZDAGABB", "Szeretnél új játékot kezdeni?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form3.passzLehetosegek = "2";
                Form3.eddigMegnyert.Clear();
                Program.foablak.Close();
                this.Close();
                Form3.max2 = 0;
                Form4.hanysor = random.Next(0, 5000);
                szamindex.Clear();                
                Form3 ujFrm = new Form3(Program.fo_jatekos_nev, Program.fo_jatekos_lakhely);
                ujFrm.Button_Jatekos1.BackColor = Color.Red;
                ujFrm.Button_Jatekos1.Enabled = true;
                ujFrm.Button_Jatekos2.BackColor = Color.Red;
                ujFrm.Button_Jatekos2.Enabled = true;
                ujFrm.Button_Jatekos3.BackColor = Color.Red;
                ujFrm.Button_Jatekos3.Enabled = true;
                ujFrm.Button_Jatekos4.BackColor = Color.Red;
                ujFrm.Button_Jatekos4.Enabled = true;
                ujFrm.Button_Jatekos5.BackColor = Color.Red;
                ujFrm.Button_Jatekos5.Enabled = true;
                ujFrm.Button_Jatekos6.BackColor = Color.Red;
                ujFrm.Button_Jatekos6.Enabled = true;
                ujFrm.Button_Jatekos7.BackColor = Color.Red;
                ujFrm.Button_Jatekos7.Enabled = true;
                ujFrm.Button_Jatekos8.BackColor = Color.Red;
                ujFrm.Button_Jatekos8.Enabled = true;
                ujFrm.Button_Jatekos9.BackColor = Color.Red;
                ujFrm.Button_Jatekos9.Enabled = true;
                ujFrm.Button_Jatekos10.BackColor = Color.Red;
                ujFrm.Button_Jatekos10.Enabled = true;
                ujFrm.Show();

            }
            else
            {
                Program.belepoForm.Close();
                Close();
            }
        }
    }
}
