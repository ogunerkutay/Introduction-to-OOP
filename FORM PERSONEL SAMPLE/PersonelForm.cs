using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_PERSONEL_SAMPLE
{
    public partial class PersonelForm : Form
    {
        List<Person> _personList = new List<Person>();
        List<string> _hobilist = new List<string>();
        public PersonelForm()
        {
            InitializeComponent();

            this.btnKaydet.Click += new EventHandler(SavePerson);
        }

        private void SavePerson(object sender, EventArgs e)
        {
            string _isim = string.Empty;
            string _soyad = string.Empty;
            DateTime _dogumTarihi;
            string _email = string.Empty;
            string _telefon = string.Empty;
            int _yas;
            string _cinsiyet = string.Empty;
            string _egitim = string.Empty;
            string _hobiler = string.Empty;

            _isim = txtAd.Text.Trim();
            _soyad = txtSoyad.Text.Trim();
            _dogumTarihi = dtpDogumTarihi.Value;
            _email = txtEmail.Text.Trim();
            _telefon = mTxtTelefon.Text.Trim();
            _yas = int.Parse(nUpYas.Value.ToString());
            _cinsiyet = GetInfo(grpBoxCinsiyet);
            _egitim = GetInfo(grpBoxEgitim);
            //_hobiler = GetHobiInfo();
            _hobiler = GetHobiInfoWithList();


            Person _person = new Person();
            _person.isim = _isim;
            _person.soyad = _soyad;
            _person.dogumTarihi = _dogumTarihi;
            _person.email = _email;
            _person.telefon = _telefon;
            _person.yas = _yas;
            _person.cinsiyet = _cinsiyet;
            _person.egitim = _egitim;
            _person.hobiler = _hobiler;

            if (!_personList.Contains(_person))
            {
                _personList.Add(_person);
            }

            ClearForm();

            AddPersonListToListView(_personList);

        }

        private void AddPersonListToListView(List<Person> personList)
        {
            lvPersonel.Items.Clear();
            int _index = 0;
            foreach (Person person in personList)
            {
                lvPersonel.Items.Add($"{person.isim} {person.soyad}");
                lvPersonel.Items[_index].SubItems.Add(person.dogumTarihi.ToString("yyyy-MM-dd HH:mm-ss"));
                lvPersonel.Items[_index].SubItems.Add(person.email);
                lvPersonel.Items[_index].SubItems.Add(person.telefon);
                lvPersonel.Items[_index].SubItems.Add(person.yas.ToString());
                lvPersonel.Items[_index].SubItems.Add(person.cinsiyet);
                lvPersonel.Items[_index].SubItems.Add(person.egitim);
                lvPersonel.Items[_index].SubItems.Add(person.hobiler);
                _index++;
            }

        }

        private void ClearForm()
        {
            foreach (Control item in this.Controls)
            {
                Type _t = item.GetType();
                switch (_t.ToString())
                {
                    case "System.Windows.Forms.TextBox":
                        {
                            TextBox _txt = (TextBox)item;
                            _txt.Clear();
                            break;
                        }
                    case "System.Windows.Forms.DateTimePicker":
                        {
                            DateTimePicker _dtp = (DateTimePicker)item;
                            _dtp.Value = DateTime.Now;
                            break;
                        }
                    case "System.Windows.Forms.MaskedTextBox":
                        {
                            MaskedTextBox mTxt = (MaskedTextBox)item;
                            mTxt.Clear();
                            break;
                        }
                    case "System.Windows.Forms.NumericUpDown":
                        {
                            NumericUpDown _nUpDown = (NumericUpDown)item;
                            _nUpDown.Value = 1;
                            break;
                        }
                    case "System.Windows.Forms.GroupBox":
                        {
                            GroupBox _grp = (GroupBox)item;
                            SetInitialValuesForGroupBoxes(_grp);
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void SetInitialValuesForGroupBoxes(GroupBox grp)
        {
            int _type = int.Parse(grp.Tag.ToString());
            switch (_type)
            {
                case 0:
                    foreach (Control item in grp.Controls)
                    {
                        if (item.GetType() == typeof(RadioButton))
                        {
                            RadioButton _rd = (RadioButton)item;
                            _rd.Checked = false;
                        }
                    }
                    break;
                case 1:
                    foreach (Control item in grp.Controls)
                    {
                        if (item.GetType() == typeof(CheckBox))
                        {
                            CheckBox _rd = (CheckBox)item;
                            _rd.Checked = false;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private string GetHobiInfoWithList()
        {
            string _returnValue = string.Empty;

            foreach (Control item in grpHobi.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    CheckBox _chk = (CheckBox)item;
                    if (_chk.Checked == true)
                    {
                        _hobilist.Add(_chk.Text);
                    }
                }
            }
            _returnValue = String.Join(", ", _hobilist);
            return _returnValue;
        }

        //private string GetHobiInfo()
        //{
        //    string _returnValue = string.Empty;
        //    int _sayi = GetSelectedCount();
        //    string[] _hobiler = new string[_sayi];
        //    int _index = 0;
        //    foreach (Control item in grpHobi.Controls)
        //    {
        //        if (item.GetType()==typeof(CheckBox))
        //        {
        //            CheckBox _chk = (CheckBox)item;
        //            if (_chk.Checked == true)
        //            {
        //                _hobiler[_index] = _chk.Text;
        //                _index++;
        //            }
        //        }
        //    }
        //    _returnValue = String.Join(", ", _hobiler);
        //    return _returnValue;
        //}

        //private int GetSelectedCount()
        //{
        //    int _returnValue = 0;
        //    int count = 0;
        //    foreach (Control item in grpHobi.Controls)
        //    {
        //        if (item.GetType() == typeof(CheckBox))
        //        {
        //            CheckBox _chk = (CheckBox)item;
        //            if (_chk.Checked == true)
        //            {
        //                count++;
        //            }
        //        }
        //    }


        //    _returnValue = count;
        //    return _returnValue;


        //}

        private string GetInfo(GroupBox grpBox)
        {
            string _returnValue = string.Empty;
            foreach (Control item in grpBox.Controls)
            {
                if (item.GetType() == typeof(RadioButton))
                {
                    RadioButton _rd = (RadioButton)item;
                    if (_rd.Checked)
                    {
                        _returnValue = _rd.Text.Trim();
                        break;
                    }

                }
            }

            return _returnValue;
        }


        private void btnEgitimTemizle_Click(object sender, EventArgs e)
        {

            foreach (Control item in grpBoxEgitim.Controls)
            {
                if (item.GetType() == typeof(RadioButton))
                {
                    RadioButton _rd = (RadioButton)item;
                    _rd.Checked = false;
                }
            }
        }

        private void btnHobiTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in grpHobi.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    CheckBox _rd = (CheckBox)item;
                    _rd.Checked = false;
                }
            }
        }
    }
}
