using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    public class Ocak : IAy
    {
        private int _kacinciAy
        public int KacinciAy { get => _kacinciAy; set => _kacinciAy = value; }

        private string _ayAdi;
        public string AyAdi { get => _ayAdi; set => _ayAdi = value; }

        private int _kacGun;
        public int KacGun { get => _kacGun; set => _kacGun = value; }
    }
}
