using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PersonelIzınEventSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel _personel = new Personel()
            {
                TcKimlikNo = 11111111,
                SicilNo = "1231231",
                Ad = "John",
                Soyad = "Doe",
                IzinGunSayisi = 20

            };

            _personel.IzinEvent += new Personel.IzinGunSayisiEventHandler(IzinUyari);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{_personel.Ad} {_personel.Soyad} " + $"Personeli kaç gün izin kullanacak ? ");
                byte _kullanilacakIzinGun = byte.Parse(Console.ReadLine());
                _personel.IzinGunSayisi -= _kullanilacakIzinGun;

                if (_personel.IzinGunSayisi < 5)
                {
                    break;
                }
                Console.WriteLine($"Kalan izin gün sayisi : {_personel.IzinGunSayisi}");
                Console.WriteLine(new String('*', 100));
                Thread.Sleep(5000);


            }


        }

        private static void IzinUyari()
        {
            Console.WriteLine("5 günden az izin süreniz kaldı");
        }

    }



    public class Personel
    {
        public delegate void IzinGunSayisiEventHandler();
        public event IzinGunSayisiEventHandler IzinEvent;

        private long _tcKimlikNo;
        private string _sicilNo;
        private byte _izinGunSayisi;
        private string _ad;
        private string _soyad;

        public long TcKimlikNo 
        { 
            get => _tcKimlikNo; 
            set
            {
                _tcKimlikNo = value;
            }
            
        }
        public string SicilNo { get => _sicilNo; set => _sicilNo = value; }
        public byte IzinGunSayisi 
        {
            get => _izinGunSayisi; 
            set
            {
                _izinGunSayisi = value;
                if (_izinGunSayisi < 5 && IzinEvent != null)
                {
                    IzinEvent();
                }
            } 
        }
        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
 
    }
}
