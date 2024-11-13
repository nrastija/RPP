using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetLibrary
{
    public abstract class Zona
    {
        public string Oznaka { get; set; }
        public List<Prostor> popisProstora { get; set; } = new List<Prostor>();

        public Zona(string oznaka)
        {
            Oznaka = oznaka;
        }
        public void dodajProstor(Prostor prostor)
        {
            popisProstora.Add(prostor);
        }

        public double ukupnaPovrsinaZone()
        {
            return popisProstora.Sum(p => p.Povrsina);
        }
        public abstract double izracunajPricuvu();
    }
}
