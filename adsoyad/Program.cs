using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adsoyad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adini söyle: ");
            string ad=Console.ReadLine();
            Console.WriteLine("soyadini söyle: ");
            string soyad=Console.ReadLine();
            Console.WriteLine($"Ad: {ad} Soyad: {soyad}");
        }
    }
}
