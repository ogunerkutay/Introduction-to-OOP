using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3sayidanenbuyukenkucuktoplayaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0, sayi2 = 0, sayi3 = 0, enkucuk = 0, enbuyuk =0,ortanca = 1;
            
            do
            {
                Console.WriteLine("Lütfen 3 sayıdan 1.sayıyı giriniz.");
                sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen 3 sayıdan 2.sayıyı giriniz.");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen 3 sayıdan 3.sayıyı giriniz.");
                sayi3 = Convert.ToInt32(Console.ReadLine());

                
                if (sayi1<sayi2 && sayi1 < sayi3)
                {
                    enkucuk = sayi1;
                    if (sayi2<sayi3)
                    {
                        enbuyuk = sayi3;
                        ortanca= sayi2;
                    }
                    else
                    {
                        enbuyuk = sayi2;
                        ortanca = sayi3;
                    }
                }else if (sayi2<sayi1 && sayi2<sayi3)
                {
                    enkucuk = sayi2;
                    if (sayi1 < sayi3)
                    {
                        enbuyuk = sayi3;
                        ortanca = sayi1;
                    }
                    else
                    {
                        enbuyuk = sayi1;
                        ortanca=sayi3;
                    }
                }
                else
                {
                    enkucuk = sayi3;
                    if (sayi1 < sayi2)
                    {
                        enbuyuk = sayi2;
                        ortanca = sayi1;
                    }
                    else
                    {
                        enbuyuk = sayi1;
                        ortanca = sayi2;
                    }
                }
                if (ortanca==0)
                {
                    Console.WriteLine("ortanca 0'dır.");
                    break;
                }
                Console.WriteLine("Sonuç: " + ((enkucuk+enbuyuk)%ortanca));

            } while (true);
        }
    }
}
