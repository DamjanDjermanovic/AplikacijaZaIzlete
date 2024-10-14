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
    public partial class FormPrijava : Form
    {
        private DataManager<Korisnik> _dataManager;
        public FormPrijava()
        {
            InitializeComponent();

            tbLozinka.PasswordChar = '*';

            _dataManager = new DataManager<Korisnik>("korisnici.xml");
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormRegistracija());
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            string korisnickoIme = tbKorisnickoIme.Text.Trim();
            string lozinka = tbLozinka.Text;

            if (korisnickoIme == "admin" &&
                lozinka == "admin" &&
                cbAdmin.Checked)
            {
                Globalne.ZameniFormu(this, new FormAdmin());
                return;
            }
            else if (string.IsNullOrWhiteSpace(korisnickoIme) ||
                string.IsNullOrWhiteSpace(lozinka))
            {
                MessageBox.Show("Molimo vas da popunite sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var korisnik = ProveriKorisnika(korisnickoIme, lozinka);
            if (korisnik != null)
            {
                MessageBox.Show("Uspešno ste se ulogovali.", "Dobrodošli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormKorisnik formKorisnik = new FormKorisnik(korisnik);
                Globalne.ZameniFormu(this, formKorisnik);
            }
            else
            {
                MessageBox.Show("Korisničko ime ili lozinka nisu tačni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Korisnik ProveriKorisnika(string korisnickoIme, string lozinka)
        {
            List<Korisnik> korisnici = _dataManager.ProcitajXML();
            return korisnici.FirstOrDefault(k => k.KorisnickoIme.Equals(korisnickoIme, StringComparison.OrdinalIgnoreCase) &&
                                                  k.Lozinka == lozinka);
        }
    }
}
