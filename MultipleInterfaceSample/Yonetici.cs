using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaceSample
{
    public class Yonetici : IKisi, ICalisan
    {
        private string _ad;
        public string Ad { get => _ad; set => _ad = value; }

        private string _soyad;
        public string Soyad { get => _soyad; set => _soyad = value; }

        private string _adres;
        public string Adres { get => _adres; set => _adres = value; }

        private int _id;
        public int Id { get => _id; set => _id = value; }

        private int _calismaSaati;
        public int CalismaSaati { get => _calismaSaati; set => _calismaSaati = value; }

        private string _departman;
        public string Departman { get => _departman; set => _departman = value; }

        private int _yoneticiId;
        public int YoneticiId { get => _yoneticiId; set => _yoneticiId = value; }
     
        private List<int> _bagliCalisanlar;

        public List<int> BagliCalisanlar { get => _bagliCalisanlar; set => _bagliCalisanlar = value; }
    
    
    }
}
