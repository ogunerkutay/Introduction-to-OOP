using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaceSample
{
    public class Musteri : IKisi
    {
        private string _ad;
        public string Ad { get {
                if (!string.IsNullOrEmpty(_ad))
                return _ad;
                else
                    return string.Empty;
                ;}
          set => _ad = value; }

        private string _soyad;
        public string Soyad { get => _soyad; set => _soyad = value; }

        private string _adres;
        public string Adres { get => _adres; set => _adres = value; }

        private int _id;

        private string vergiDairesi;
        private string vergiNumarasi;
        private string ticariUnvan;

        public int Id { get => _id; set => _id = value; }
        public string VergiDairesi { get => vergiDairesi; set => vergiDairesi = value; }
        public string VergiNumarasi { get => vergiNumarasi; set => vergiNumarasi = value; }
        public string TicariUnvan { get => ticariUnvan; set => ticariUnvan = value; }

    }
}
