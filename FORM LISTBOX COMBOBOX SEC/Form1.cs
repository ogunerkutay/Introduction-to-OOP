using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_LISTBOX_COMBOBOX_SEC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                list.Add(textBox1.Text);
                comboBox1.Items.Add(list[list.Count - 1]);
                listBox1.Items.Add(list[list.Count - 1]);
                comboBox1.SelectedIndex = 0;
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen bir eleman giriniz");
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(list[listBox1.SelectedIndex]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 ) MessageBox.Show(list[comboBox1.SelectedIndex]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }
    }
}
