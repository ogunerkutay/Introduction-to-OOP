using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Int_dizisi_MinMaxFark_EkranaYazdir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int herhangiBirIntDizisiElemanSayisi = random.Next(0,20);
            int[] herhangiBirIntDizisi = new int[herhangiBirIntDizisiElemanSayisi];
            for (int i = 0; i < herhangiBirIntDizisiElemanSayisi; i++)
            {
                herhangiBirIntDizisi[i] = random.Next(0,1000);
            }

            for (int i = 0; i < herhangiBirIntDizisiElemanSayisi; i++)
            {
                Console.WriteLine(herhangiBirIntDizisi[i]);
            }

            Console.WriteLine(new String('*',100));

            MinMaxFarkEkranaYaz(herhangiBirIntDizisi);
        
        
        }
        static void MinMaxFarkEkranaYaz(int[] herhangiBirIntDizisi)
        {
            int ufaksayi = herhangiBirIntDizisi.Min();
            int buyuksayi = herhangiBirIntDizisi.Max();
            int ufaksayiIndex = Array.IndexOf(herhangiBirIntDizisi,ufaksayi);
            int buyuksayiIndex = Array.IndexOf(herhangiBirIntDizisi, buyuksayi);
            
            int fark = buyuksayi - ufaksayi;
            Console.WriteLine("Büyük sayı {0}'nın Index'i : {1}", buyuksayi,buyuksayiIndex);
            Console.WriteLine("Küçük sayı {0}'nın Index'i : {1}", ufaksayi,ufaksayiIndex);
            Console.WriteLine("Büyük sayı ile küçük sayının farkı " + fark);
        }
    }
}
