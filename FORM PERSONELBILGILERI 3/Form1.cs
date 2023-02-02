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

        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();
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

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            Employee calisan = new Employee();
            calisan.AdSoyad = textBoxAdSoyad.Text.ToLower().Trim();
            calisan.Sinif = textBoxSinif.Text.ToLower().Trim();
            calisan.TC = textBoxTC.Text.ToLower().Trim();
            calisan.Memleket = textBoxMemleket.Text.ToLower().Trim();
            calisan.Cinsiyet = radioButtonErkek.Checked ? "erkek" : "kiz";
            calisan.DogumGunu = dateTimePicker1.Value.ToString("hh:mm:ss tt dd/MM/yyyy");

            try
            {
                employeeDictionary.Add(calisan.TC, calisan);
                listBox1.Items.Add(calisan.TC);
                listBox1.SelectedIndex = -1;

            }
            catch (Exception)
            {
                MessageBox.Show("Bu TC numarasına sahip çalışan mevcut!");
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
            labelKayit.Text = String.Empty;

            if (listBox1.SelectedItem != null)
            {
                Employee calisan = employeeDictionary[listBox1.Text];
                labelKayit.Text = "Ad Soyad: " + calisan.AdSoyad + "\nSınıf: " + calisan.Sinif + "\nTC no: " + calisan.TC + "\nMemleket: " + calisan.Memleket + "\nCinsiyeti: " + calisan.Cinsiyet + "\nDogum Tarihi : " + calisan.DogumGunu;
            }

        }
    }
}