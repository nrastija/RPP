using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetLibrary
{
    public class NestambenaZona : Zona
    {
        public NestambenaZona(string oznaka, List<Prostor> prostori) : base(oznaka, prostori)
        {
        }

        public override double izracunajPricuvu()
        {
            return ukupnaPovrsinaZone() * 3;
        }
    }
}
