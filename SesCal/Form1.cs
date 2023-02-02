using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SesCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Default default1 = new Default();
            default1.Oynat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();
            nokia.Oynat();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Iphona iphona = new Iphona();
            iphona.Oynat();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.Oynat();
        }

    }
}
