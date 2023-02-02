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

namespace WFA_HIGHLIGHT_HOCA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> linelist = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("text.txt");
            string line;
            do
            {
                line = sr.ReadLine();
                if (line != null) linelist.Add(line);
            } while (line != null);
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            richTextBox1.Text = "";
            if (!string.IsNullOrWhiteSpace(aranan))
            {
                foreach (string item in linelist)
                {
                    if (item.Contains(aranan))
                    {
                        richTextBox1.Text += item + "\n";
                    }
                }
                Highlight(richTextBox1, aranan, Color.Red);
            }
            else
            {
                MessageBox.Show("kelime yaz önce");
            }
        }
        private void Highlight(RichTextBox richTextBox,string aranan,Color color)
        {
            richTextBox1.SelectionStart = 0;
            int startindex = 0;
            int index;
            while ((index = richTextBox.Text.IndexOf(aranan,startindex))!=-1)
            {
                richTextBox1.Select(index,aranan.Length);
                richTextBox1.SelectionColor=color;
                startindex = index + aranan.Length;
            }

        }
    }
}