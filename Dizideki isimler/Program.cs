using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizideki_isimler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int memberCount;
            Console.WriteLine("Kaç adet isim girişi yapacaksınız?");
            memberCount = int.Parse(Console.ReadLine().Trim());

            string[] isimler = new string[memberCount];

            for (int i = 0; i < memberCount; i++)
            {
                Console.WriteLine("Lütfen {0}. ismi giriniz",i+1);
                isimler[i] = Console.ReadLine();

            }

            for (int i = 0; i < memberCount; i++)
            {
                Console.WriteLine(isimler[i]);               
            }


        }
    }
}
