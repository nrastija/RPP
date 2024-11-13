using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetLibrary
{
    public class Zgrada
    {
        public string Oznaka { get; set; }
        public string Adresa { get; set; } 

        public Zgrada(string oznaka, string adresa)
        {
            Oznaka = oznaka;
            Adresa = adresa;   
        }

        private List<Zona> zoneZgrade { get; } = new List<Zona>();

        public void dodajZonu(Zona zona)
        {
            zoneZgrade.Add(zona);
        }

        public double izracunajUkupnuPricuvu()
        {
            return zoneZgrade.Sum(z => z.izracunajPricuvu());
        }

        public void dodajProstorUStambenuZonu(Prostor prostor)
        {
            var stambenaZona = zoneZgrade.OfType<StambenaZona>().LastOrDefault();
            if (stambenaZona != null)
            {
                stambenaZona.dodajProstor(prostor);
            }
        }

        public void dodajProstorUNestambenuZonu(Prostor prostor)
        {
            var stambenaZona = zoneZgrade.OfType<NestambenaZona>().LastOrDefault();
            if (stambenaZona != null)
            {
                stambenaZona.dodajProstor(prostor);
            }
        }

        public List<Prostor> dohvatiSveProstore()
        {
            return zoneZgrade.SelectMany(zona => zona.popisProstora).OrderByDescending(zona => zona.Povrsina).ToList();
        }

    }
}
