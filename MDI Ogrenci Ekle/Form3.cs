using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Ogrenci_Ekle
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            Form1 form1 = (Form1)this.MdiParent;
            foreach (string ogrenci in form1.ogrenciList)
            {
                
                textBox1.Text += ogrenci;
            }
        }

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            Form1 form1 = (Form1)this.MdiParent;
            foreach (string ogrenci in form1.ogrenciList)
            {

                textBox1.Text += ogrenci +"\r\n";
            }
        }
    }
}
