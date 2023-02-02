using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_KULLANICI_GIRISI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string isim)
        {
            InitializeComponent();
            label1.Text = "hoşgeldin " + isim;

        }
        private void Form2_FormClosed(object sender, FormClosingEventArgs e)
        {

            this.Owner.Show();
        }


    }
}
