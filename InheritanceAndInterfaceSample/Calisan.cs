using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaceSample
{
    public class Calisan : Kisi
    {
        public Calisan()
        {
            Console.WriteLine("Calisan Class Constructor");
        }
 
        private int _yoneticiId;

        public int YoneticiId { get => _yoneticiId; set => _yoneticiId = value; }
    
        public string getCalisanInfo()
        {
            StringBuilder _str = new StringBuilder();
            _str.Append($"İsim : {Ad} {this.Soyad}\n");
            _str.Append($"Departman : {Departman}\n");
            _str.Append($"Maas : {Maas}\n");
            _str.Append($"Id : {this.Id}\n");
            _str.Append($"Yonetici ID : {this.YoneticiId}\n");
            return _str.ToString();
        }
    }
}
