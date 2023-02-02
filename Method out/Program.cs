using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool oldumu = false;
            double sayi1 = 10;
            double sayi2 = 5;
            double sonuc = 0;
            
            oldumu = BolmeIslemi(sayi1,sayi2,out sonuc);

            Console.WriteLine(oldumu + " " + sonuc);
        }
        static bool BolmeIslemi(double sayi1, double sayi2,out double sonuc)
        {
            bool oldumu=false;
            if (sayi2==0)
            {
                oldumu = false;
                sonuc = 0;
            }
            else
            {
                oldumu = true;
                sonuc = sayi1 / sayi2;
            }
            return oldumu;
        }
            
            
            }
}
