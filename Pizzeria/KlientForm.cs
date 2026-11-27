using Pizzeria.Models.Klasy;

namespace Pizzeria
{
    public partial class KlientForm : Form
    {
        private readonly int _id;

        public Klient? Wynik { get; private set; }

        public KlientForm()
        {
            InitializeComponent();
            _id = 0;
        }

        public KlientForm(Klient klient) : this()
        {
            _id = klient.Id;
            Text = "Edycja klienta";
            txtImie.Text = klient.Imie;
            txtNazwisko.Text = klient.Nazwisko;
            txtTelefon.Text = klient.Telefon;
            txtAdres.Text = klient.Adres;
            chkStaly.Checked = klient.Staly_Klient;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                Wynik = new Klient(_id, txtImie.Text, txtNazwisko.Text, txtTelefon.Text, txtAdres.Text, chkStaly.Checked);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}