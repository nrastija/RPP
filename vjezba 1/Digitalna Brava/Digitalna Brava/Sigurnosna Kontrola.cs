using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalna_Brava
{
    public class Sigurnosna_Kontrola
    {   
        public bool OtvoriVrata(int brojkartice, int Pin, int brojvrata)
        {
            if (!int.TryParse(brojkartice.ToString(), out int brojKartice) || !int.TryParse(Pin.ToString(), out int pin) || !int.TryParse(brojvrata.ToString(), out int brojVrata))
            {
                MessageBox.Show("Unesite ispravne podatke");
                return false;
            }

            Repozitorij repozitorij = new Repozitorij();

            Korisnik korisnik = repozitorij.DohvatiKorisnika(brojkartice, pin);
            Vrata vrata = repozitorij.DohvatiVrata(brojvrata);
            
            if (korisnik == null || vrata == null)
            {
                MessageBox.Show("Korisnik ili vrata ne postoje");
                return false;
            }

            if (ImaPrava(korisnik, vrata))
            {
                MessageBox.Show($"Vrata {brojvrata} su otvorena");
                return true;
            }
            else
            {
                MessageBox.Show("Nemate prava za otvaranje vrata");
                return false;
            }
        }
        public bool ImaPrava(Korisnik korisnik, Vrata vrata)
        {
            return korisnik.RazinaPrava >= vrata.RazinaPrava;
        }
    }
}
