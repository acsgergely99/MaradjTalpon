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

namespace MaradjTalpon
{
    public partial class Form3 : Form
    {
        public int PasszolasiLehetosegek = 2;
        public int OsszNyeremeny = 0;
        MySqlConnection conn;
        public Form3(string uj_jatekos, string uj_lakhely)
        {          
            //Form2 masodik = ActiveForm;
            

            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Port=3306; Database=maradj_talpon; Uid=root; Pwd=;");
            conn.Open();
            FoJatekosTextBox.Text = uj_jatekos;
            JatekosLakhelyTextBox.Text = uj_lakhely;


            PasszolasiLehetosegTextBox.Text = "2";
            PenznyeremenyTextBox.Text = "0";
            //bezar();
            //FoJatekosTextBox.Items.Clear();
        }
        public List<int> penznyeremenyek = new List<int>();
        public void penzhozzaad()
        {
            int szazft1=100, szazft2 = 100, szazhuszonotezerft1 =125000, szazhuszonotezerft2 = 125000, ketszazotvenezerft1 =250000, ketszazotvenezerft2 = 250000, otszazezerft1 =500000, otszazezerft2 = 500000, egymillioft1 =1000000, egymillioft2 = 1000000;
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

            Random rand = new Random(Convert.ToInt32(penznyeremenyek));
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
        private void Button_Jatekos1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            form4.ShowDialog();
        }

        private void Button_Jatekos2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            form4.ShowDialog();
        }

        private void Button_Jatekos3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            form4.ShowDialog();
        }

        private void Button_Jatekos4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            form4.ShowDialog();
        }

        private void Button_Jatekos5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            form4.ShowDialog();
        }

        private void Button_Jatekos6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            form4.ShowDialog();
        }

        private void Button_Jatekos7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            form4.ShowDialog();
        }

        private void Button_Jatekos8_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            form4.ShowDialog();
        }

        private void Button_Jatekos9_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            form4.ShowDialog();
        }

        private void Button_Jatekos10_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            form4.ShowDialog();
        }
        
    }
}
