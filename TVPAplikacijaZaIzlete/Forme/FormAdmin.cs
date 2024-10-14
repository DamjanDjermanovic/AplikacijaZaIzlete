using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TVPAplikacijaZaIzlete.Klase;

namespace TVPAplikacijaZaIzlete.Forme
{
    public partial class FormAdmin : Form
    {
        private DataManager<Korisnik> _korisnikDataManager;
        private DataManager<Destinacija> _destinacijaDataManager;
        private DataManager<Rezervacija> _rezervacijaDataManager;
        private List<Korisnik> korisnici;
        private List<Destinacija> destinacije;
        private List<Rezervacija> rezervacije;
        public FormAdmin()
        {
            InitializeComponent();

            _korisnikDataManager = new DataManager<Korisnik>("korisnici.xml");
            _destinacijaDataManager = new DataManager<Destinacija>("destinacije.xml");
            _rezervacijaDataManager = new DataManager<Rezervacija>("rezervacije.xml");

            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            List<Korisnik> korisnici = _korisnikDataManager.ProcitajXML();
            dgvKorisnici.DataSource = korisnici;

            List<Destinacija> destinacije = _destinacijaDataManager.ProcitajXML();
            dgvDestinacije.DataSource = destinacije;

            List<Rezervacija> rezervacije = _rezervacijaDataManager.ProcitajXML();
            dgvRezervacije.DataSource = rezervacije;
        }

        private void IzbrisiSelektovaniRed<T>(DataGridView gridView, DataManager<T> dataManager, DataManager<Rezervacija> rezervacijaDataManager) where T : class
        {
            if (gridView.SelectedRows.Count > 0)
            {
                var selectedRow = gridView.SelectedRows[0];

                if (typeof(T) == typeof(Rezervacija))
                {
                    int idKorisnika = (int)selectedRow.Cells["IDKorisnika"].Value;
                    int idDestinacije = (int)selectedRow.Cells["IDDestinacije"].Value;
                    int brojRezervisanihMesta = (int)selectedRow.Cells["BrojRezervisanihMesta"].Value;

                    var rezervacije = dataManager.ProcitajXML();
                    var rezervacijaZaBrisanje = rezervacije.FirstOrDefault(r =>
                        (int)r.GetType().GetProperty("IDKorisnika").GetValue(r) == idKorisnika &&
                        (int)r.GetType().GetProperty("IDDestinacije").GetValue(r) == idDestinacije);

                    if (rezervacijaZaBrisanje != null)
                    {
                        rezervacije.Remove(rezervacijaZaBrisanje);
                        dataManager.UpisiUXML(rezervacije);

                        List<Destinacija> destinacije = _destinacijaDataManager.ProcitajXML();
                        var destinacija = destinacije.FirstOrDefault(d => d.ID == idDestinacije);

                        if (destinacija != null)
                        {
                            destinacija.BrojPreostalihMesta += brojRezervisanihMesta;
                            _destinacijaDataManager.UpisiUXML(destinacije);
                        }

                        gridView.DataSource = null;
                        gridView.DataSource = rezervacije;
                    }
                }
                else
                {
                    int id = (int)selectedRow.Cells["ID"].Value;

                    if (typeof(T) == typeof(Korisnik))
                    {
                        var sveRezervacije = rezervacijaDataManager.ProcitajXML();
                        bool korisnikImaRezervacije = sveRezervacije.Any(r => r.IDKorisnika == id);

                        if (korisnikImaRezervacije)
                        {
                            MessageBox.Show("Korisnik ima rezervacije i ne može biti obrisan.");
                            return;
                        }
                    }

                    if (typeof(T) == typeof(Destinacija))
                    {
                        var sveRezervacije = rezervacijaDataManager.ProcitajXML();
                        bool destinacijaImaRezervacije = sveRezervacije.Any(r => r.IDDestinacije == id);

                        if (destinacijaImaRezervacije)
                        {
                            MessageBox.Show("Destinacija ima rezervacije i ne može biti obrisana.");
                            return;
                        }
                    }

                    var objekti = dataManager.ProcitajXML();
                    var objekatZaBrisanje = objekti.FirstOrDefault(o => o.GetType().GetProperty("ID").GetValue(o).Equals(id));

                    if (objekatZaBrisanje != null)
                    {
                        objekti.Remove(objekatZaBrisanje);
                        dataManager.UpisiUXML(objekti);

                        gridView.DataSource = null;
                        gridView.DataSource = objekti;
                    }
                }
            }
        }


