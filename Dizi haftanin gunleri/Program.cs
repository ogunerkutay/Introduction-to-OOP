using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_haftanin_gunleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] haftaninGunleri = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            for (int i = haftaninGunleri.Length-1; i >= 0;  i--)
            {
                if (haftaninGunleri[i] == "Cumartesi" || haftaninGunleri[i] == "Pazar")
                {
                    Console.WriteLine(haftaninGunleri[i] + " (Tatil)");
                }
                else
                {
                    Console.WriteLine(haftaninGunleri[i]);
                }
            }
        }
    }
}
