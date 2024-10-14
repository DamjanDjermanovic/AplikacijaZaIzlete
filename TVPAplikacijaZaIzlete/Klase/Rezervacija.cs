using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVPAplikacijaZaIzlete.Klase
{
    [Serializable]
    public class Rezervacija
    {
        public int IDKorisnika { get; set; }
        public int IDDestinacije { get; set; }
        public decimal UkupnaCena { get; set; }
        public int BrojRezervisanihMesta { get; set; }
        public DateTime DatumVreme { get; set; }
        public void IzracunajUkupnuCenu(List<Destinacija> destinacije)
        {
            var destinacija = destinacije.First(d => d.ID == IDDestinacije);
            UkupnaCena = (destinacija.Cena * BrojRezervisanihMesta) - (destinacija.Cena * BrojRezervisanihMesta * destinacija.Popust);
        }
    }

}
