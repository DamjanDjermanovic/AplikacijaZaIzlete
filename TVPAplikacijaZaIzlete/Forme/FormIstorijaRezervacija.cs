using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVPAplikacijaZaIzlete.Klase;

namespace TVPAplikacijaZaIzlete.Forme
{
    public partial class FormIstorijaRezervacija : Form
    {
        private DataManager<Rezervacija> _istorijaRezervacija;
        private DataManager<Destinacija> _destinacijaDataManager;
        private Korisnik _trenutniKorisnik;

        public FormIstorijaRezervacija(Korisnik korisnik)
        {
            InitializeComponent();
            _trenutniKorisnik = korisnik;
            _istorijaRezervacija = new DataManager<Rezervacija>("istorijaRezervacija.xml");
            _destinacijaDataManager = new DataManager<Destinacija>("destinacije.xml");
        }

        private void FormIstorijaRezervacija_Load(object sender, EventArgs e)
        {
            PopuniIstorijuRezervacija();
        }

        private void PopuniIstorijuRezervacija(DateTime? pocetniDatum = null, DateTime? krajnjiDatum = null)
        {
            List<Rezervacija> rezervacije = _istorijaRezervacija.ProcitajXML()
                .Where(r => r.IDKorisnika == _trenutniKorisnik.ID)
                .ToList();

            if (pocetniDatum.HasValue && krajnjiDatum.HasValue)
            {
                rezervacije = rezervacije
                    .Where(r => r.DatumVreme.Date >= pocetniDatum.Value.Date && r.DatumVreme.Date <= krajnjiDatum.Value.Date)
                    .ToList();
            }

            List<Destinacija> destinacije = _destinacijaDataManager.ProcitajXML();

            var istorijaRezervacija = rezervacije.Select(r =>
            {
                var destinacija = destinacije.FirstOrDefault(d => d.ID == r.IDDestinacije);
                return new
                {
                    Mesto = destinacija?.Mesto,
                    Drzava = destinacija?.Drzava,
                    UkupnaCena = r.UkupnaCena,
                    BrojRezervisanihMesta = r.BrojRezervisanihMesta,
                    DatumDestinacije = destinacija?.Datum.ToShortDateString(),
                    DatumRezervacije = r.DatumVreme.ToShortDateString()
                };
            }).ToList();

            dgvIstorijaRezervacija.DataSource = istorijaRezervacija;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormKorisnik(_trenutniKorisnik));
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            DateTime pocetniDatum = dtpPocetniDatum.Value.Date;
            DateTime krajnjiDatum = dtpKrajnjiDatum.Value.Date;

            if (pocetniDatum > krajnjiDatum)
            {
                MessageBox.Show("Početni datum mora biti pre krajnjeg datuma.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PopuniIstorijuRezervacija(pocetniDatum, krajnjiDatum);
        }
    }
}
