using BudzetLibrary;
public class Program
{
    public static void Main()
    {
        // Kreiranje nove zgrade
        Zgrada zgrada = new Zgrada("Zgrada A", "Adresa 123");

        zgrada.dodajZonu(new StambenaZona("Zona 1"));
        zgrada.dodajZonu(new NestambenaZona("Zona 2"));
 
        zgrada.dodajProstorUStambenuZonu(new Prostor("Stan 1", 50));
        zgrada.dodajProstorUStambenuZonu(new Prostor("Stan 2", 60));

        zgrada.dodajProstorUNestambenuZonu(new Prostor("Ured 1", 80));
        zgrada.dodajProstorUNestambenuZonu(new Prostor("Ured 2", 100));

        double ukupnaPricuva = zgrada.izracunajUkupnuPricuvu();
        Console.WriteLine($"Ukupna pričuva za zgradu: {ukupnaPricuva} kn");

        var prostori = zgrada.dohvatiSveProstore();
        Console.WriteLine("Prostori sortirani po površini:");
        foreach (var prostor in prostori)
        {
            Console.WriteLine($"Oznaka: {prostor.Oznaka}, Površina: {prostor.Povrsina}");
        }
    }
}
