using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_PRATIK1_KARSILIKLI_2_PUBLIC_METHOD_ILE_2_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.form2ArkaPlaniDegistir(Color.Green);
        }
        public void form1ArkaPlaniDegistir(Color color)
        {
            BackColor = color;
        }
    }
}
