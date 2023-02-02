using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_Sifre_Guvenligi_Belirle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string sifre = textBox1.Text;
            if (sifre.Length < 6 || sifre.All(char.IsLetter) || sifre.All(char.IsDigit) || !sifre.Any(char.IsLetterOrDigit))
            {
                label1.Text = "Düşük";
                label1.ForeColor = Color.Red;
            }

            else if (sifre.Any(char.IsLetter) && sifre.Any(char.IsDigit) && !sifre.All(char.IsLetterOrDigit))
            {
                label1.Text = "Yüksek";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Yüksek";
                label1.ForeColor = Color.Green;
            }
        }
    }
}
