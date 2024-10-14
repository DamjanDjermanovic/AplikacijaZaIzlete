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
    public partial class FormDodajRezervacijuKlijent : Form
    {
        private DataManager<Rezervacija> _rezervacijaDataManager;
        private DataManager<Destinacija> _destinacijaDataManager;
        private DataManager<Rezervacija> _istorijaRezervacija;
        
        private Korisnik _trenutniKorisnik;

        public FormDodajRezervacijuKlijent(Korisnik korisnik)
        {
            InitializeComponent();
            _trenutniKorisnik = korisnik;
            _rezervacijaDataManager = new DataManager<Rezervacija>("rezervacije.xml");
            _destinacijaDataManager = new DataManager<Destinacija>("destinacije.xml");
            _istorijaRezervacija = new DataManager<Rezervacija>("istorijaRezervacija.xml");

            List<Destinacija> destinacije = _destinacijaDataManager.ProcitajXML();
            dgvDestinacije.DataSource = destinacije;
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            if (dgvDestinacije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo vas da selektujete destinaciju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbBrojRezervisanihMesta.Text, out int brojRezervisanihMesta) || brojRezervisanihMesta <= 0)
            {
                MessageBox.Show("Molimo vas da unesete ispravan broj rezervisanih mesta.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var destinacijaRow = dgvDestinacije.SelectedRows[0];
            int idDestinacije = (int)destinacijaRow.Cells["ID"].Value;

            List<Destinacija> destinacije = _destinacijaDataManager.ProcitajXML();
            var destinacija = destinacije.First(d => d.ID == idDestinacije);

            if (brojRezervisanihMesta > destinacija.BrojPreostalihMesta)
            {
                MessageBox.Show("Nema dovoljno mesta na ovoj destinaciji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Rezervacija> rezervacije = _rezervacijaDataManager.ProcitajXML()
                .Where(r => r.IDKorisnika == _trenutniKorisnik.ID)
                .ToList();

            if (Globalne.ProveriPreklapanjeRezervacija(rezervacije, idDestinacije, destinacija.Datum, destinacija.BrojDana))
            {
                MessageBox.Show("Već imate rezervaciju koja se preklapa sa datumom izabrane destinacije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Rezervacija novaRezervacija = new Rezervacija
            {
                IDKorisnika = _trenutniKorisnik.ID,
                IDDestinacije = idDestinacije,
                BrojRezervisanihMesta = brojRezervisanihMesta,
                UkupnaCena = (destinacija.Cena * brojRezervisanihMesta) - (destinacija.Cena * brojRezervisanihMesta * destinacija.Popust / 100),
                DatumVreme = DateTime.Now,
            };

            destinacija.BrojPreostalihMesta -= brojRezervisanihMesta;
            _destinacijaDataManager.UpisiUXML(destinacije);

            _rezervacijaDataManager.DodajUXML(novaRezervacija);
            _istorijaRezervacija.DodajUXML(novaRezervacija);

            MessageBox.Show("Rezervacija je uspešno dodata.", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Globalne.ZameniFormu(this, new FormKorisnik(_trenutniKorisnik));
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormKorisnik(_trenutniKorisnik));
        }

        private void btnFilterMesto_Click(object sender, EventArgs e)
        {
            List<Destinacija> destinacije = _destinacijaDataManager.ProcitajXML();

            string filterMesto = tbFilterMesto.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filterMesto))
            {
                dgvDestinacije.DataSource = destinacije;
            }
            else
            {
                var filtriraneDestinacije = destinacije
                    .Where(d => d.Mesto.ToLower().Contains(filterMesto))
                    .ToList();

                dgvDestinacije.DataSource = filtriraneDestinacije;
            }

            dgvDestinacije.Refresh();
        }
    }
}
