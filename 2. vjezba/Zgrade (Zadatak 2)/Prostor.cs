using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zgrade__Zadatak_2_
{
    public abstract class Prostor
    {
        public string Oznaka { get; }
        public int Kat { get; }
        public float Povrsina { get; }
        public bool Slobodan { get; set; } = true;

        private int cijena;
        public int Cijena { 
            get => cijena;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Cijena ne moze biti 0");
                }
                Cijena = value;
            }
        }

        public Prostor(string oznaka, int kat, float povrsina, bool slobodan, int cijena)
        {
            Oznaka = oznaka;
            Kat = kat;
            Povrsina = povrsina;
            Slobodan = slobodan;
            Cijena = cijena;
        }

        public abstract double izracunajProdajnuCijenu();

    }
}
