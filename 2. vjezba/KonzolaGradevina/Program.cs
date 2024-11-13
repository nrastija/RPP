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

        Console.Write("Neto povrsina prostora FOI-ja: " + gradevina.dohvatiVlastituNetoPovrsinu() + " m^2");





    }
}