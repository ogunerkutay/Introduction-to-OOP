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

namespace FileStream
{
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();

            buttonKAYDET.Click += new EventHandler(SavePersonToFile);
            buttonYUKLE.Click += new EventHandler(LoadPersonFromFile);
            textBox1.Enter += new EventHandler(ChangeControlBackgroundColor);
            textBox2.Enter += new EventHandler(ChangeControlBackgroundColor);
            numericUpDown1.Enter += new EventHandler(ChangeControlBackgroundColor);
            //dateTimePicker1.Enter += new EventHandler(ChangeControlBackgroundColor);
            textBox1.Leave += new EventHandler(ClearControlBackgroundColor);
            textBox2.Leave += new EventHandler(ClearControlBackgroundColor);
            numericUpDown1.Leave += new EventHandler(ClearControlBackgroundColor);


        }

        private void ClearControlBackgroundColor(object? sender, EventArgs e)
        {

            if (sender.GetType() == typeof(TextBox))
            {
                TextBox _txt = (TextBox)sender;
                _txt.BackColor = Color.White;
            }
            else if (sender.GetType() == typeof(NumericUpDown))
            {
                NumericUpDown _nud = (NumericUpDown)sender;
                _nud.BackColor = Color.White;
            }
            else if (sender.GetType() == typeof(DateTimePicker))
            {
                DateTimePicker _dtp = (DateTimePicker)sender;
                _dtp.BackColor = Color.White;
            }
        }

        private void ChangeControlBackgroundColor(object? sender, EventArgs e)
        {

            if (sender.GetType() == typeof(TextBox))
            {
                TextBox _txt = (TextBox)sender;
                _txt.BackColor = Color.Aqua;
            }
            else if(sender.GetType() == typeof(NumericUpDown))
            {
                NumericUpDown _nud = (NumericUpDown)sender;
                _nud.BackColor = Color.Aqua;
            }
            else if (sender.GetType() == typeof(DateTimePicker))
            {
                DateTimePicker _dtp = (DateTimePicker)sender;
                _dtp.BackColor = Color.Aqua;
            }
        }

        private void LoadPersonFromFile(object? sender, EventArgs e)
        {
            System.IO.FileStream _fs;
            StreamReader _strRead = null;
                                    
            try
            {
                listView1.Items.Clear();
                _fs = new System.IO.FileStream("Person.txt", FileMode.Open, FileAccess.Read);
                _strRead = new StreamReader(_fs);
                
                string _line = _strRead.ReadLine();
                while (_line != null)
                {
                    AddPersonToListView(_line);
                    _line = _strRead.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _strRead.Close();
                _strRead = null;
            }
        }

        private void AddPersonToListView(string line)
        {
            string[] _personList = line.Split(';');
            int _index = listView1.Items.Count;
            listView1.Items.Add(_personList[0].ToString());
            listView1.Items[_index].SubItems.Add(_personList[1]);
            listView1.Items[_index].SubItems.Add(_personList[2].ToString());

        }

        private void SavePersonToFile(object? sender, EventArgs e)
        {
            string _ad = string.Empty;
            string _soyad = string.Empty;
            int _yas = 0;
            DateTime _dogumTarihi;
            string _line = string.Empty;
            System.IO.FileStream _fs;
            StreamWriter _swWrite = null;

            try
            {
                _ad = textBox1.Text.Trim();
                _soyad = textBox2.Text.Trim();
                _yas = int.Parse(numericUpDown1.Value.ToString().Trim());
                _dogumTarihi = dateTimePicker1.Value;
                _line = $"{_ad} {_soyad};{_yas};{_dogumTarihi.ToString()}";
                _fs = new System.IO.FileStream("Person.txt", FileMode.Append, FileAccess.Write);

                _swWrite = new StreamWriter(_fs);
                _swWrite.WriteLine(_line);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException + "\n" + ex.StackTrace);
            }
            finally
            {
                _swWrite.Close();
                _swWrite=null;
            }
        }

    }
}
