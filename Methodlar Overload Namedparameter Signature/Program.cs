using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar_Overload_Namedparameter_Signature
{
    internal class Program
    {
        static string ad;
        static string soyad;
        static void Main(string[] args)
        {
            KullanicidanVeriAl();
            KullaniciInfosunuYAz();
            KullaniciInfosunuYAz(ad);
            KullaniciInfosunuYAz(ad,soyad);
            KullaniciInfosunuYAz(adi: ad, soyadi: soyad);

        }
        /// <summary>
        /// Kullanıcıdan Veri Alır.
        /// </summary>
        static void KullanicidanVeriAl()
        {
            Console.WriteLine("ad : ");
            ad = Console.ReadLine();
            Console.WriteLine("soyad : ");
            soyad = Console.ReadLine();
        }
        /// <summary>
        /// Kullanıcı Infosunu Yazar.
        /// </summary>
        static void KullaniciInfosunuYAz()
        {
            Console.WriteLine(ad + " " + soyad);
        }
        /// <summary>
        /// Kullanıcı Infosunu Yazar.
        /// </summary>
        /// <param name = "isim" > "veritipi string" </param>
        static void KullaniciInfosunuYAz(string isim)
        {
            Console.WriteLine(isim);
        }
        /// <summary>
        /// Kullanıcı Infosunu Yazar.
        /// </summary>
        static void KullaniciInfosunuYAz(string adi, string soyadi)
        {
            Console.WriteLine(adi + " " + soyadi);
        }



    }
}
