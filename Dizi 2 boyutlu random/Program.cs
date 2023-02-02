using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_2_boyutlu_random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgelesayilar = new Random();
            
            int[,] sayilar = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sayilar[i, j] = rastgelesayilar.Next(0, 1000);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Matrisin {0}. satırındaki {1}. sütunundaki sayı = {2}",i,j,sayilar[i,j]);
                }
            }



        }
    }
}
