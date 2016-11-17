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
            Osoba o1 = new Osoba();
            o1.Osoba("Jan", "Kowalski");
            Autor a1 = new Autor();
            a1.Autor("Polska");
            Pozycja p1 = new Pozycja();
            p1.Pozycja("Kamyczki", 1,"Warszawa",1654);
            Ksiazka k1 = new Ksiazka();
            k1.Ksiazka(696);
            Katalog ka1 = new Katalog();
            ka1.Katalog("Przygody");
            Czasopismo cz1 = new Czasopismo();
            cz1.Czasopismo(15);

        }
    }
}
