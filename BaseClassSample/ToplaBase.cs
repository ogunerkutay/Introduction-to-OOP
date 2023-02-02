using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassSample
{
    public class ToplaBase
    {
        //public ToplaBase()
        //{
        //    Console.WriteLine("ToplaBase Class Parametre Almayan Constructor Metot");
        //}
        public ToplaBase(int a, int b)
        {
            Console.WriteLine("ToplaBase Class Parametre Alan Constructor Metot");
            Console.WriteLine($"Sonuc : {a + b}");
        }
        private int _sayi1;
        private int _sayi2;

        public int Sayi1 { get => _sayi1; set => _sayi1 = value; }
        public int Sayi2 { get => _sayi2; set => _sayi2 = value; }
    
        protected int Toplam()
        {
            int _result;
            _result = _sayi1 + _sayi2;
            return _result;
        }
    }
}
