using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_indexteki_deger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = { 435, 43, 543, 53, 53, 7, 645, 3, 5, 435, 46, 5, 56, 435, 3, 443, 565, 5, 654, 53 };
            int indexDeger = 0;
            bool isNumeric = false;
            do
            {
                if (indexDeger > sayilar.Length - 1) Console.WriteLine("Girilen index dizi dışında. Lütfen (0 ile " + sayilar.Length + " arası bir index değeri belirtin " + sayilar.Length + " hariç");
                else if (indexDeger < 0) Console.WriteLine("Girilen index dizi dışında. Lütfen (0 ile " + sayilar.Length + " arası bir index değeri belirtin " + sayilar.Length + " hariç");  
                Console.WriteLine("Lütfen bir (0 ile " + sayilar.Length + " arası bir index değeri belirtin " + sayilar.Length + " hariç");
               isNumeric = int.TryParse(Console.ReadLine(), out indexDeger);
            } while (isNumeric==false || indexDeger<0 || indexDeger >= sayilar.Length);
            Console.WriteLine("İndex'teki değer : " + sayilar[indexDeger]); 
            
        }
    }
}
