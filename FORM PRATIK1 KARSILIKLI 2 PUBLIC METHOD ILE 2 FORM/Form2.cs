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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Form1 form1 = (Form1)Application.OpenForms["Form1"];

            form1.form1ArkaPlaniDegistir(Color.Red);
        }

        public void form2ArkaPlaniDegistir(Color color)
        {
            BackColor = color;
        }

    }
}
