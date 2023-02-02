using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daire_Alani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dairenin R'sini giriniz: ");
            double yaricap = Convert.ToInt32(Console.ReadLine());
            double dairealani=0;
            double dairecevresi = 0;
            if (yaricap<=0)
            {
                Console.WriteLine("Negatif veya 0 olamaz!");
            }
            else
            {
                dairealani = Math.PI * yaricap * yaricap;
                dairecevresi = 2 * Math.PI * yaricap;
                Console.WriteLine("Dairenin Alanı: {0} Dairenin Çevresi: {1}",dairealani,dairecevresi);
            }

        }
    }
}
