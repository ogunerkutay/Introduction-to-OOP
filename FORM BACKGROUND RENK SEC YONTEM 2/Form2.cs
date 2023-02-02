using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_BACKGROUND_RENK_SEC_YONTEM_2
{
    public partial class Form2 : Form
    {
        public Color SecilenRenk { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
                SecilenRenk = (Color)comboBox1.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
