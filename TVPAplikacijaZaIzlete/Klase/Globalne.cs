using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPAplikacijaZaIzlete.Klase
{
    public static class Globalne
    {
        public static void ZameniFormu(Form trenutnaForma, Form novaForma)
        {
            novaForma.FormClosed += (s, args) => trenutnaForma.Dispose();
            novaForma.Show();
            trenutnaForma.Hide();
        }

        public static bool ProveriPreklapanjeRezervacija(List<Rezervacija> rezervacije, int idDestinacije, DateTime datumDestinacije, int brojDana)
        {
            return rezervacije.Any(r =>
                (r.IDDestinacije == idDestinacije) ||
                (datumDestinacije < r.DatumVreme.AddDays(r.BrojRezervisanihMesta) && datumDestinacije.AddDays(brojDana) > r.DatumVreme)
            );
        }
    }

}
