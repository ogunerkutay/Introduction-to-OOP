using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5sayininOrtalamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("5 adet sayinin 1.sini yaz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("5 adet sayinin 2.sini yaz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("5 adet sayinin 3.sini yaz");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("5 adet sayinin 4.sini yaz");
            int sayi4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("5 adet sayinin 5.sini yaz");
            int sayi5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sayilar: {sayi1} , {sayi2} , {sayi3} , {sayi4} , {sayi5} , Bunların ortalaması: {(sayi1+sayi2+sayi3+sayi4+sayi5)/5}");


        }
    }
}
