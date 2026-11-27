using Pizzeria.Models.Klasy;

namespace Pizzeria
{
    public partial class DodatekForm : Form
    {
        private readonly int _id;

        public Dodatek? Wynik { get; private set; }

        public DodatekForm()
        {
            InitializeComponent();
            _id = 0;
        }

        public DodatekForm(Dodatek dodatek) : this()
        {
            _id = dodatek.Id;
            Text = "Edycja dodatku";
            txtNazwa.Text = dodatek.Nazwa;
            nudCena.Value = dodatek.Cena;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                Wynik = new Dodatek(_id, txtNazwa.Text, nudCena.Value);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}