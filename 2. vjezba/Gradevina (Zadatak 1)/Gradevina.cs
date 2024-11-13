using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradevina__Zadatak_1_
{
    internal class Gradevina
    {
        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Naziv ne moze biti prazan.");
                }
                naziv = Naziv;
            }

        }

        private List<Prostor> prostori = new List<Prostor>();

        public Gradevina(string naziv)
        {
            Naziv = naziv;
        }

        public void dodajProstor(Prostor prostor)
        {
            if (prostori.Any(p => p.Oznaka == prostor.Oznaka))
            {
                throw new ArgumentException("Već postoji prostor s tom oznakom.");
            }

            prostori.Add(prostor);
        }

        public void obrisiProstor(Prostor prostor)
        {
            foreach (Prostor pros in prostori)
            {
                if (pros.Oznaka == prostor.Oznaka && prostori.Count >= 1)
                {
                    prostori.Remove(prostor);
                }
                else
                {
                    throw new ArgumentException("Problem sa brisanjem prostora.");
                }
            }
        }

        public double dohvatiVlastituNetoPovrsinu(Prostor prostor)
        {
            return prostori.Sum(p => p.IzracunajNetoPovrsinu());
        }

        public List<UnutarnjiProstor> dohvatiUnutarnjeProstore()
        {
            return prostori.OfType<UnutarnjiProstor>().ToList();
        }

        public List<VanjskiProstor> dohvatiVanjskeProstore()
        {
            return prostori.OfType<VanjskiProstor>().ToList();
        }

    }
}