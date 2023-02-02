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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Employee employee;
        public Form2(Employee calisan)
        {
            InitializeComponent();
            employee = calisan;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            EkranaYaz(employee);
        }

        public void EkranaYaz(Employee calisan)
        {

        labelKayit.Text = String.Empty;
        labelKayit.Text = "Ad Soyad: " + calisan.AdSoyad + "\nSınıf: " + calisan.Sinif + "\nTC no: " + calisan.TC + "\nMemleket: " + calisan.Memleket + "\nCinsiyeti: " + calisan.Cinsiyet + "\nDogum Tarihi : " + calisan.DogumGunu;
        
        }



    }
}

