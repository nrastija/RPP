using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradevina__Zadatak_1_
{
    internal class UnutarnjiProstor : Prostor
    {
        public UnutarnjiProstor(String oznaka, Decimal povrsina) : base(oznaka, povrsina) { }

        public override decimal IzracunajNetoPovrsinu()
        {
            return Povrsina;
        }
    }
}
