using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetLibrary
{
    public class NestambenaZona : Zona
    {
        public NestambenaZona(string oznaka) : base(oznaka)
        {
        }

        public override double izracunajPricuvu()
        {
            return ukupnaPovrsinaZone() * 3;
        }
    }
}
