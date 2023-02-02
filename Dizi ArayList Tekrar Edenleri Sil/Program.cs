using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_ArayList_Tekrar_Edenleri_Sil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arlist1 = new ArrayList();

            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            ArrayTemizle(ref arlist1);
            
            for (int i = 0; i < arlist1.Count; i++)
            {
                Console.WriteLine(arlist1[i]);
            }

        }
    static void ArrayTemizle(ref ArrayList array)
        {
            for(int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++)
                { 
                    if (i != j)
                    {
                        if (array[i] != null)
                        {
                            if (array[i].Equals(array[j]))
                            {
                                array.RemoveAt(j);
                            }
                        }
                    }
                }
            }
        array.TrimToSize();
        }
    
    }
}
