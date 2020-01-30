using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1Eprov2
{
    class CleanCar : Car
    {
        public CleanCar()
        {
            contrabandAmount = generator.Next(0);
        }
    }
}
