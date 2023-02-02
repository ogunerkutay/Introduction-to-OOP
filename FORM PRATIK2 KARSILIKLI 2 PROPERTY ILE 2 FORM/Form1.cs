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
    public partial class Form1 : Form
    {
        public Color Form1PropertysiIleRenkDegistir { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.form2ArkaPlanDegistir(Color.Lavender);
            BackColor = form2.Form2PropertysiIleRenkDegistir;
        
        }

        public void form1ArkaPlanDegistir(Color color)
        {
            Form1PropertysiIleRenkDegistir = color;
        }
    }
}
