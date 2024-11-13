using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zgrade__Zadatak_2_
{
    public class NestambeniProstor : Prostor
    {
        public NestambeniProstor(string oznaka, int kat, float povrsina, bool slobodan, int cijena) : base(oznaka, kat, povrsina, slobodan, cijena)
        {
        }

        public override double izracunajProdajnuCijenu()
        {
            return Povrsina * Cijena * 1.03;
        }
    }
}
