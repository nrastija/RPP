using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalna_Brava
{
    public class Repozitorij
    {
        public List<Korisnik> ListaKorisnika = new List<Korisnik>()
        {
            new Korisnik(10001, 1234, 1),
            new Korisnik(10002, 0000, 2),
            new Korisnik(10003, 9999, 2),
        };

        public List<Vrata> ListaVrata = new List<Vrata>() { 
            new Vrata(501, 1),
            new Vrata(502, 2),
            new Vrata(503, 2),
        };

        public Korisnik DohvatiKorisnika(int brojkartice, int pin)
        {
            return ListaKorisnika.Find(x => x.BrojKartice == brojkartice && x.PIN == pin);
        }

        public Vrata DohvatiVrata(int brojVrata)
        {
            return ListaVrata.Find(x => x.BrojVrata == brojVrata);
        }

    }
}
