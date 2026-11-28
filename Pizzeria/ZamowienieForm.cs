using Pizzeria.Data;
using Pizzeria.Models.Klasy;

namespace Pizzeria
{
    public partial class ZamowienieForm : Form
    {
        private readonly List<PozycjaZamowienia> _pozycje = new List<PozycjaZamowienia>();

        public Zamowienie? Wynik { get; private set; }

        public ZamowienieForm()
        {
            InitializeComponent();

            var produkty = new List<ProduktWiersz>();
            foreach (var produkt in new ProduktRepository().PobierzWszystkie())
            {
                produkty.Add(new ProduktWiersz(produkt));
            }

            cmbTyp.Items.Add("Na wynos");
            cmbTyp.Items.Add("Z dostawą");
            cmbStrefa.DisplayMember = "Nazwa";
            cmbStrefa.DataSource = new StrefaRepository().PobierzWszystkie();
            cmbProdukt.DataSource = produkty;
            cmbKlient.DataSource = new KlientRepository().PobierzWszystkie();
            dtpOdbior.Value = DateTime.Now.AddMinutes(30);
            cmbTyp.SelectedIndex = 0;
            Przelicz();
        }

        private void OdswiezPozycje()
        {
            lstPozycje.Items.Clear();
            foreach (var pozycja in _pozycje)
            {
                lstPozycje.Items.Add(pozycja);
            }
            Przelicz();
        }

        private void Przelicz()
        {
            if (cmbKlient.SelectedItem is not Klient klient)
            {
                lblPodsumowanie.Text = string.Empty;
                return;
            }

            decimal suma = 0;
            foreach (var pozycja in _pozycje)
            {
                suma += pozycja.Wartosc();
            }

            decimal rabat = suma * klient.RabatProcent() / 100;
            decimal dowoz = 0;
            if (cmbTyp.SelectedIndex == 1 && cmbStrefa.SelectedItem is StrefaDostawy strefa)
            {
                dowoz = strefa.Koszt_Dowozu;
            }

            lblPodsumowanie.Text =
                $"Suma pozycji: {suma:F2} zł\n" +
                $"Rabat: -{rabat:F2} zł\n" +
                $"Dostawa: {dowoz:F2} zł\n" +
                $"Razem: {suma - rabat + dowoz:F2} zł";
        }

        private void cmbKlient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKlient.SelectedItem is Klient klient)
            {
                txtAdres.Text = klient.Adres;
            }
            Przelicz();
        }

        private void cmbTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelWynos.Visible = cmbTyp.SelectedIndex == 0;
            panelDostawa.Visible = cmbTyp.SelectedIndex == 1;
            Przelicz();
        }

        private void cmbStrefa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Przelicz();
        }

        private void btnDodajPozycje_Click(object sender, EventArgs e)
        {
            if (cmbProdukt.SelectedItem is not ProduktWiersz wiersz)
            {
                return;
            }

            try
            {
                _pozycje.Add(new PozycjaZamowienia(0, wiersz.Produkt, (int)nudIlosc.Value));
                OdswiezPozycje();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUsunPozycje_Click(object sender, EventArgs e)
        {
            if (lstPozycje.SelectedIndex < 0)
            {
                return;
            }

            _pozycje.RemoveAt(lstPozycje.SelectedIndex);
            OdswiezPozycje();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbKlient.SelectedItem is not Klient klient)
                {
                    throw new InvalidOperationException("Wybierz klienta");
                }

                if (_pozycje.Count == 0)
                {
                    throw new InvalidOperationException("Dodaj przynajmniej jedną pozycję");
                }

                Zamowienie zamowienie;
                if (cmbTyp.SelectedIndex == 0)
                {
                    zamowienie = new ZamowienieNaWynos(0, klient, dtpOdbior.Value);
                }
                else
                {
                    if (cmbStrefa.SelectedItem is not StrefaDostawy strefa)
                    {
                        throw new InvalidOperationException("Wybierz strefę dostawy");
                    }
                    zamowienie = new ZamowienieZDostawa(0, klient, txtAdres.Text, strefa);
                }

                foreach (var pozycja in _pozycje)
                {
                    zamowienie.DodajPozycje(pozycja);
                }

                Wynik = zamowienie;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}