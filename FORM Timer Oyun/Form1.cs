using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_Timer_Oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 60;
        int kackere = 0;
        Random random = new Random();
        int olusturulanSayi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            olusturulanSayi = random.Next(1,101);
            timer1.Interval = 1000;
            timer1.Start();
            button2.Text = sayac.ToString();
            kackere = 0;

            progressBar1.Maximum = 60;
            progressBar1.Step = 1;
            progressBar1.Value = 60;
            button2.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac--;
            if (sayac == 0)
                timer1.Stop();
            button2.Text = sayac.ToString();
            progressBar1.Value--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            numericUpDown1.Focus();
            kackere++;
            string mesaj = string.Empty;
            switch (kackere)
            {
                case 0:
                case 1:
                    mesaj = "Helal ossun!";
                    break;
                case 2:
                    mesaj = "çok güzel";
                    break;
                case 3:
                    mesaj = "aferin";
                    break;
                case 4:
                    mesaj = "hadi kabul";
                    break;
                case 5:
                    mesaj = "hadi kabul";
                    break;
                case 6:
                    mesaj = "hadi kabul";
                    break;
                case 7:
                    mesaj = "hadi kabul";
                    break;
                case 8:
                    mesaj = "8 kere bilemedin";
                    break;
                case 9:
                    mesaj = "9 kere bilemedin";
                    break;
                default:
                    mesaj = "bırak oynama";
                    break;
            }

            if (numericUpDown1.Value == olusturulanSayi)
            {
                label2.Text = mesaj + " " + "BİLDİN";
                timer1.Stop();
                button2.Enabled = false;
            }
            else if (Math.Abs(numericUpDown1.Value - olusturulanSayi) < 10)
            {
                label2.Text = mesaj + " " + "YAKLAŞTIN";
            }
            else if (Math.Abs(numericUpDown1.Value - olusturulanSayi) < 20)
            {
                label2.Text = mesaj + " " + "DAHA VAR";
            }
            else if (Math.Abs(numericUpDown1.Value - olusturulanSayi) < 30)
            {
                label2.Text = mesaj + " " + "UZAKSIN";
            }
            else
            {
                label2.Text = mesaj + " " + "ÇOK UZAKSIN";
            }
        }


    }
}
