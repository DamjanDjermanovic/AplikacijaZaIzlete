using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVPAplikacijaZaIzlete.Klase
{
    [Serializable]
    public class Korisnik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string VrstaKorisnika{ get; set; }
        
    }
}
