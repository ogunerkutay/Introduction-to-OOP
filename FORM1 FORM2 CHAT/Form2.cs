using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM1_FORM2_CHAT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];

            ((TextBox)form1.Controls["TextBox1"]).Text = textBox1.Text;
        }
       
    }
}
