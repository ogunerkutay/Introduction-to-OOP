using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_Hareketli_Label_WASD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonHareketli.Location.Y - 5 > 0)
            {
                buttonHareketli.Location = new Point(buttonHareketli.Location.X, buttonHareketli.Location.Y - 5);
            }           
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (buttonHareketli.Location.X - 5 > 0)
            {
                buttonHareketli.Location = new Point(buttonHareketli.Location.X - 5, buttonHareketli.Location.Y);
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            if (buttonHareketli.Location.Y + 5 < this.Height - 2*buttonHareketli.Height)
            { 
                buttonHareketli.Location = new Point(buttonHareketli.Location.X, buttonHareketli.Location.Y + 5);
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (buttonHareketli.Location.X + 5 < this.Width - buttonHareketli.Width)
            {
                buttonHareketli.Location = new Point(buttonHareketli.Location.X + 5, buttonHareketli.Location.Y);
            }
        }
    }
}
