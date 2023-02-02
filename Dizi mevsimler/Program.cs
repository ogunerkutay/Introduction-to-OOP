using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_mevsimler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mevsimler = { "KIŞ", "BAHAR", "YAZ", "SONBAHAR" };
            for (int i = 0; i < mevsimler.Length; i++)
            { 
                Console.WriteLine("ÜLKEMİZDEKİ MEVSİMLER : {0}", mevsimler[i]);
            }
        }
    }
}
