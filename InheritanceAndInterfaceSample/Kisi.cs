using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaceSample
{
    public class Kisi
    {
        public Kisi()
        {
            Console.WriteLine("Kisi Class Constructor");
        }
        private string _ad;
        private string _soyad;
        private int _int;
        private double _maas;
        private string _departman;

        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
        public int Int { get => _int; set => _int = value; }
        public double Maas { get => _maas; set => _maas = value; }
        public string Departman { get => _departman; set => _departman = value; }
    }
}
