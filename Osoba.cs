using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia9
{
    class Osoba
    {
        private string Imie;
        private string Nazwisko;
        public Osoba() { }
        public Osoba(string Imie,string Nazwisko)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
        }
        public string returnImie()
        {
            return Imie;
        }
        public string returnNazwisko()
        {
            return Nazwisko;
        }
    }
}
