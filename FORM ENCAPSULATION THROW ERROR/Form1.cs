using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_ENCAPSULATION_THROW_ERROR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonBekar.Checked = true;
        }
        private void buttonKAYDET_Click(object sender, EventArgs e)
        {

            try
            {

                PERSONEL personel = new PERSONEL();
                personel.Ad = textBoxAd.Text;
                personel.SoyAd = textBoxSoyad.Text;
                personel.Medenihal = radioButtonBekar.Checked ? "Bekar" : "Evli";
                personel.Personelno = Convert.ToInt32(nudPersonel.Value);
                personel.TCno = textBoxTC.Text;
                personel.Email = textBoxEmail.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }


    }
}
