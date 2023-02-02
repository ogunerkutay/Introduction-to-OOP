using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOPARK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aractipi = "";
            double parksuresi = 0;
            double otomobil = 5;
            double minibus = 6;
            double ticari = 6.5;
            double otomobilzammi = 1.2;
            double minibuszammi = 0.215;
            double ticarizammi = 0.25;
            double toplam = 0;



            do
            {
                Console.WriteLine("Lütfen aracınızın tipini belirtiniz: otomobil, minibüs, ticari");
                aractipi = Console.ReadLine();
                if (aractipi != "otomobil" && aractipi != "minibüs" && aractipi != "ticari")
                {
                    Console.WriteLine("lütfen belirtilenler dışında bir değer girmeyin!");
                }
                else
                {
                    Console.WriteLine("Lütfen aracınızın park süresini saat olarak belirtiniz: ");
                    parksuresi = Convert.ToInt32(Console.ReadLine());
                    if (parksuresi<0)
                    {
                        Console.WriteLine("Park süresi negatif olamaz!");
                    }
                    else
                    {
                        if (parksuresi >= 0 || parksuresi <= 1) ;
                        {
                            parksuresi = 1;
                        }
                        if (aractipi == "otomobil")
                        {
                            for (int i = 1; i < parksuresi+1; i++)
                            {
                                toplam = toplam + otomobil * Math.Pow(otomobilzammi, i - 1);
                            }

                        }
                        else if (aractipi == "minibüs")
                        {
                            for (int i = 1; i < parksuresi + 1; i++)
                            {
                                toplam = toplam + minibus * Math.Pow(minibuszammi, i - 1);
                            }
                        }
                        else if (aractipi == "ticari")
                        {
                            for (int i = 1; i < parksuresi + 1; i++)
                            {
                                toplam = toplam + ticari * Math.Pow(ticarizammi, i - 1);
                            }
                        }
                        Console.WriteLine("Park ücretiniz {0} TL'dir.",toplam);
                       
                    }
                
                }
                toplam = 0;

            } while (true);
        }
    }
}
