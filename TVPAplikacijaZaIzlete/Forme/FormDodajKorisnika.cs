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
    public partial class FormDodajKorisnika : Form
    {
        public FormDodajKorisnika()
        {
            InitializeComponent();
            tbLozinka.PasswordChar = '*';
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            DataManager<Korisnik> _korisnikDataManager = new DataManager<Korisnik>("korisnici.xml");

            string ime = tbIme.Text.Trim();
            string prezime = tbPrezime.Text.Trim();
            string korisnickoIme = tbKorisnickoIme.Text.Trim();
            string lozinka = tbLozinka.Text.Trim();
            bool jeAdmin = cbAdmin.Checked;

            if (string.IsNullOrWhiteSpace(ime) ||
                string.IsNullOrWhiteSpace(prezime) ||
                string.IsNullOrWhiteSpace(korisnickoIme) ||
                string.IsNullOrWhiteSpace(lozinka))
            {
                MessageBox.Show("Molimo vas da popunite sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var korisnici = _korisnikDataManager.ProcitajXML();
            if (korisnici.Any(k => k.KorisnickoIme == korisnickoIme))
            {
                MessageBox.Show("Korisničko ime već postoji. Molimo vas da izaberete drugo korisničko ime.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Korisnik noviKorisnik = new Korisnik
            {
                ID = _korisnikDataManager.GenerisiId(),
                Ime = ime,
                Prezime = prezime,
                KorisnickoIme = korisnickoIme,
                Lozinka = lozinka,
                VrstaKorisnika = jeAdmin ? "admin" : "klijent"
            };

            _korisnikDataManager.DodajUXML(noviKorisnik);

            MessageBox.Show("Korisnik je uspešno dodat.", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Globalne.ZameniFormu(this, new FormAdmin());
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormRegistracija());
        }
    }
}
