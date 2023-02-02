using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2;
        private void form2GösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Dock = DockStyle.Fill;
            this.Width = form2.Width;
            this.Height = form2.Height;
            form2.Show();
        }

        private void form2KapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form2!=null)
            {
                form2.Close();
            }
        }
    }
}
