using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zgrade__Zadatak_2_
{
    public class Zgrada
    {
        private string oznaka;
        private string adresa;
        public string Oznaka { get => oznaka;
            set
            {
                if (value == null) throw new Exception("Oznaka ne moze biti prazan string");
                
                Oznaka = value;
            }
        }

        public string Adresa { get => adresa; 
            set
            {
                if (value == null) throw new Exception("Adresa ne moze biti prazan string");
                Oznaka = value;
            }
        }

        public Zgrada (string oznaka, string adresa)
        {
            Oznaka = oznaka;
            Adresa = adresa;
        }

        public List<Prostor> prostori = new List<Prostor>();

        public void dodajProstor(Prostor prostor) 
        {
            prostori.Add(prostor);
        }

        public void prodajProstor(Prostor oznakaProstora)
        {
            var prostor = prostori.FirstOrDefault(p => p.Oznaka == oznakaProstora.Oznaka);
            if (prostor == null) throw new Exception("Prostor ne postoji.");
            if (!prostor.Slobodan) throw new Exception("Prostor je već prodan!");

            prostor.Slobodan = false;
        }

        public List<Prostor> slobodniProstoriPoCijeni(List<Prostor> prostori)
        {
            return prostori.Where(p => p.Slobodan).OrderBy(p => p.Cijena).ToList();
        }

        public List<Prostor> prodaniProstori(List<Prostor> prostori)
        {
            return prostori.Where(p => !p.Slobodan).ToList();
        }

        public List<Prostor> slobodniProstoriManjeOdCijene(List<Prostor> prostori, int cijena)
        {
            return prostori.Where(p => p.izracunajProdajnuCijenu() < cijena && p.Slobodan).ToList();
        }

        public List<NestambeniProstor> nestambeniProstori(List<Prostor> prostori)
        {
            return prostori.OfType<NestambeniProstor>().ToList();
        }
    }
}
