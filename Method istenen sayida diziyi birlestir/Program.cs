using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_istenen_sayida_diziyi_birlestir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int herhangiBirStringDizisiElemanSayisi = 10;
            string[] herhangiBirStringDizisi = new string[herhangiBirStringDizisiElemanSayisi];
            for (int i = 0; i < herhangiBirStringDizisiElemanSayisi; i++)
            {
                herhangiBirStringDizisi[i] = random.Next(0, 1000).ToString();
            }

            //string[] yenidizi =  DiziBirlestir(herhangiBirStringDizisi, herhangiBirStringDizisi);
            //string[] yenidizi = DiziBirlestirArraySonsuz(herhangiBirStringDizisi, herhangiBirStringDizisi);
            string[] yenidizi = DiziBirlestirArraySonsuz(herhangiBirStringDizisi);
            for (int i = 0; i < yenidizi.Length; i++)
            {
                Console.WriteLine("Yenidizi : " + yenidizi[i]);
            }

        }
        //static string[] DiziBirlestir(string[] birinciDizi, string[] ikinciDizi)
        //{
        //    string[] birlesenDizi = new string[birinciDizi.Length + ikinciDizi.Length];
        //    for (int i = 0; i < birinciDizi.Length; i++)
        //    {
        //        birlesenDizi[i] = birinciDizi[i];
        //    }

        //    for (int i = 0; i < ikinciDizi.Length; i++)
        //    {
        //        birlesenDizi[birinciDizi.Length + i] = ikinciDizi[i];
        //    }

        //    return birlesenDizi;
        //}

        static string[] DiziBirlestirArray(string[] birinciDizi, string[] ikinciDizi)
        {
            string[] birlesenDizi = new string[birinciDizi.Length + ikinciDizi.Length];

            //array1.copyto(,);
            birlesenDizi = birinciDizi.Concat(ikinciDizi).ToArray();

            return birlesenDizi;
        }
        static int[] DiziBirlestirArray(int[] birinciDizi, int[] ikinciDizi)
        {
            int[] birlesenDizi = new int[birinciDizi.Length + ikinciDizi.Length];
            birlesenDizi = birinciDizi.Concat(ikinciDizi).ToArray();

            return birlesenDizi;
        }

        static string[] DiziBirlestirArraySonsuz(params string[][] diziler)
        {
            int topla = 0;
            foreach (var item in diziler)
            {
                topla += item.Length;
            }
            string[] birlesenDizi = new string[topla];
            int index = 0;
            foreach (var array in diziler)
            {
                //hatalı birlesenDizi = birlesenDizi.Concat(item).ToArray();
                foreach (var item in array)
                {
                    birlesenDizi[index]=item;
                    index++;
                }
            
            }

            return birlesenDizi;
        }
        static string[] DiziBirlestirArraySonsuz(params string[] diziler)
        {
            int topla = 0;
            foreach (var item in diziler)
            {
                topla++;
            }
            string[] birlesenDizi = new string[topla];
            int index = 0;
            foreach (var item in diziler)
            {
                    birlesenDizi[index] = item;
                    index++;
            }

            return birlesenDizi;
        }

    }
}
