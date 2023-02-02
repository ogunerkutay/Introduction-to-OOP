using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaceSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yonetici _yonetici = new Yonetici();
            _yonetici.Id = 1000;
            _yonetici.Ad = "John";
            _yonetici.Soyad = "Doe";
            _yonetici.Deparman = "Sales";
            _yonetici.Maas = 20000;
            _yonetici.BagliCalisanIds = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine(_yonetici.getYoneticiInfo());

            Calisan _calisan = new Calisan();
            _calisan.Id = 1;
            _calisan.Ad = "Tom";
            _calisan.Soyad = "12000";
            _calisan.Departman = "IT";
            _calisan.YoneticiId = 1000;
            Console.WriteLine(_calisan.getCalisanInfo());

        }
    }
}
