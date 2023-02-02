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

namespace FORM_2_DOSYAYI_KIYASLA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path1;
        string path2;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path1 = openFileDialog.FileName;
                textBox1.Text = path1;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path2 = openFileDialog.FileName;
                textBox2.Text = path2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(path1) && !string.IsNullOrWhiteSpace(path1))
            {
                StreamReader streamReader1 = new StreamReader(path1);
                string okunanDosya1 = streamReader1.ReadToEnd();
                List<string> kelimelerDosya1 = new List<string>();

                var punctuation1 = okunanDosya1.Where(Char.IsPunctuation).Distinct().ToArray();
                kelimelerDosya1 = okunanDosya1.Split().Select(x => x.Trim(punctuation1)).ToList();
                //kelimelerDosya1 = okunanDosya1.Split(' ').ToList();
                streamReader1.Close();

                StreamReader streamReader2 = new StreamReader(path2);
                string okunanDosya2 = streamReader2.ReadToEnd();
                List<string> kelimelerDosya2 = new List<string>();

                var punctuation2 = okunanDosya1.Where(Char.IsPunctuation).Distinct().ToArray();
                kelimelerDosya2 = okunanDosya1.Split().Select(x => x.Trim(punctuation2)).ToList();
                //kelimelerDosya2 = okunanDosya1.Split(' ').ToList();
                streamReader2.Close();

                List<string> ortakKelimeler = new List<string>();
                ortakKelimeler = kelimelerDosya1.Intersect(kelimelerDosya2).ToList();

                foreach (string ortakKelime in ortakKelimeler)
                {
                    textBox3.Text += ortakKelime + "\r\n";
                }
                
            }

        }
    }
}
