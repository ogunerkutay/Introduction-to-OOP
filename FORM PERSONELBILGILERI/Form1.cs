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
                calisanlar.Add(calisan);
            }
            buttonTemizle.Enabled = true;
        }

        int goruntulemeIndexi;
        private void buttonKayitlar_Click(object sender, EventArgs e)
        {
            goruntulemeIndexi = calisanlar.Count - 1;
            KaydiGoruntule();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonErkek.Checked = true;
            buttonTemizle.Enabled = false;
            buttonLabelTemizle.Enabled=false;
        }
        
        void KaydiGoruntule()
        {
            Employee calisan = calisanlar[goruntulemeIndexi];
            labelKayit.Text = "Ad Soyad: " + calisan.AdSoyad + "\nSınıf: " + calisan.Sinif + "\nTC no: " + calisan.TC + "\nMemleket: " + calisan.Memleket + "\nCinsiyeti: " + calisan.Cinsiyet + "\nDogum Tarihi : " + calisan.DogumGunu;
            buttonLabelTemizle.Enabled = true;
            ButonlariKontrolEt();
        }

        void ButonlariKontrolEt()
        {
            if (goruntulemeIndexi == 0 )
            {
                buttonKayitGeri.Enabled = false;
                if (calisanlar.Count > 1) buttonKayitIleri.Enabled = true;
                else buttonKayitIleri.Enabled = false;
            }
            else if (goruntulemeIndexi == calisanlar.Count - 1 )
            {
                buttonKayitIleri.Enabled = false;
                if (calisanlar.Count > 1) buttonKayitGeri.Enabled = true;
                else buttonKayitGeri.Enabled = false;
            }
            else
            {
                buttonKayitGeri.Enabled = true;
                buttonKayitIleri.Enabled = true;
            }
        }

        private void buttonKayitGeri_Click(object sender, EventArgs e)
        {
            if (goruntulemeIndexi > 0) goruntulemeIndexi--;
            else goruntulemeIndexi = 0;
            KaydiGoruntule();
        }

        private void buttonKayitIleri_Click(object sender, EventArgs e)
        {
            if (goruntulemeIndexi < calisanlar.Count -1) goruntulemeIndexi++;
            else goruntulemeIndexi = calisanlar.Count-1;
            KaydiGoruntule();
        }

    }
}
