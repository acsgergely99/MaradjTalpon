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
        //public bool buul = false;
        //System.Timers.Timer TimeR = new System.Timers.Timer();
        //System.Timers.Timer TimeR2 = new System.Timers.Timer();
        //public int countDown = 0;
        //public int countDown2 = 0;
        Timer timer = new Timer();
        public int quick = 1200;
        public int quick2 = 300;
        public int quick3 = 3000;

        private static Random random = new Random();
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
            //TimeR.Elapsed += new ElapsedEventHandler(OnTimeEvent);
            //TimeR.Interval = 1000;
            //TimeR2.Elapsed += new ElapsedEventHandler(OnTimeEvent2);
            //TimeR2.Interval = 1000;
            hanysor = random.Next(0, 5000);
            szoveg();
            ParbajPasszTextBox.Text = PasszolasiLehetoseg;
        }

        //private void OnTimeEvent(object sender, ElapsedEventArgs e)
        //{
        //    countDown++;
        //    if (countDown % 3 == 0)
        //    {
        //        TimeR.Stop();
        //        //joValasz();
        //    }
        //}

        //private void OnTimeEvent2(object sender, ElapsedEventArgs e)
        //{
        //    countDown2++;
        //    if (countDown2 % 3 == 0)
        //    {
        //        TimeR2.Stop();
        //        szoveg();
        //    }
        //}
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
                    if (buul)
                    {
                        ParbajPasszTextBox.Text = "2";
                    }                   
                }
                else if (ParbajPasszTextBox.Text == "1")
                {
                    ParbajPasszTextBox.Text = "0";
                    if (buul)
                    {
                        ParbajPasszTextBox.Text = "1";
                    }
                }
                else if (ParbajPasszTextBox.Text == "0")
                {
                    MessageBox.Show("GAME OVER");
                    if (buul)
                    {
                        ParbajPasszTextBox.Text = "0";
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
                buul = true;
            }
            else
            {              
                if (helyes == "A")
                {
                    ValaszlehetosegGomb1.BackColor = Color.Green;
                    t.Stop();
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
                        if (ParbajPasszTextBox.Text == "2")
                        {
                            ParbajPasszTextBox.Text = "1";
                            if (buul)
                            {
                                ParbajPasszTextBox.Text = "2";
                            }
                        }
                        else if (ParbajPasszTextBox.Text == "1")
                        {
                            ParbajPasszTextBox.Text = "0";
                            if (buul)
                            {
                                ParbajPasszTextBox.Text = "1";
                            }
                        }
                        else if (ParbajPasszTextBox.Text == "0")
                        {
                            MessageBox.Show("GAME OVER");
                            if (buul)
                            {
                                ParbajPasszTextBox.Text = "0";
                            }
                        }
                    }
                }
                else if (helyes == "B")
                {
                    ValaszlehetosegGomb2.BackColor = Color.Green;
                    t.Stop();
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
                        if (ParbajPasszTextBox.Text == "2")
                        {
                            ParbajPasszTextBox.Text = "1";
                            if (buul)
                            {
                                ParbajPasszTextBox.Text = "2";
                            }
                        }
                        else if (ParbajPasszTextBox.Text == "1")
                        {
                            ParbajPasszTextBox.Text = "0";
                            if (buul)
                            {
                                ParbajPasszTextBox.Text = "1";
                            }
                        }
                        else if (ParbajPasszTextBox.Text == "0")
                        {
                            MessageBox.Show("GAME OVER");
                            if (buul)
                            {
                                ParbajPasszTextBox.Text = "0";
                            }
                        }
                    }
                }
                else if (helyes == "C")
                {
                    ValaszlehetosegGomb3.BackColor = Color.Green;
                    t.Stop();
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
                        if (ParbajPasszTextBox.Text == "2")
                        {
                            ParbajPasszTextBox.Text = "1";
                            if (buul)
                            {
                                ParbajPasszTextBox.Text = "2";
                            }
                        }
                        else if (ParbajPasszTextBox.Text == "1")
                        {
                            ParbajPasszTextBox.Text = "0";
                            if (buul)
                            {
                                ParbajPasszTextBox.Text = "1";
                            }
                        }
                        else if (ParbajPasszTextBox.Text == "0")
                        {
                            MessageBox.Show("GAME OVER");
                            if (buul)
                            {
                                ParbajPasszTextBox.Text = "0";
                            }
                        }
                    }
                }
                else if (helyes == "D")
                {
                    ValaszlehetosegGomb4.BackColor = Color.Green;
                    t.Stop();
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
                        if (ParbajPasszTextBox.Text == "2")
                        {
                            ParbajPasszTextBox.Text = "1";
                            if (buul)
                            {
                                ParbajPasszTextBox.Text = "2";
                            }
                        }
                        else if (ParbajPasszTextBox.Text == "1")
                        {
                            ParbajPasszTextBox.Text = "0";
                            if (buul)
                            {
                                ParbajPasszTextBox.Text = "1";
                            }
                        }
                        else if (ParbajPasszTextBox.Text == "0")
                        {
                            MessageBox.Show("GAME OVER");
                            if (buul)
                            {
                                ParbajPasszTextBox.Text = "0";
                            }
                        }
                    }
                }                
            }
            
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();           
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
            joValasz();

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
            joValasz();

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
            joValasz();

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
            if (Form3.passzLehetosegek == "2")
            {
                Form3.passzLehetosegek = "1";
                ParbajPasszTextBox.Text = "1";
                hanysor = random.Next(0, 5000);
                szoveg();
                quick=1200;
            }
            else if (Form3.passzLehetosegek == "1")
            {
                Form3.passzLehetosegek = "0";
                ParbajPasszTextBox.Text = "0";
                hanysor = random.Next(0, 5000);
                szoveg();
                quick = 1200;
            }
            else if (Form3.passzLehetosegek == "0")
            {
                t.Stop();                
                DialogResult result = MessageBox.Show("Elfogytak a passzolási lehetőségeid","",MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    t.Start();
                }
            }
        }
        //public void rosszValasz()
        //{
        //else if (helyes != "A")
        //{
        //    ValaszlehetosegGomb1.BackColor = Color.Blue;
        //    ValaszlehetosegGomb2.Enabled = true;
        //    ValaszlehetosegGomb2.BackColor = Color.Blue;
        //    ValaszlehetosegGomb1.Enabled = true;
        //    ValaszlehetosegGomb3.BackColor = Color.Blue;
        //    ValaszlehetosegGomb3.Enabled = true;
        //    ValaszlehetosegGomb4.BackColor = Color.Blue;
        //    ValaszlehetosegGomb4.Enabled = true;
        //    hanysor = random.Next(0, 5000);
        //    szoveg();
        //    quick = 1200;
        //}
        //else if (helyes != "B")
        //{
        //    ValaszlehetosegGomb1.BackColor = Color.Blue;
        //    ValaszlehetosegGomb2.Enabled = true;
        //    ValaszlehetosegGomb2.BackColor = Color.Blue;
        //    ValaszlehetosegGomb1.Enabled = true;
        //    ValaszlehetosegGomb3.BackColor = Color.Blue;
        //    ValaszlehetosegGomb3.Enabled = true;
        //    ValaszlehetosegGomb4.BackColor = Color.Blue;
        //    ValaszlehetosegGomb4.Enabled = true;
        //    hanysor = random.Next(0, 5000);
        //    szoveg();
        //    quick = 1200;

        //}
        //else if (helyes != "C")
        //{
        //    ValaszlehetosegGomb1.BackColor = Color.Blue;
        //    ValaszlehetosegGomb2.Enabled = true;
        //    ValaszlehetosegGomb2.BackColor = Color.Blue;
        //    ValaszlehetosegGomb1.Enabled = true;
        //    ValaszlehetosegGomb3.BackColor = Color.Blue;
        //    ValaszlehetosegGomb3.Enabled = true;
        //    ValaszlehetosegGomb4.BackColor = Color.Blue;
        //    ValaszlehetosegGomb4.Enabled = true;
        //    hanysor = random.Next(0, 5000);
        //    szoveg();
        //    quick = 1200;
        //}
        //else if (helyes != "D")
        //{
        //    ValaszlehetosegGomb1.BackColor = Color.Blue;
        //    ValaszlehetosegGomb2.Enabled = true;
        //    ValaszlehetosegGomb2.BackColor = Color.Blue;
        //    ValaszlehetosegGomb1.Enabled = true;
        //    ValaszlehetosegGomb3.BackColor = Color.Blue;
        //    ValaszlehetosegGomb3.Enabled = true;
        //    ValaszlehetosegGomb4.BackColor = Color.Blue;
        //    ValaszlehetosegGomb4.Enabled = true;
        //    hanysor = random.Next(0, 5000);
        //    szoveg();
        //    quick = 1200;
        //}
        //}

        //public void helytelenValasz()
        //{
        //else if (betu != "A")
        //{
        //    hanysor = random.Next(0, 5000);
        //    szoveg();
        //    quick = 1200;
        //}
        //else if (betu != "B")
        //{
        //    hanysor = random.Next(0, 5000);
        //    szoveg();
        //    quick = 1200;
        //}
        //else if (betu != "C")
        //{
        //    hanysor = random.Next(0, 5000);
        //    szoveg();
        //    quick = 1200;
        //}
        //else if (betu != "D")
        //{
        //    hanysor = random.Next(0, 5000);
        //    szoveg();
        //    quick = 1200;
        //}
        //}
        public void correct()
        {
            quick3 = 200;
            string helyes = BEOLVAS.helyesValasz(hanysor);
            if (helyes.Equals(betu))
            {               
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

            }
            this.Close();
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form3)
                {
                    form.Show();
                }
            }
        }
    }
}
