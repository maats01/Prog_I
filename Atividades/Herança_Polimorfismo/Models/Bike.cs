using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança_Polimorfismo.Models
{
    public class Bike : Vehicle
    {
        public override int Wheels()
        {
            return 2;
        }
    }
}