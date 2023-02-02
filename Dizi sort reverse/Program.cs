using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_sort_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgelesayilar = new Random();

            int[] sayilar = new int[3];
            for (int i = 0; i < 3; i++)
            {

             
                    sayilar[i] = rastgelesayilar.Next(0, 1000);
                
            }
            for (int i = 0; i < 3; i++)
            {

                    Console.WriteLine("Dizinin {0}. satırındaki sayı : {1}",i, sayilar[i]);
               
            }


            Console.WriteLine(new string('*', 100));

            Console.WriteLine("Küçükten büyüğe");
            Array.Sort(sayilar);
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(sayilar[i]);

            }
            Console.WriteLine(new string('*', 100));
            Console.WriteLine("Büyükten küçüğe");
            Array.Reverse(sayilar);
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(sayilar[i]);

            }

        }
    }
}
