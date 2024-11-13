using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetLibrary
{
    public class StambenaZona : Zona
    {
        public StambenaZona(string oznaka) : base(oznaka)
        {
        }

        public override double izracunajPricuvu()
        {
            return ukupnaPovrsinaZone() * 2;
        }
    }
}
