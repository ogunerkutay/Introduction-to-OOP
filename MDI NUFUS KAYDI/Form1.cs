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

namespace MDI_NUFUS_KAYDI
{
    public partial class Form1 : Form
    {
        public List<Person> nufus = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }
        int formBorderWidthOffset;
        int formBorderandCaptionHeightOffset;
        Form2 form2;
        Form3 form3;
        private void Form1_Load(object sender, EventArgs e)
        {
           if (File.Exists("NUFUS.txt"))
            {

                FileStream fileoku = null;
                StreamReader streamoku = null;

                try
                {
                    fileoku = new FileStream("NUFUS.txt", FileMode.Open, FileAccess.Read);
                    streamoku = new StreamReader(fileoku);

                    string okunan = streamoku.ReadLine();

                    while (okunan != null)
                    {
                        string[] sahsiyetSatiri = okunan.Split(';');

                        Person sahsiyet = new Person();

                        int index = 0;
                        foreach (var sahsiyetOzellikleri in sahsiyet.GetType().GetProperties())
                        {
                            sahsiyetOzellikleri.SetValue(sahsiyet,sahsiyetSatiri[index]);
                            index++;
                        }

                        //sahsiyet.Ad = sahsiyetSatiri[0];
                        //sahsiyet.Soyad = sahsiyetSatiri[1];
                        //sahsiyet.DogumGunu = sahsiyetSatiri[2];
                        //sahsiyet.Cinsiyet = sahsiyetSatiri[3];
                        //sahsiyet.MedeniHal = sahsiyetSatiri[4];

                        nufus.Add(sahsiyet);
                        okunan = streamoku.ReadLine();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    streamoku.Close();
                    streamoku = null;
                    fileoku.Close();
                    fileoku = null;
                }

            }

            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            formBorderWidthOffset = (SystemInformation.Border3DSize.Width*2);
            formBorderandCaptionHeightOffset = (SystemInformation.CaptionHeight + SystemInformation.Border3DSize.Height * 2 + SystemInformation.BorderSize.Width);
            
            if (form2 == null)
            {
                form2 = new Form2();
                form2.MdiParent = this;
                this.SetClientSizeCore(form2.Width + formBorderWidthOffset, form2.Height + formBorderandCaptionHeightOffset);
                form2.Dock = DockStyle.Fill;
                form2.Show();
            }
        }


        private void eKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form3 != null)
            {
                form3.Hide();
            }
            if (form2 == null)
            {
                form2 = new Form2();
                form2.MdiParent = this;
            }

            this.SetClientSizeCore(form2.Width + formBorderWidthOffset, form2.Height + formBorderandCaptionHeightOffset);
            form2.Dock = DockStyle.Fill;
            form2.Show();
        }

        private void lİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form2 != null)
            {
                form2.Hide();
            }
            if (form3 == null)
            {
                form3 = new Form3();
                form3.MdiParent = this;
            }
            this.SetClientSizeCore(form3.Width + formBorderWidthOffset, form3.Height + formBorderandCaptionHeightOffset);
            form3.Dock = DockStyle.Fill;
            form3.Show();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            FileStream fileyaz = null;
            StreamWriter streamyaz = null;
            try
            {
                fileyaz = new FileStream("NUFUS.txt", FileMode.Truncate, FileAccess.Write);
                streamyaz = new StreamWriter(fileyaz);
                foreach (Person sahsiyet in nufus)
                {
                    streamyaz.WriteLine(String.Join(";", sahsiyet.Ad, sahsiyet.Soyad, sahsiyet.DogumGunu, sahsiyet.Cinsiyet, sahsiyet.MedeniHal));
                }       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException + "\n" + ex.StackTrace);
            }
            finally
            {
                streamyaz.Close();
                streamyaz = null;
                fileyaz.Close();
                fileyaz = null;
            }
        }
            //private void AcikFormlariKapat()
            //{
            //    Form[] formArray = this.MdiChildren;
            //    foreach (Form form in formArray)
            //    {
            //        form.Close();
            //    }
            //}
    
    }
}

//(sahsiyet.Ad, sahsiyet.Soyad,sahsiyet.DogumGunu,sahsiyet.Cinsiyet,sahsiyet.MedeniHal)