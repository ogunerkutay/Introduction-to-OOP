using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunTimeControlSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(LoadForm);
        }

        Label lblFirstName;
        Label lblLastName;
        TextBox txtFirstName;
        TextBox txtLastName;
        Button btnKaydet;
        private void LoadForm(object sender, EventArgs e)
        {
            lblFirstName = new Label();
            lblFirstName.Text = "FirstName";
            lblFirstName.Location = new Point(20,20);

            lblLastName = new Label();
            lblLastName.Text = "LastName";
            lblLastName.Location = new Point(20, 50);

            txtFirstName = new TextBox();
            txtFirstName.Location = new Point(120, 20);
            txtFirstName.Size = new Size(150, 25);
            
            txtLastName = new TextBox();
            txtLastName.Location = new Point(120, 50);
            txtLastName.Size = new Size(150, 25);

            btnKaydet = new Button();
            btnKaydet.Text = "Kaydet";
            btnKaydet.Location = new Point(120, 80);

            this.Controls.Add(lblFirstName);
            this.Controls.Add(lblLastName);
            this.Controls.Add(txtFirstName);
            this.Controls.Add(txtLastName);
            this.Controls.Add(btnKaydet);
            btnKaydet.Click += new EventHandler(ShowInfo);
            txtFirstName.Enter += new EventHandler(ChangeBackColor);
            txtLastName.Enter += new EventHandler(ChangeBackColor);



        }

        private void ChangeBackColor(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.Aqua;
        }

        private void ShowInfo(object sender, EventArgs e)
        {
            string _str = string.Empty;
            string _firstName = txtFirstName.Text;
            string _lastName = txtLastName.Text;
            if (_firstName.Length > 0 && _lastName.Length > 0)
            {
                _str = _firstName + " " + _lastName;
                MessageBox.Show(_str,"İsim Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
    }
}
