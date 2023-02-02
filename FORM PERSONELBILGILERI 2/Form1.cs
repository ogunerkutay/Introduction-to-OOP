using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_PERSONELBILGILERI
{
    public partial class Form1 : Form
    {
        List<Employee> calisanlar;
        public Form1()
        {
            InitializeComponent();
            calisanlar = new List<Employee>();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxAdSoyad.Text = String.Empty;
            textBoxSinif.Text = String.Empty;
            textBoxTC.Text = String.Empty;
            textBoxMemleket.Text = String.Empty;
            radioButtonErkek.Checked = true;
            radioButtonKiz.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            buttonTemizle.Enabled = false;

        }

        private void buttonLabelTemizle_Click(object sender, EventArgs e)
        {
            labelKayit.Text = String.Empty;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            Employee calisan = new Employee();
            calisan.AdSoyad = textBoxAdSoyad.Text.ToLower().Trim();
            calisan.Sinif = textBoxSinif.Text.ToLower().Trim();
            calisan.TC = textBoxTC.Text.ToLower().Trim();
            calisan.Memleket = textBoxMemleket.Text.ToLower().Trim();
            calisan.Cinsiyet = radioButtonErkek.Checked ? "erkek" : "kiz";
            calisan.DogumGunu = dateTimePicker1.Value.ToString("hh:mm:ss tt dd/MM/yyyy");

            if (!calisanlar.Contains(calisan))
            {
                
                if (!calisanlar.Any(kayitliCalisanlar => kayitliCalisanlar.TC == calisan.TC))
                {
                    calisanlar.Add(calisan);
                    listBox1.Items.Add(calisan.TC);
                }
            }
            buttonTemizle.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonErkek.Checked = true;
            buttonTemizle.Enabled = false;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee calisan = calisanlar[listBox1.SelectedIndex];
            labelKayit.Text = "Ad Soyad: " + calisan.AdSoyad + "\nSınıf: " + calisan.Sinif + "\nTC no: " + calisan.TC + "\nMemleket: " + calisan.Memleket + "\nCinsiyeti: " + calisan.Cinsiyet + "\nDogum Tarihi : " + calisan.DogumGunu;
        }
    }
}