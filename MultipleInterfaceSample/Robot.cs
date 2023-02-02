using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaceSample
{
    public class Robot : ICalisan
    {
        private int _calismaSaati;
        public int CalismaSaati { get => _calismaSaati; set => _calismaSaati = value; }

        private string _departman;
        public string Departman { get => _departman; set => _departman = value; }

        private int _yoneticiId;
        public int YoneticiId { get => _yoneticiId; set => _yoneticiId = value; }
    }
}
