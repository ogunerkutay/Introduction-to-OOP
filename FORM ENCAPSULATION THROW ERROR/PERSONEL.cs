using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORM_ENCAPSULATION_THROW_ERROR
{
    public class PERSONEL
    {

        private string ad;
        private string soyad;
        private string medenihal;
        private int personelno;
        private string tcno;
        private string email;
        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                if (value.Length >=2) ad = value;
                else throw new Exception("nayır nolamaz isim 2 karakterden az olamaz");
            }
        }

        public string SoyAd
        {
            get{ return soyad; }
            set
            {
                if (value.Length >= 2) soyad = value;
                else throw new Exception("nayır nolamaz soyad 2 karakterden az olamaz");
            }
        }
        public string Medenihal { get { return medenihal; } set { medenihal = value; } }

        public int Personelno
        {
            get { return personelno; }
            set
            {
                if (value >= 1000 && value <= 9999) personelno = value;
                else throw new Exception("Personel no 4 basamaklı olmalıdır");
            }
        }
        public string TCno
        {
            get { return tcno; }
            set
            {
                if (value.Length == 11) tcno = value;
                else throw new Exception("TC no 11 basamaklı olmalıdır");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value.EndsWith("@bilgeadam.com")) email = value;
                else throw new Exception("Şirket maili giriniz");
            }
        }



    }
}