        private void dgvKorisnici_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var row = dgvKorisnici.Rows[e.RowIndex];
                var korisnici = _korisnikDataManager.ProcitajXML();
                var korisnikID = (int)row.Cells["ID"].Value;
                var korisnik = korisnici.Find(k => k.ID == korisnikID);

                if (korisnik != null)
                {
                    korisnik.Ime = (string)row.Cells["Ime"].Value;
                    korisnik.Prezime = (string)row.Cells["Prezime"].Value;
                    korisnik.KorisnickoIme = (string)row.Cells["KorisnickoIme"].Value;
                    korisnik.Lozinka = (string)row.Cells["Lozinka"].Value;
                    korisnik.VrstaKorisnika = (string)row.Cells["VrstaKorisnika"].Value;

                    _korisnikDataManager.UpisiUXML(korisnici); // Ažuriraj XML sa celokupnom listom
                }
            }
        }

        private void dgvDestinacije_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var row = dgvDestinacije.Rows[e.RowIndex];
                var destinacije = _destinacijaDataManager.ProcitajXML();
                var destinacijaID = (int)row.Cells["ID"].Value;
                var destinacija = destinacije.Find(d => d.ID == destinacijaID);

                if (destinacija != null)
                {
                    destinacija.Mesto = (string)row.Cells["Mesto"].Value;
                    destinacija.Drzava = (string)row.Cells["Drzava"].Value;
                    destinacija.Cena = (decimal)row.Cells["Cena"].Value;
                    destinacija.Popust = (decimal)row.Cells["Popust"].Value;
                    destinacija.BrojDana = (int)row.Cells["BrojDana"].Value;
                    destinacija.UkupnoMesta = (int)row.Cells["UkupnoMesta"].Value;
                    destinacija.Datum = (DateTime)row.Cells["Datum"].Value;

                    _destinacijaDataManager.UpisiUXML(destinacije); // Ažuriraj XML sa celokupnom listom
                }
            }
        }

        private void dgvRezervacije_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var rezervacije = _rezervacijaDataManager.ProcitajXML();
                var row = dgvRezervacije.Rows[e.RowIndex];
                var idKorisnika = (int)row.Cells["IDKorisnika"].Value;
                var idDestinacije = (int)row.Cells["IDDestinacije"].Value;

                var rezervacija = rezervacije.Find(r => r.IDKorisnika == idKorisnika && r.IDDestinacije == idDestinacije);

                if (rezervacija != null)
                {
                    rezervacija.UkupnaCena = (decimal)row.Cells["UkupnaCena"].Value;
                    rezervacija.BrojRezervisanihMesta = (int)row.Cells["BrojRezervisaneMesta"].Value;
                    rezervacija.DatumVreme = (DateTime)row.Cells["DatumVreme"].Value;

                    _rezervacijaDataManager.UpisiUXML(rezervacije); // Update XML with the full list
                }
            }
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormDodajKorisnika());
        }

        private void btnDodajDestinaciju_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormDodajDestinaciju());
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormDodajRezervaciju());
        }

        private void btnIzbrisiKorisnika_Click(object sender, EventArgs e)
        {
            IzbrisiSelektovaniRed(dgvKorisnici, _korisnikDataManager, _rezervacijaDataManager);
        }

        private void btnIzbrisiDestinaciju_Click(object sender, EventArgs e)
        {
            IzbrisiSelektovaniRed(dgvDestinacije, _destinacijaDataManager, _rezervacijaDataManager);
        }

        private void btnIzbrisiRezervaciju_Click(object sender, EventArgs e)
        {
            IzbrisiSelektovaniRed(dgvRezervacije, _rezervacijaDataManager, _rezervacijaDataManager);
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormRegistracija());
        }
    }
}