using Pizzeria.Models.Enums;
using Pizzeria.Models.Klasy;

namespace Pizzeria
{
    public partial class DostawcaForm : Form
    {
        private readonly int _id;
        private readonly int _liczbaDostaw;

        public Dostawca? Wynik { get; private set; }

        public DostawcaForm()
        {
            InitializeComponent();
            cmbStatus.DataSource = Enum.GetValues(typeof(StatusDostawcy));
            cmbStatus.SelectedItem = StatusDostawcy.Wolny;
            _id = 0;
            _liczbaDostaw = 0;
        }

        public DostawcaForm(Dostawca dostawca) : this()
        {
            _id = dostawca.Id;
            _liczbaDostaw = dostawca.Liczba_Dostaw;
            Text = "Edycja dostawcy";
            txtImie.Text = dostawca.Imie;
            txtNazwisko.Text = dostawca.Nazwisko;
            txtTelefon.Text = dostawca.Telefon;
            txtPojazd.Text = dostawca.Pojazd;
            cmbStatus.SelectedItem = dostawca.Status_Dostawcy;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                var status = (StatusDostawcy)cmbStatus.SelectedItem!;
                Wynik = new Dostawca(_id, txtImie.Text, txtNazwisko.Text, txtTelefon.Text, txtPojazd.Text, status, _liczbaDostaw);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}