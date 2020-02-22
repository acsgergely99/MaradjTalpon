using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaradjTalpon
{
    public partial class Form2 : Form
    {

        MySqlConnection conn;   
        public Form2()
        {
            InitializeComponent();

            conn = new MySqlConnection("Server=localhost; Port=3306; Database=maradj_talpon; Uid=root; Pwd=;");
            conn.Open();


            fojatekosListazasa();
        }
        private void Form2_Load(object sender, EventArgs e)
        { }

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
        private void KezdesVisszaButton_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form form in Application.OpenForms)
            {
                if (form is MaradjTalponAlkalmazas)
                {
                    form.Show();
                }
            }
        }        
        public void fojatekosListazasa()
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, nev, lakhely FROM fo_jatekos ORDER BY nev";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakhely = reader.GetString("lakhely");
                    var fo_jatekos = new Fo_jatekos(id, nev, lakhely);
                }
            }
        }

        private void JatekKezdesGomb_Click(object sender, EventArgs e)
        {
            if ((!JatekosLakhelyTextBox.Text.Equals("")) && (!JatekosNevTextBox.Text.Equals("")))
            {
                var cmd = conn.CreateCommand();
                
                cmd.Parameters.AddWithValue("@nev", JatekosNevTextBox.Text);
                cmd.Parameters.AddWithValue("@lakhely", JatekosLakhelyTextBox.Text);
                cmd.CommandText = "INSERT INTO fo_jatekos (nev, lakhely) VALUES (@nev, @lakhely)";
                cmd.CommandText = "INSERT INTO fo_jatekos (nev, lakhely) VALUES (@nev, @lakhely)";
                cmd.CommandText = "INSERT INTO fo_jatekos (nev, lakhely) VALUES (@nev, @lakhely)";
                cmd.CommandText = "INSERT INTO fo_jatekos (nev, lakhely) VALUES (@nev, @lakhely)";
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("Ez a játékosnév már rögzítve lett!");
                    }
                }
                Form3 form3 = new Form3(JatekosNevTextBox.Text, JatekosLakhelyTextBox.Text);
                this.Close();
                form3.Show();           
            }
            else
            {
                MessageBox.Show("Nincs valami kitöltve!");
            }
        }
    }
}
