using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesCal
{
    internal class Samsung : Telefon
    {
        private string marka = "samsung";

        private int fiyat = 0;

        private string zilsesi = "samsung";

        public override string Marka { get => marka; }
        public override int Fiyat { get => fiyat; }
        public override string Zilsesi { get => zilsesi; }


    }
}
