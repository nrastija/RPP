using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradevina__Zadatak_1_
{
    public class UnutarnjiProstor : Prostor
    {
        public UnutarnjiProstor(string oznaka, double povrsina) : base(oznaka, povrsina) { }

        public override double IzracunajNetoPovrsinu()
        {
            return Povrsina;
        }
    }
}
