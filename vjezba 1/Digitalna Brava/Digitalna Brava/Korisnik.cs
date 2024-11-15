using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalna_Brava
{
    public class Korisnik
    {
        public int BrojKartice { get; set; }
        public int PIN { get; set; }
        public int RazinaPrava { get; set; }

        public Korisnik(int brojKartice, int pin, int razinaPrava)
        {
            BrojKartice = brojKartice;
            PIN = pin;
            RazinaPrava = razinaPrava;
        }
    }
}
