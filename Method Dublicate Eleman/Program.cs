using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Dublicate_Eleman
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] {55,1, 1, 2, 6, 3, 3, 5, 44, 44,55,55,55,55,55, 8165156 };
            int dub = DublicateBul(arr);
            Console.WriteLine(dub);
        }

        private static int DublicateBul(int[] dizi)
        {
            int dup = 0;
            int[] tekrarEdenler = new int[0];  
            
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = i+1; j < dizi.Length; j++)
                {
                    if (dizi[i] == dizi[j])
                    {
                        if (!tekrarEdenler.Contains(dizi[j]))
                        {
                            Array.Resize(ref tekrarEdenler, tekrarEdenler.Length+1);
                            tekrarEdenler[dup]=dizi[j]; 
                            dup++;
                            Console.WriteLine(dizi[j]);
                        }
                        
                    }

                }
            }
            return dup;
        }
    }
}
