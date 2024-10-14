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
    public partial class FormDodajDestinaciju : Form
    {
        private DataManager<Destinacija> _destinacijaDataManager;
        public FormDodajDestinaciju()
        {
            InitializeComponent();

            _destinacijaDataManager = new DataManager<Destinacija>("destinacije.xml");

            dtpDatum.Value = DateTime.Now;
        }

        private void btnDodajDestinaciju_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMesto.Text) ||
                string.IsNullOrWhiteSpace(tbDrzava.Text) ||
                !decimal.TryParse(tbCena.Text, out decimal cena) ||
                !decimal.TryParse(tbPopust.Text, out decimal popust) ||
                !int.TryParse(tbBrojDana.Text, out int brojDana) ||
                !int.TryParse(tbUkupnoMesta.Text, out int ukupnoMesta))
            {
                MessageBox.Show("Molimo vas da popunite sva polja ispravno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Destinacija novaDestinacija = new Destinacija
            {
                ID = _destinacijaDataManager.GenerisiId(),
                Mesto = tbMesto.Text.Trim(),
                Drzava = tbDrzava.Text.Trim(),
                Cena = cena,
                Popust = popust,
                BrojDana = brojDana,
                UkupnoMesta = ukupnoMesta,
                BrojPreostalihMesta = ukupnoMesta,
                Datum = dtpDatum.Value
            };

            _destinacijaDataManager.DodajUXML(novaDestinacija);
            MessageBox.Show("Destinacija je uspešno dodata.", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Globalne.ZameniFormu(this, new FormAdmin());
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormRegistracija());
        }
    }
}
