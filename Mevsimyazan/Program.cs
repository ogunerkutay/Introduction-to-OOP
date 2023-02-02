using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mevsimyazan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double okunan;
            string okuyorum;
            bool isNumeric=false;   
            do
            {
                Console.WriteLine("Lütfen bir ay numarası girin (1-12) : ");
                okuyorum = Console.ReadLine();
                isNumeric = double.TryParse(okuyorum, out okunan);
                if (!isNumeric || okunan<1 || okunan >12)
                {
                    Console.WriteLine("Lütfen bir ay numarası giriniz (1-12) !");
                }
                else
                {
                    switch (okunan)
                    {
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine("KIŞ MEVSİMİ");
                            break;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("BAHAR MEVSİMİ");
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("YAZ MEVSİMİ");
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("SONBAHAR MEVSİMİ");
                            break;
                    }
                }

            } while (true);


        }
    }
}
