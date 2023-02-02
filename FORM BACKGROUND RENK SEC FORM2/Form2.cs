using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_BACKGROUND_RENK_SEC_FORM2
{
    public partial class Form2 : Form
    {

        Form form1;
        Color gelenrenk;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form gelenform1)
        {
            InitializeComponent();
            form1 = gelenform1;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            //{
            //    if (prop.PropertyType.FullName == "System.Drawing.Color")
            //    {
            //        comboBox1.Items.Add(prop.Name);
            //    }
            //}

            comboBox1.Items.Add(Color.Gray);
            comboBox1.Items.Add(Color.Aqua);
            comboBox1.Items.Add(Color.Red);
            comboBox1.Items.Add(Color.Green);
            comboBox1.Items.Add(Color.Blue);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                form1.BackColor = (Color)comboBox1.SelectedItem;
                this.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
