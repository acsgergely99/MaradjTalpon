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
    public partial class Form4 : Form
    {
        public int quick = 1200;
        public Form4()
        {
            InitializeComponent();
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            quick--;
            Ido.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1; //1second
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            /*if (Form4.ActiveForm.)
            {   
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }*/        
        }
        private void stopTimer()
        {
            timer1.Enabled = false;
            System.Diagnostics.Debug.WriteLine(timer1.Enabled.ToString());
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

        private void ValaszlehetosegGomb1_Click(object sender, EventArgs e)
        {
            
        }

        private void ValaszlehetosegGomb2_Click(object sender, EventArgs e)
        {
            
        }

        private void IdeiglenesKilepesButton_Click(object sender, EventArgs e)
        {
            Close();
            foreach (Form form in Application.OpenForms)
            {
                if (form is MaradjTalponAlkalmazas)
                {
                    form.Close();
                }
            }
        }
    }
}
