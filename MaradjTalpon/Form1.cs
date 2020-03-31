using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Media;

namespace MaradjTalpon
{
    public partial class MaradjTalponAlkalmazas : Form
    {
        MySqlConnection conn;
        public MaradjTalponAlkalmazas()
        {
            InitializeComponent();

            conn = new MySqlConnection("Server=localhost; Port=3306; Database=maradj_talpon; Uid=root; Pwd=;");

            conn.Open();
        }
        private void MaradjTalponAlkalmazas_Load(object sender, EventArgs e)
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            //simpleSound.Play();
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
        private void JatekKezdesGomb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.Form2.Show();                     
        }
        private void KilepesButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaradjTalponAlkalmazas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
    }
}

