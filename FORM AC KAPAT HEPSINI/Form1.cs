using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_AC_KAPAT_HEPSINI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Form> formlistesi = new List<Form>();
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            formlistesi.Add(form2);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            formlistesi.Add(form3);
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count-1; i > 0; i--)
            {
                Application.OpenForms[i].Close();
            }


            //foreach (Form item in formlistesi)
            //{
            //    item.Close();
            //}
        }
    }
}
