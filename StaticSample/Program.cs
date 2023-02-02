using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSample
{
    internal class Program
    {

        /*Bir sınıf içerisinde bulunan metotlar static tanımlanabillir
         * Bir sınıf içerisinde bulunan fieldlar static olarak tanımlanabilir
         * 
         * 
         * 
         * 
         */
        static void Main(string[] args)
        {
            //double result = Matematik.Toplam(3, 5);
            //Console.WriteLine(result);
            //Matematik m1 = new Matematik(); 
            //Matematik m2 = new Matematik(); 
            //Matematik m3 = new Matematik(); 

            //Console.WriteLine(Matematik.Pi.ToString());
            //Console.WriteLine(Matematik.Pi.ToString());
            //Console.WriteLine(Matematik.Pi.ToString());


            Matematik m1 = new Matematik();
            Matematik m2 = new Matematik();

            Console.WriteLine(Matematik.Pi.ToString());
            Console.WriteLine(Matematik.Pi.ToString());

            m2.PiDegistir(3);
            Matematik m3 = new Matematik();
            Matematik m4 = new Matematik();
            Console.WriteLine(Matematik.Pi.ToString());
            Console.WriteLine(Matematik.Pi.ToString());

        }
    }


    class Matematik
    {
        //Static yapıcı metot erişim belirleyici kullanmaz
        //Static yapıcı Metot kaç nesne örneği oluşturulursa oluşturulsun sadece 1 kere çalışır
        //Static yapıcı metot sınıfa ait tüm yapıcı metotlardan önce çalışır
        //Static yapıcı metot parametre almaz.
        //Bir sınıf sadece 1 static yapıcı metot içerir
        //Static yapıcı metot ya ilk nesne örneği oluşturulduğunda ya da static sınıf üyesi çağırılmadan önce çalıştırılır

        static Matematik()
        {
            Pi = 3.1415;
        }
        //public Matematik()
        //{
        //    Pi = 3.1415;
        //}
        public static double Pi = 3.14;
        
        public void PiDegistir(double pi)
        {
            Pi = pi;
        }
        
        public static double Toplam(double x, double y)
        {
            return x + y;
        }
    
        //Static olmayan bir metot içerisinde static bir metot çağırabilirim.
        public double Toplamlar(int ustsinir,double x, double y)
        {
            double _result = 0;
            for (int i = 0; i < ustsinir; i++)
            {
                _result = Toplam(x, y);
            }

            return _result;
        }
    
        public static void Toplamlar2(int ustsinir, double x, double y)
        {
            //Toplamlar(ustsinir, x, y);
        }

    }


}
