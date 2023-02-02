using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesCal
{
    internal class Default : Telefon
    {
        private string marka = "default";

        private int fiyat = 0;

        private string zilsesi = "default";

        public override string Marka { get => marka; }
        public override int Fiyat { get => fiyat; }
        public override string Zilsesi { get => zilsesi; }
    }
}
