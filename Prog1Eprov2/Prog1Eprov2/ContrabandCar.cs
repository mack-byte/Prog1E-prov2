using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1Eprov2
{
    class ContrabandCar : Car
    {
        public ContrabandCar()
        {
            contrabandAmount = generator.Next(1, 4);
            
        }
    }
}
