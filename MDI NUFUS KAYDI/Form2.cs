using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_NUFUS_KAYDI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        Form1 form1;
        private void Form2_Load(object sender, EventArgs e)
        {
            form1 = (Form1)this.MdiParent;
            radioButtonErkek.Checked = true;
        }
        private void buttonKAYDET_Click(object sender, EventArgs e)
        {
            Person sahsiyet = new Person();

            if (string.IsNullOrWhiteSpace(textBoxAd.Text))
            {
                MessageBox.Show("Bir ad gir");
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBoxSoyad.Text))
            {
                MessageBox.Show("Bir soyad gir");
                return;
            }

            sahsiyet.Ad = textBoxAd.Text.Trim();
            sahsiyet.Soyad = textBoxSoyad.Text.Trim();
            sahsiyet.DogumGunu = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            sahsiyet.Cinsiyet = radioButtonErkek.Checked ? "Erkek" : "Kadın";
            sahsiyet.MedeniHal = checkBoxMedeniHal.Checked ? "Evli" : "Bekar";

            form1.nufus.Add(sahsiyet);

            textBoxAd.Text = String.Empty;
            textBoxSoyad.Text = String.Empty;
            dateTimePicker1.Value = DateTime.Now;
            radioButtonErkek.Checked = true;
            radioButtonKadin.Checked = false;
            checkBoxMedeniHal.Checked = false;
        }


    }
}
