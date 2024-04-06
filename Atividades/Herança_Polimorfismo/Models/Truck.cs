using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança_Polimorfismo.Models
{
    public class Truck : Vehicle
    {
        public override int Wheels()
        {
            return 10;
        }
    }
}