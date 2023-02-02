using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_DOSYA_OKU_YAZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filepath;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 0,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                textBox1.Text = filepath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (filepath != null)
            {
                    StreamReader streamReader = new StreamReader(filepath);
                    textBox2.Text = streamReader.ReadToEnd();
                    streamReader.Close();
            }
            else
            {
                Console.WriteLine("lütfen bir dosya seçiniz");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filepath == null)
            {
                Console.WriteLine("lütfen bir dosya seçiniz");
                return;
            }
            StreamWriter streamWriter = new StreamWriter(filepath,true);
            streamWriter.Write("\n"+textBox2.Text);
            streamWriter.Close();
            textBox1.Text=String.Empty;
        }
    }
}
