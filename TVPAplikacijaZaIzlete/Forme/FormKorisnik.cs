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
    public partial class FormKorisnik : Form
    {
        private Korisnik trenutniKorisnik;
        private DataManager<Rezervacija> _rezervacijaDataManager;
        private DataManager<Destinacija> _destinacijaDataManager;

        public FormKorisnik(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
            _rezervacijaDataManager = new DataManager<Rezervacija>("rezervacije.xml");
            _destinacijaDataManager = new DataManager<Destinacija>("destinacije.xml");
        }

        private void FormKorisnik_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = trenutniKorisnik.Ime + " " + trenutniKorisnik.Prezime;
            PopuniRezeracijeDestinacije();
        }

        private void PopuniRezeracijeDestinacije()
        {
            List<Rezervacija> rezervacije = _rezervacijaDataManager.ProcitajXML()
                .Where(r => r.IDKorisnika == trenutniKorisnik.ID)
                .ToList();

            List<Destinacija> destinacije = _destinacijaDataManager.ProcitajXML();

            var rezervacijeDestinacije = rezervacije.Select(r =>
            {
                var destinacija = destinacije.FirstOrDefault(d => d.ID == r.IDDestinacije);
                return new
                {
                    IDKorisnika = r.IDKorisnika,
                    IDDestinacije = r.IDDestinacije,
                    Mesto = destinacija?.Mesto,
                    Drzava = destinacija?.Drzava,
                    UkupnaCena = r.UkupnaCena,
                    BrojRezervisanihMesta = r.BrojRezervisanihMesta,
                    DatumDestinacije = destinacija?.Datum.ToShortDateString(),
                    DatumRezervacije = r.DatumVreme.ToShortDateString()
                };
            }).ToList();

            dgvRezervacijeDestinacije.DataSource = rezervacijeDestinacije;

            dgvRezervacijeDestinacije.Columns["IDKorisnika"].Visible = false;
            dgvRezervacijeDestinacije.Columns["IDDestinacije"].Visible = false;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormRegistracija());
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormDodajRezervacijuKlijent(trenutniKorisnik));
        }

        private void btnOtkaziRezervaciju_Click(object sender, EventArgs e)
        {
            IzbrisiSelektovaniRedIzDgvRezervacijeDestinacije();
        }

        private void IzbrisiSelektovaniRedIzDgvRezervacijeDestinacije()
        {
            if (dgvRezervacijeDestinacije.SelectedRows.Count > 0)
            {
                var selectedRow = dgvRezervacijeDestinacije.SelectedRows[0];

                int idKorisnika = (int)selectedRow.Cells["IDKorisnika"].Value;
                int idDestinacije = (int)selectedRow.Cells["IDDestinacije"].Value;
                int brojRezervisanihMesta = (int)selectedRow.Cells["BrojRezervisanihMesta"].Value;

                var rezervacije = _rezervacijaDataManager.ProcitajXML();

                var rezervacijaZaBrisanje = rezervacije.FirstOrDefault(r =>
                    r.IDKorisnika == idKorisnika && r.IDDestinacije == idDestinacije);

                if (rezervacijaZaBrisanje != null)
                {
                    rezervacije.Remove(rezervacijaZaBrisanje);

                    _rezervacijaDataManager.UpisiUXML(rezervacije);

                    var destinacije = _destinacijaDataManager.ProcitajXML();
                    var destinacija = destinacije.FirstOrDefault(d => d.ID == idDestinacije);

                    if (destinacija != null)
                    {
                        destinacija.BrojPreostalihMesta += brojRezervisanihMesta;
                        _destinacijaDataManager.UpisiUXML(destinacije);
                    }

                    PopuniRezeracijeDestinacije();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormIstorijaRezervacija(trenutniKorisnik));
        }
    }
}
