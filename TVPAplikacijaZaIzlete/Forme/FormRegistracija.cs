using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TVPAplikacijaZaIzlete.Forme;
using TVPAplikacijaZaIzlete.Klase;

namespace TVPAplikacijaZaIzlete
{
    public partial class FormRegistracija : Form
    {
        private DataManager<Korisnik> _dataManager;
        public FormRegistracija()
        {
            InitializeComponent();
            tbLozinka.PasswordChar = '*';
            tbPotvrdiLozinku.PasswordChar = '*';
            _dataManager = new DataManager<Korisnik>("korisnici.xml");
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormPrijava());
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            string ime = tbIme.Text.Trim();
            string prezime = tbPrezime.Text.Trim();
            string korisnickoIme = tbKorisnickoIme.Text.Trim();
            string lozinka = tbLozinka.Text;
            string potvrdiLozinku = tbPotvrdiLozinku.Text;

            if (string.IsNullOrWhiteSpace(ime) ||
                string.IsNullOrWhiteSpace(prezime) ||
                string.IsNullOrWhiteSpace(korisnickoIme) ||
                string.IsNullOrWhiteSpace(lozinka) ||
                string.IsNullOrWhiteSpace(potvrdiLozinku))
            {
                MessageBox.Show("Molimo vas da popunite sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lozinka != potvrdiLozinku)
            {
                MessageBox.Show("Lozinke se ne poklapaju. Molimo vas da proverite lozinke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (KorisnickoImeVecPostoji(korisnickoIme))
            {
                MessageBox.Show("Korisničko ime već postoji. Molimo vas da izaberete drugo korisničko ime.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Korisnik noviKorisnik = new Korisnik
                {
                    ID = _dataManager.GenerisiId(),
                    Ime = ime,
                    Prezime = prezime,
                    KorisnickoIme = korisnickoIme,
                    Lozinka = lozinka,
                    VrstaKorisnika = "klijent"
                };

                _dataManager.DodajUXML(noviKorisnik);

                MessageBox.Show("Uspešno ste se registrovali.", "Dobro došli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globalne.ZameniFormu(this, new FormPrijava());
            }
        }
        private bool KorisnickoImeVecPostoji(string korisnickoIme)
        {
            List<Korisnik> korisnici = _dataManager.ProcitajXML();
            return korisnici.Any(k => k.KorisnickoIme.Equals(korisnickoIme, StringComparison.OrdinalIgnoreCase));
        }
    }
}
