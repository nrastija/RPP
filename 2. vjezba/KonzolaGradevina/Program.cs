using System;
using Gradevina__Zadatak_1_;

class Program
{
    static void Main(string[] args)
    {
        Gradevina gradevina = new Gradevina("FOI");

        gradevina.dodajProstor(new UnutarnjiProstor("Dvorana 15", 30));
        gradevina.dodajProstor(new UnutarnjiProstor("Dvorana 1", 100));
        gradevina.dodajProstor(new UnutarnjiProstor("Rupa", 87));

        gradevina.dodajProstor(new VanjskiProstor("Parking", 120, false));
        gradevina.dodajProstor(new VanjskiProstor("Nadstresnica", 50, true));

        Console.Write("Unutarnji prostori:\n");
        foreach (var unutarnjiProstor in gradevina.dohvatiUnutarnjeProstore())
        {
            Console.Write("Unutarnji prostor: " + unutarnjiProstor.Oznaka + " - " + unutarnjiProstor.Povrsina + " m^2\n");
        }

        Console.Write("\nVanjski prostori:\n");
        foreach (var vanjskiProstor in gradevina.dohvatiVanjskeProstore())
        {
            Console.Write("Vanjski: " + vanjskiProstor.Oznaka + " - " + vanjskiProstor.Povrsina + " m^2\n");
        }


        Console.Write("\nNeto povrsina prostora FOI-ja: " + gradevina.dohvatiVlastituNetoPovrsinu() + " m^2");

        


    }
}