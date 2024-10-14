using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVPAplikacijaZaIzlete.Klase
{
    [Serializable]
    public class Destinacija
    {
        public int ID { get; set; }
        public string Mesto { get; set; }
        public string Drzava { get; set; }
        public decimal Cena { get; set; }
        public decimal Popust { get; set; }
        public int BrojDana { get; set; }
        public int UkupnoMesta { get; set; }
        public int BrojPreostalihMesta { get; set; }
        public DateTime Datum { get; set; }

    }
}
