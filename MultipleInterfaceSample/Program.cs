using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaceSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot _robot = new Robot();
            _robot.CalismaSaati = 300;
            _robot.Departman = "Üretim";
            _robot.YoneticiId = 1000;

            Musteri _musteri = new Musteri();
            _musteri.Id = 10000;
            _musteri.Ad = "John";
            _musteri.Soyad = "Doe";
            _musteri.Adres = "USA";
            _musteri.VergiDairesi = "USA";
            _musteri.VergiNumarasi = "68666566";
            _musteri.TicariUnvan = "John Doe A.Ş.";

            Yonetici _yonetici = new Yonetici();
            _yonetici.Id = 500;
            _yonetici.Ad = "Tom";
            _yonetici.Soyad = "Doe";
            _yonetici.Adres = "USA";
            _yonetici.CalismaSaati = 100;
            _yonetici.Departman = "Marketing";
            _yonetici.YoneticiId = 4;

            Personel _personel = new Personel();
            _personel.Id = 100;
            _personel.Ad = "Jeyn";
            _personel.Soyad = "Doe";
            _personel.Adres = "UK";
            _personel.CalismaSaati = 150;
            _personel.Departman = "PR";
            _personel.YoneticiId = 3;


        }
    }
}
