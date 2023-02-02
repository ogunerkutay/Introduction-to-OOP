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

namespace StreamSample
{
    public partial class Person : Form
    {
        
        const string _path = @"C:\DosyaIslemleri\";
        //const string _path = "C:\\DosyaIslemleri\\";
        const string _filename = "PersonList.txt";

        public Person()
        {
            InitializeComponent();

            this.buttonKAYDET.Click += new EventHandler(SavePersonToFile);
            this.buttonYUKLE.Click += new EventHandler(LoadPersonlistFromFile);
        }

        private void LoadPersonlistFromFile(object? sender, EventArgs e)
        {
            string _fullPath = Path.Combine(_path, _filename);
            StreamReader _strRead = null;

            try
            {
                listView1.Items.Clear();
                _strRead = new StreamReader(_fullPath);
                string _line = _strRead.ReadLine();
                while (_line!=null)
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
            string _fullPath = Path.Combine(_path, _filename);
            StreamWriter _strWrite = null;
            string _ad = textBox1.Text;
            string _soyad = textBox2.Text;
            int _yas = int.Parse(numericUpDown1.Value.ToString());
            DateTime _dogumTarihi = dateTimePicker1.Value;
            string _line = $"{_ad} {_soyad};{_yas};{_dogumTarihi}";

            try
            {
                _strWrite = new StreamWriter(_fullPath,true);
                _strWrite.WriteLine(_line);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _strWrite.Close();
                _strWrite=null;
            }

            ClearForm();

        }

        private void ClearForm()
        {
            foreach (Control _cnt in this.Controls)
            {
                if (_cnt.GetType()==typeof(TextBox))
                {
                    TextBox _txt = (TextBox)_cnt;
                    _txt.Clear();
                }
                else if (_cnt.GetType()==typeof(NumericUpDown))
                {
                    NumericUpDown _nud = (NumericUpDown)_cnt;
                    _nud.Value = 1;
                }
                else if (_cnt.GetType() == typeof(DateTimePicker))
                {
                    DateTimePicker _dtp = (DateTimePicker)_cnt;
                    _dtp.Value = DateTime.Now;
                }
            }
            textBox1.Focus();
        }
    }
}
