using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentuje kod bo nie tak dokładnie chodziło
            //Osoba o1 = new Osoba();
            //o1.Osoba("Jan", "Kowalski");
            //Autor a1 = new Autor();
            //a1.Autor("Polska");
            //Pozycja p1 = new Pozycja();
            //p1.Pozycja("Kamyczki", 1,"Warszawa",1654);
            //Ksiazka k1 = new Ksiazka();
            //k1.Ksiazka(696);
            //Katalog ka1 = new Katalog();
            //ka1.Katalog("Przygody");
            //Czasopismo cz1 = new Czasopismo();
            //cz1.Czasopismo(15);

            //przykładowy program testujacy korzystający w pelni z obiektówki
            Katalog biblioteka = new Katalog("Dział ogólny");
            biblioteka.DodajPozycje("Henryk", "Sienkiewicz", "Krzyżacy", 23, "Znak", 2010, 220);
            biblioteka.DodajPozycje("Władysław", "Reymont", "Chłopi", 31, "Greg", 2002, 310);
            biblioteka.DodajPozycje(200, "Gazeta Olsztyńska", 123, "Edytor", 2016);
            biblioteka.DodajPozycje("Henryk", "Sienkiewicz", "Krzyżacy", 24, "Znak", 2011, 220);

            biblioteka.WypiszWszystko();

            Console.WriteLine("Wyszukiwanie po tytule");
            biblioteka.WyszukajPoTytule("Krzyżacy");

            Console.WriteLine("Wyszukiwanie po id");
            biblioteka.WyszukajPoId(123);

            Console.ReadKey();

        }
    }
}
