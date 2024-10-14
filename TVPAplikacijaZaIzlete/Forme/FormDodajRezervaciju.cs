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
    public partial class FormDodajRezervaciju : Form
    {
        private DataManager<Rezervacija> _rezervacijaDataManager = new DataManager<Rezervacija>("rezervacije.xml");
        private DataManager<Destinacija> _destinacijaDataManager = new DataManager<Destinacija>("destinacije.xml");
        private DataManager<Korisnik> _korisnikDataManager = new DataManager<Korisnik>("korisnici.xml");

        public FormDodajRezervaciju()
        {
            InitializeComponent();

            List<Korisnik> korisnici = _korisnikDataManager.ProcitajXML();
            dgvKorisnici.DataSource = korisnici;

            List<Destinacija> destinacije = _destinacijaDataManager.ProcitajXML();
            dgvDestinacije.DataSource = destinacije;
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count == 0 || dgvDestinacije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo vas da selektujete korisnika i destinaciju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbBrojRezervisanihMesta.Text, out int brojRezervisanihMesta) || brojRezervisanihMesta <= 0)
            {
                MessageBox.Show("Molimo vas da unesete ispravan broj rezervisanih mesta.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var korisnikRow = dgvKorisnici.SelectedRows[0];
            int idKorisnika = (int)korisnikRow.Cells["ID"].Value;

            var destinacijaRow = dgvDestinacije.SelectedRows[0];
            int idDestinacije = (int)destinacijaRow.Cells["ID"].Value;

            List<Destinacija> destinacije = _destinacijaDataManager.ProcitajXML();
            var destinacija = destinacije.First(d => d.ID == idDestinacije);

            List<Rezervacija> rezervacije = _rezervacijaDataManager.ProcitajXML();
            if (Globalne.ProveriPreklapanjeRezervacija(rezervacije, idDestinacije, destinacija.Datum, destinacija.BrojDana))
            {
                MessageBox.Show("Korisnik vec ima rezervaciju koja se preklapa sa datumom ove destinacije!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (brojRezervisanihMesta > destinacija.BrojPreostalihMesta)
            {
                MessageBox.Show("Nema dovoljno mesta na ovoj destinaciji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Rezervacija novaRezervacija = new Rezervacija
            {
                IDKorisnika = idKorisnika,
                IDDestinacije = idDestinacije,
                BrojRezervisanihMesta = brojRezervisanihMesta,
                UkupnaCena = (destinacija.Cena * brojRezervisanihMesta) - (destinacija.Cena * brojRezervisanihMesta * destinacija.Popust / 100),
                DatumVreme = DateTime.Now,
            };

            destinacija.BrojPreostalihMesta -= brojRezervisanihMesta;
            _destinacijaDataManager.UpisiUXML(destinacije);

            _rezervacijaDataManager.DodajUXML(novaRezervacija);

            MessageBox.Show("Rezervacija je uspešno dodata.", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Globalne.ZameniFormu(this, new FormAdmin());
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormRegistracija());
        }
    }
}
