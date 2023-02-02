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
    public partial class Form1 : Form
    {

        public List<string> ogrenciList = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2;
        Form3 form3;
        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form3!=null)
            {
                form3.Hide();
            }
            form2.Show();
        }

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form2 != null)
            {
                form2.Hide();
            }
            if (form3 == null)
            {
                form3 = new Form3();
                form3.MdiParent = this;
                form3.Dock = DockStyle.Fill;
                this.Width = form3.Width + 30;
                this.Height = form3.Height + 30;
            }

           form3.Show();
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                 form2 = new Form2();
                form2.MdiParent = this;
                form2.Dock = DockStyle.Fill;
                this.Width = form2.Width + 30;
                this.Height = form2.Height + 30;
                form2.Show();
            }
        }
    }
}
