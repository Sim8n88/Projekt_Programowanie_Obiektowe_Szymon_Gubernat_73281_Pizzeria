using Pizzeria.Data;
using Pizzeria.Models.Klasy;
namespace Pizzeria
{
    public partial class MainForm : Form
    {
        private readonly StrefaRepository _strefyRepo = new StrefaRepository();
        private readonly DodatekRepository _dodatkiRepo = new DodatekRepository();
        private readonly KlientRepository _klienciRepo = new KlientRepository();
        private readonly DostawcaRepository _dostawcyRepo = new DostawcaRepository();
        private readonly ProduktRepository _produktyRepo = new ProduktRepository();

        public MainForm()
        {
            InitializeComponent();
            OdswiezStrefy();
            OdswiezDodatki();
            OdswiezKlientow();
            OdswiezDostawcow();
            OdswiezProdukty();
        }

        private void OdswiezStrefy()
        {
            dgvStrefy.DataSource = _strefyRepo.PobierzWszystkie();
            dgvStrefy.Columns["Id"].Visible = false;
            dgvStrefy.Columns["Koszt_Dowozu"].HeaderText = "Koszt dowozu (zł)";
            dgvStrefy.Columns["Minimalna_Kwota"].HeaderText = "Minimalna kwota (zł)";
            dgvStrefy.Columns["Koszt_Dowozu"].DefaultCellStyle.Format = "N2";
            dgvStrefy.Columns["Minimalna_Kwota"].DefaultCellStyle.Format = "N2";
            dgvStrefy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void OdswiezDodatki()
        {
            dgvDodatki.DataSource = _dodatkiRepo.PobierzWszystkie();
            dgvDodatki.Columns["Id"].Visible = false;
            dgvDodatki.Columns["Cena"].HeaderText = "Cena (zł)";
            dgvDodatki.Columns["Cena"].DefaultCellStyle.Format = "N2";
            dgvDodatki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void OdswiezKlientow()
        {
            dgvKlienci.DataSource = _klienciRepo.PobierzWszystkie();
            dgvKlienci.Columns["Id"].Visible = false;
            dgvKlienci.Columns["Imie"].HeaderText = "Imię";
            dgvKlienci.Columns["Staly_Klient"].HeaderText = "Stały klient";
            dgvKlienci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void OdswiezDostawcow()
        {
            dgvDostawcy.DataSource = _dostawcyRepo.PobierzWszystkie();
            dgvDostawcy.Columns["Id"].Visible = false;
            dgvDostawcy.Columns["Imie"].HeaderText = "Imię";
            dgvDostawcy.Columns["Status_Dostawcy"].HeaderText = "Status";
            dgvDostawcy.Columns["Liczba_Dostaw"].HeaderText = "Liczba dostaw";
            dgvDostawcy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void OdswiezProdukty()
        {
            var wiersze = new List<ProduktWiersz>();
            foreach (var produkt in _produktyRepo.PobierzWszystkie())
            {
                wiersze.Add(new ProduktWiersz(produkt));
            }

            dgvProdukty.DataSource = wiersze;
            dgvProdukty.Columns["Produkt"].Visible = false;
            dgvProdukty.Columns["Szczegoly"].HeaderText = "Szczegóły";
            dgvProdukty.Columns["Cena"].HeaderText = "Cena (zł)";
            dgvProdukty.Columns["Cena"].DefaultCellStyle.Format = "N2";
            dgvProdukty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void btnDodajStrefe_Click(object sender, EventArgs e)
        {
            using (var okno = new StrefaForm())
            {
                if (okno.ShowDialog() == DialogResult.OK && okno.Wynik != null)
                {
                    _strefyRepo.Dodaj(okno.Wynik);
                    OdswiezStrefy();
                }
            }
        }

        private void btnEdytujStrefe_Click(object sender, EventArgs e)
        {
            if (dgvStrefy.CurrentRow == null)
            {
                return;
            }

            var wybrana = (StrefaDostawy)dgvStrefy.CurrentRow.DataBoundItem;

            using (var okno = new StrefaForm(wybrana))
            {
                if (okno.ShowDialog() == DialogResult.OK && okno.Wynik != null)
                {
                    _strefyRepo.Zmien(okno.Wynik);
                    OdswiezStrefy();
                }
            }
        }

        private void btnUsunStrefe_Click(object sender, EventArgs e)
        {
            if (dgvStrefy.CurrentRow == null)
            {
                return;
            }

            var wybrana = (StrefaDostawy)dgvStrefy.CurrentRow.DataBoundItem;

            var odpowiedz = MessageBox.Show(
                "Czy na pewno usunąć strefę „" + wybrana.Nazwa + "”?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (odpowiedz == DialogResult.Yes)
            {
                _strefyRepo.Usun(wybrana.Id);
                OdswiezStrefy();
            }
        }

        private void btnDodajDodatek_Click(object sender, EventArgs e)
        {
            using (var okno = new DodatekForm())
            {
                if (okno.ShowDialog() == DialogResult.OK && okno.Wynik != null)
                {
                    _dodatkiRepo.Dodaj(okno.Wynik);
                    OdswiezDodatki();
                }
            }
        }

        private void btnEdytujDodatek_Click(object sender, EventArgs e)
        {
            if (dgvDodatki.CurrentRow == null)
            {
                return;
            }

            var wybrany = (Dodatek)dgvDodatki.CurrentRow.DataBoundItem;

            using (var okno = new DodatekForm(wybrany))
            {
                if (okno.ShowDialog() == DialogResult.OK && okno.Wynik != null)
                {
                    _dodatkiRepo.Zmien(okno.Wynik);
                    OdswiezDodatki();
                }
            }
        }

        private void btnUsunDodatek_Click(object sender, EventArgs e)
        {
            if (dgvDodatki.CurrentRow == null)
            {
                return;
            }

            var wybrany = (Dodatek)dgvDodatki.CurrentRow.DataBoundItem;

            var odpowiedz = MessageBox.Show(
                "Czy na pewno usunąć dodatek „" + wybrany.Nazwa + "”?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (odpowiedz == DialogResult.Yes)
            {
                _dodatkiRepo.Usun(wybrany.Id);
                OdswiezDodatki();
            }
        }

        private void btnDodajKlienta_Click(object sender, EventArgs e)
        {
            using (var okno = new KlientForm())
            {
                if (okno.ShowDialog() == DialogResult.OK && okno.Wynik != null)
                {
                    _klienciRepo.Dodaj(okno.Wynik);
                    OdswiezKlientow();
                }
            }
        }

        private void btnEdytujKlienta_Click(object sender, EventArgs e)
        {
            if (dgvKlienci.CurrentRow == null)
            {
                return;
            }

            var wybrany = (Klient)dgvKlienci.CurrentRow.DataBoundItem;

            using (var okno = new KlientForm(wybrany))
            {
                if (okno.ShowDialog() == DialogResult.OK && okno.Wynik != null)
                {
                    _klienciRepo.Zmien(okno.Wynik);
                    OdswiezKlientow();
                }
            }
        }

        private void btnUsunKlienta_Click(object sender, EventArgs e)
        {
            if (dgvKlienci.CurrentRow == null)
            {
                return;
            }

            var wybrany = (Klient)dgvKlienci.CurrentRow.DataBoundItem;

            var odpowiedz = MessageBox.Show(
                "Czy na pewno usunąć klienta „" + wybrany.Imie + " " + wybrany.Nazwisko + "”?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (odpowiedz == DialogResult.Yes)
            {
                _klienciRepo.Usun(wybrany.Id);
                OdswiezKlientow();
            }
        }

        private void btnDodajDostawce_Click(object sender, EventArgs e)
        {
            using (var okno = new DostawcaForm())
            {
                if (okno.ShowDialog() == DialogResult.OK && okno.Wynik != null)
                {
                    _dostawcyRepo.Dodaj(okno.Wynik);
                    OdswiezDostawcow();
                }
            }
        }

        private void btnEdytujDostawce_Click(object sender, EventArgs e)
        {
            if (dgvDostawcy.CurrentRow == null)
            {
                return;
            }

            var wybrany = (Dostawca)dgvDostawcy.CurrentRow.DataBoundItem;

            using (var okno = new DostawcaForm(wybrany))
            {
                if (okno.ShowDialog() == DialogResult.OK && okno.Wynik != null)
                {
                    _dostawcyRepo.Zmien(okno.Wynik);
                    OdswiezDostawcow();
                }
            }
        }

        private void btnUsunDostawce_Click(object sender, EventArgs e)
        {
            if (dgvDostawcy.CurrentRow == null)
            {
                return;
            }

            var wybrany = (Dostawca)dgvDostawcy.CurrentRow.DataBoundItem;

            var odpowiedz = MessageBox.Show(
                "Czy na pewno usunąć dostawcę „" + wybrany.Imie + " " + wybrany.Nazwisko + "”?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (odpowiedz == DialogResult.Yes)
            {
                _dostawcyRepo.Usun(wybrany.Id);
                OdswiezDostawcow();
            }
        }

        private void btnDodajProdukt_Click(object sender, EventArgs e)
        {
            using (var okno = new ProduktForm())
            {
                if (okno.ShowDialog() == DialogResult.OK && okno.Wynik != null)
                {
                    _produktyRepo.Dodaj(okno.Wynik);
                    OdswiezProdukty();
                }
            }
        }

        private void btnEdytujProdukt_Click(object sender, EventArgs e)
        {
            if (dgvProdukty.CurrentRow == null)
            {
                return;
            }

            var wiersz = (ProduktWiersz)dgvProdukty.CurrentRow.DataBoundItem;

            using (var okno = new ProduktForm(wiersz.Produkt))
            {
                if (okno.ShowDialog() == DialogResult.OK && okno.Wynik != null)
                {
                    _produktyRepo.Zmien(okno.Wynik);
                    OdswiezProdukty();
                }
            }
        }

        private void btnUsunProdukt_Click(object sender, EventArgs e)
        {
            if (dgvProdukty.CurrentRow == null)
            {
                return;
            }

            var wiersz = (ProduktWiersz)dgvProdukty.CurrentRow.DataBoundItem;

            var odpowiedz = MessageBox.Show(
                "Czy na pewno usunąć produkt „" + wiersz.Nazwa + "”?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (odpowiedz == DialogResult.Yes)
            {
                _produktyRepo.Usun(wiersz.Produkt.Id);
                OdswiezProdukty();
            }
        }
    }
}