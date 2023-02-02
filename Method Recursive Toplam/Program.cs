using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Recursive_Toplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc = Topla(3);
            Console.WriteLine(sonuc);
        }
        static int Topla(int sayi)
        {
            int sonuc = 0;
            if (sayi!=0)
            {
                sonuc = sayi + Topla(sayi - 1);
            }
            
            return sonuc;
        }
    }
}
