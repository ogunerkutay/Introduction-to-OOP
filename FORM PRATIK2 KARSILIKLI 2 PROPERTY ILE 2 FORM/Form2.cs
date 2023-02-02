using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_PRATIK2_KARSILIKLI_2_PROPERTY_ILE_2_FORM
{
    public partial class Form2 : Form
    {
        public Color Form2PropertysiIleRenkDegistir { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.form1ArkaPlanDegistir(Color.Ivory);
            BackColor = form1.Form1PropertysiIleRenkDegistir;

        }
        public void form2ArkaPlanDegistir(Color color)
        {
            Form2PropertysiIleRenkDegistir = color;
        }
    }
}
