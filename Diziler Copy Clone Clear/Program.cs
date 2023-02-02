using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_Copy_Clone_Clear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Random rastgelesayilar = new Random();

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = rastgelesayilar.Next(0, 1000);  
            }
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('*', 100));

            //Dizinin tüm elemanlarını farklı bir diziye kopyalama
            int[] destNumbers = new int[20];    
            Array.Copy(numbers,destNumbers,numbers.Length);

            //Dizinin beş elemanını farklı bir diziye kopyalama
            Array.Copy(numbers, destNumbers, 5);

            // İlk dizinin 3. elemanından başla 2. dizinin 6. elemanından itibaren 6 elamanı kopyala
            Array.Copy(numbers,3, destNumbers, 6,6);
            
            //Diziyi klonlar
            int[] cloneNumbers = (int[])numbers.Clone();

            //Diziyi temizler
            Array.Clear(numbers,5,6);



        }

    }
}
