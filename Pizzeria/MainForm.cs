using Pizzeria.Data;
using Pizzeria.Models.Klasy;
namespace Pizzeria
{
    public partial class MainForm : Form
    {
        private readonly StrefaRepository _strefyRepo = new StrefaRepository();

        public MainForm()
        {
            InitializeComponent();
            OdswiezStrefy();
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
    }
}