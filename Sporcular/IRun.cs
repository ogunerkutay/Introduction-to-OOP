using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporcular
{
    public interface IRun 
    {
        int RunningSpeed { get; set; }
        void Run();
    }
}
