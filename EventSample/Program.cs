using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayiKontrol sayiKontrol = new SayiKontrol();
            sayiKontrol.SayiDurumu += new SayiKontrol.SayiKontrolEventHandler(SayiKontrolEt);

            for (int i = 0; i < 10; i++)
            {
                Random _rnd = new Random();
                sayiKontrol.Sayi = _rnd.Next(20, 60);
                Thread.Sleep(5000);

            }
        }

        private static void SayiKontrolEt()
        {
            Console.WriteLine("Sayı değeri 50den küçüktür");
        }
    }
    
    class SayiKontrol
    {
        public delegate void SayiKontrolEventHandler();
        public event SayiKontrolEventHandler SayiDurumu;
        private const int _sabitDeger = 50;

        private int _sayi;
        public int Sayi
        {
            get { return _sayi; }
            set 
            {

                _sayi = value;
                if (_sayi <= _sabitDeger)
                {
                    if (SayiDurumu != null)
                    {
                        SayiDurumu();
                    }
                }
            }
        }
    }



}
