using Pizzeria.Data;
using Pizzeria.Models.Klasy;
namespace Pizzeria
{
    public partial class MainForm : Form
    {
        private readonly StrefaRepository _strefyRepo = new StrefaRepository();
        private readonly DodatekRepository _dodatkiRepo = new DodatekRepository();

        public MainForm()
        {
            InitializeComponent();
            OdswiezStrefy();
            OdswiezDodatki();
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
    }
}