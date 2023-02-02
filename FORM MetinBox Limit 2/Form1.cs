using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_MetinBox_Limit_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 200;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int karakterSayisi = 200 - textBox1.Text.Length;
            label1.Text = karakterSayisi.ToString();
            if (karakterSayisi == 0)
            {
                label1.ForeColor = Color.Red;

            }
            else
            {
                label1.ForeColor = Color.Black;
            }
        }
    }
}
