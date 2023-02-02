using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_KULLANICI_GIRISI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "id" && textBox2.Text == "sifre")
            {
                this.Hide();
                Form2 form2 = new Form2(textBox1.Text);
                form2.Owner = this;
                form2.Show();


            }
            else
            {

                DialogResult result = MessageBox.Show("Kullanıcı adı veya parola hatalı", "Uyarı mesajı", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else if (result == DialogResult.Cancel)
                {
                    //no...
                }

            }
            
        }


    }
}
