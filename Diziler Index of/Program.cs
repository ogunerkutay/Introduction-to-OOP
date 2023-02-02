using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_Index_of
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] cities = new string[]
            {
                "İstanbul","Ankara","Bursa","İzmir","Ankara","Samsun","Ordu","Muğla","Antalya","Ankara","İstanbul","Bursa","Çanakkale"
            };
            String searchCity = String.Empty;
            Console.WriteLine("Arayacağınız Şehir Bilgisini Giriniz: ");
            searchCity = Console.ReadLine().Trim();

            int firtIndex = Array.IndexOf(cities, searchCity);
            Console.WriteLine("Aradığınız şehrin İlk Index Değeri : " + firtIndex);
            int lastIndex = Array.LastIndexOf(cities, searchCity);
            Console.WriteLine("Aradığınız şehrin Son Index Değeri : " + lastIndex);


        }
    }
}
