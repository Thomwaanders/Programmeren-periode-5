using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Klant
    {

        public string Voornaam { get; set; }

        public string Tussenvoegsel { get; set; }

        public string Achternaam { get; set; }

        public string Adres { get; set; }

        public string Woonplaats { get; set; }

        public string Postcode { get; set; }


        public Klant(string voornaam, string tussenvoegsel, string achternaam, string adres, string woonplaats, string postcode)
        {
            Voornaam = voornaam;
            Tussenvoegsel = tussenvoegsel;
            Achternaam = achternaam;
            Adres = adres;
            Woonplaats = woonplaats;
            Postcode = postcode;


        }
    }
}
