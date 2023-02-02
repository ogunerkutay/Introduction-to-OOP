using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAV_DENEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int girilensayi = 0;
            string girilendeger = string.Empty;
            bool isNumeric = false;
            int basamak = 0;

            do
            {
                Console.WriteLine("Lütfen basamaklarını istediğiniz pozitif tam sayıyı giriniz! Çıkmak için exit yazabilirsiniz!");
                girilendeger = Console.ReadLine();
                if (girilendeger == "exit")
                {
                    Environment.Exit(0);
                }
                isNumeric = int.TryParse(girilendeger, out girilensayi);
                if (!isNumeric)
                {
                    Console.WriteLine("Uygunsuz değer girdiniz!!");
                }
            } while (!isNumeric || girilensayi < 0);


            while (girilensayi > 0)
            {
                Console.WriteLine(girilensayi % 10 + " x 1" + new String('0', basamak) + " = " + girilensayi % 10 + new String('0', basamak));
                girilensayi /= 10;
                basamak++;
            }


        }

    }
}


