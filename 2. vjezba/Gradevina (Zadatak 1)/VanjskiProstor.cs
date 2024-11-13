using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradevina__Zadatak_1_
{
    public class VanjskiProstor : Prostor
    {   
        public bool Natkriven {  get; }

        public VanjskiProstor(string oznaka, double povrsina, bool natkriven) : base(oznaka, povrsina) 
        {
            Natkriven = natkriven;
        }


        public override double IzracunajNetoPovrsinu()
        {
            return Natkriven ? Povrsina * 0.5 : Povrsina * 0.3;
        }
    }
}
