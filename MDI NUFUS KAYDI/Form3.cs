using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_NUFUS_KAYDI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int silinecekIndex = 0;
        Form1 form1;
        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            form1 = (Form1)this.MdiParent;
            int index = 0;
            foreach (Person sahsiyet in form1.nufus)
            {
                listView1.Items.Add(sahsiyet.Ad);
                listView1.Items[index].SubItems.Add(sahsiyet.Soyad);
                listView1.Items[index].SubItems.Add(sahsiyet.DogumGunu.ToString());
                listView1.Items[index].SubItems.Add(sahsiyet.Cinsiyet);
                listView1.Items[index].SubItems.Add(sahsiyet.MedeniHal);
                index++;
            }
        }

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int index = 0;
            foreach (Person sahsiyet in form1.nufus)
            {
                listView1.Items.Add(sahsiyet.Ad);
                listView1.Items[index].SubItems.Add(sahsiyet.Soyad);
                listView1.Items[index].SubItems.Add(sahsiyet.DogumGunu.ToString());
                listView1.Items[index].SubItems.Add(sahsiyet.Cinsiyet);
                listView1.Items[index].SubItems.Add(sahsiyet.MedeniHal);
                index++;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listView1.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    silinecekIndex = focusedItem.Index;
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void kaydıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.nufus.RemoveAt(silinecekIndex);
            listView1.Items.RemoveAt(silinecekIndex);   
        }


    }
}
