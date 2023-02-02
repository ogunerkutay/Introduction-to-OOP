using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaceSample
{
    public class Yonetici
    {
        public Yonetici()
        {
            Console.WriteLine("Yönetici Class Constructor");

        }

        private List<int> _bagliCalisanIds;

        public List<int> BagliCalisanIds 
        { get => _bagliCalisanIds; set => _bagliCalisanIds = value; }
    
    
        public string getYoneticiInfo()
        {
            StringBuilder _str = new StringBuilder();
            _str.Append($"İsim : {Ad} {this.Soyoad}\n");
            _str.Append($"Departman : {Departman}\n");
            _str.Append($"Maas : {Maas}\n");
            _str.Append($"Id : {this.Id}\n");
            _str.Append($"Bağlı Çalışanlar : {getIds(this._bagliCalisanIds)}");
            
            return _str.ToString();
       
        }

        private string getIds(List<int> bagliCalisanIds)
        {
            string _result = string.Empty;
            StringBuilder _str = new StringBuilder();
            foreach (int item in _bagliCalisanIds)
            {
                _str.Append(item.ToString());
                _str.Append(";");
            }

            _result = _str.ToString();
            _result = _result.Substring(0, _result.Length - 1);
            return _result;
        }
    }
}
