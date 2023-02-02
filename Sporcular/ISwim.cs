using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporcular
{
    public interface ISwim : IJump
    {
        int SwimmingDistance { get; set; }
        int SwimmingSpeed { get; set; }
        void Swim();

    }
}
