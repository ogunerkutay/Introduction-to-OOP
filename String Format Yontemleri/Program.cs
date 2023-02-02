using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Format_Yontemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 1;
            int sayi2 = 2;
            int sayi3 = 3;
            string msg1 = "Yöntem " + sayi1;
            string msg2 = String.Format($"Yöntem {sayi2}");
            string msg3 = String.Format("Yöntem {0}", sayi3);
            string msg4 = String.Concat(msg1, msg2, msg3);
            Console.WriteLine(msg1);
            Console.WriteLine(msg2);
            Console.WriteLine(msg3);
            Console.WriteLine(msg4);
            Console.WriteLine("Mesaj 1 ile 2 aynı mı? : " + string.Compare(msg1, msg2, true));
            string aranan = "Yöntem";
            if (msg1.Contains(aranan))
            {
                Console.WriteLine("Mesaj 1 " + aranan + " içerir");
            }
            else
            {
                Console.WriteLine("Mesaj 1 " + aranan + " içermez");
            }


            if (msg2.StartsWith(aranan))
            {
                Console.WriteLine("Mesaj 2 " + aranan + " ile başlar");
            }
            else
            {
                Console.WriteLine("Mesaj 2 " + aranan + " ile başlamaz");
            }
            string aranan2 = "1";
            if (msg1.EndsWith(aranan))
            {
                Console.WriteLine("Mesaj 2 " + aranan + " ile biter");
            }
            else
            {
                Console.WriteLine("Mesaj 2 " + aranan + " ile bitmez");
            }
            msg1 = msg1.Replace(msg1, msg2);
            Console.WriteLine("Mesaj 1 artık 2 oldu" + msg1);
            char[] karakterDizisi = msg1.ToCharArray();
            for (int i = 0; i < karakterDizisi.Length; i++)
            {
                Console.WriteLine(karakterDizisi[i]);
            }
            Console.WriteLine("Mesaj 1'deki Y'nin yeri " + msg1.IndexOf("Y"));
            msg1 = msg1.Insert(0, "N");
            Console.WriteLine(msg1);
            msg1 = msg1.Remove(msg1.IndexOf("N"), 1);
            Console.WriteLine(msg1);
            msg1 = msg1.PadLeft(10, '0');
            Console.WriteLine(msg1);
            msg1 = msg1.PadRight(11, '0');
            Console.WriteLine(msg1);

            msg1 = msg1.Substring(2, msg1.IndexOf("m") - 2);
            Console.WriteLine(msg1);
            msg1 = msg1 + "    ";
            msg1 = msg1.Trim();
            Console.WriteLine(msg1);
            msg1 = msg1.ToUpper();
            Console.WriteLine(msg1);
            msg1 = msg1.ToLower();
            Console.WriteLine(msg1);
            char[] asd = msg2.ToCharArray();
            msg1 = string.Join(" ",new string[]{"Ali","ata","bak"});
            Console.WriteLine(msg1);
        }
    }
}
