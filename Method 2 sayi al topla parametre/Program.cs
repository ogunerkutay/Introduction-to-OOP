using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_2_sayi_al_topla_parametre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(3, 5));
        }
        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int Topla(int sayi1, int sayi2,int sayi3)
        {
            return  sayi1 + sayi2 + sayi3;
        }

        static int Topla(params int[] sayilar)
        {

            return sayilar.Sum();
        }
    }
}
