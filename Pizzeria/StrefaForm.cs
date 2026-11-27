using Pizzeria.Models.Klasy;

namespace Pizzeria
{
    public partial class StrefaForm : Form
    {
        private readonly int _id;

        public StrefaDostawy? Wynik { get; private set; }

        public StrefaForm()
        {
            InitializeComponent();
            _id = 0;
        }

        public StrefaForm(StrefaDostawy strefa) : this()
        {
            _id = strefa.Id;
            Text = "Edycja strefy dostawy";
            txtNazwa.Text = strefa.Nazwa;
            nudKoszt.Value = strefa.Koszt_Dowozu;
            nudMinimalna.Value = strefa.Minimalna_Kwota;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                Wynik = new StrefaDostawy(_id, txtNazwa.Text, nudKoszt.Value, nudMinimalna.Value);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}