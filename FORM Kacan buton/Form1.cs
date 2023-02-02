using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_Kacan_buton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int sayac;
        Random rand = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 300;
            this.Width = 300;
            sayac = 0;
            
        }
        private void YAKALA(object sender, EventArgs e)
        {

            button1.Location = new Point(rand.Next(0,this.Width-button1.Width), rand.Next(0, this.Height-button1.Height));
            sayac++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakalandım : " + sayac + ". adımda.");
        }
    }
}
