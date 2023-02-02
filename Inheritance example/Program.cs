using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Egitmen egitmen = new Egitmen();
            egitmen.Ad = "John";

            SatisTemsilcisi satisTemsilcisi = new SatisTemsilcisi();
            satisTemsilcisi.Ad = "Faruk";

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Arda";

            Job job = new Job();
            job.Name = "Boş gezenin boş kalfalığı";

            job.Work(egitmen);
            job.Work(satisTemsilcisi);

            job.IkametgahAl(ogrenci);
            job.IkametgahAl(egitmen);
            job.IkametgahAl(satisTemsilcisi);


        }
    }
}
