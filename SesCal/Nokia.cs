using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesCal
{
    internal class Nokia : Telefon
    {
        private string marka = "nokia";

        private int fiyat = 0;

        private string zilsesi = "nokia";
        public override string Marka { get => marka; }
        public override int Fiyat { get => fiyat; }
        public override string Zilsesi { get => zilsesi; }
    }
}

