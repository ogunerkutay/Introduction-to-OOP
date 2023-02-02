using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1 - Syntax Hataları
             * 2 - Runtime Hataları(Çalışma Zamanı Hataları)
             * 3 - Mantıksal Hatalar - sıfıra bölme gibi
             *  try
             *  {
             *      Çalışmasını istediğim Kodun Yazıldığı Blok
             *  }
             *  catch(Exception ex)
             *  {
             *  }
             *  finally
             *  {
             *  }
             * */
            //string strSayi = string.Empty;
            //int intSayi;
            //string msg = string.Empty;
            //Console.WriteLine("bir sayi giriniz : ");
            //strSayi = Console.ReadLine();
            //try
            //{
            //    intSayi = int.Parse(strSayi);
            //    msg = "Girdiğiniz içerik başarılı şekilde int değerine dönüştürülmüştür";
            //}
            //catch (FormatException formatEx)
            //{
            //    msg = $"Error Message : {formatEx.Message} \n" +
            //        $"Inner Exception : {formatEx.InnerException} \n" +
            //        $"Stack Trace :  {formatEx.StackTrace} ";
            //}
            //catch (Exception ex)
            //{
            //    msg = $"Error Message : {ex.Message} \n" +
            //        $"Inner Exception : {ex.InnerException} \n" +
            //        $"Stack Trace :  {ex.StackTrace} ";
            //}
            //finally
            //{
            //    strSayi = string.Empty;
            //    msg = String.Empty;
            //    intSayi = 0;
            //}

            //Console.WriteLine(msg);

            int sayi1;
            int sayi2;
            int toplam;
            int ortalama;
            string msg = string.Empty;
            sayi1 = 100;
            sayi2 = 200;
            toplam = sayi1 + sayi2;
            try
            {
                ortalama = toplam / 0;
                msg = $"Verdiğiniz rakamların Ortalaması {ortalama} sayısıdır....";
            }
            catch (DivideByZeroException divideZeroEx)
            {
                msg = $"Hata Mesajı : {divideZeroEx.Message}\n" +
                    $"Inner Exception : {divideZeroEx.InnerException}\n" +
                    $"Stack Trace : {divideZeroEx.StackTrace}";
            }
            catch (Exception ex)
            {
                msg = $"Hata Mesajı : {ex.Message}\n" +
                    $"Inner Exception : {ex.InnerException}\n" +
                    $"Stack Trace : {ex.StackTrace}";
            }
            finally
            {
                Console.WriteLine(msg);
                sayi1 = 0;
                sayi2 = 0;
                msg = String.Empty;
                toplam = 0;
                ortalama = 0;

            }

            




        }
    }
}
