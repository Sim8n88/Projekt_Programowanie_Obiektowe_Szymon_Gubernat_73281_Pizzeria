using Pizzeria.Data;
using Pizzeria.Models.Enums;
using Pizzeria.Models.Klasy;

namespace Pizzeria
{
    public partial class ProduktForm : Form
    {
        private readonly int _id;
        private readonly List<Dodatek> _dodatki;

        public Produkt? Wynik { get; private set; }

        public ProduktForm()
        {
            InitializeComponent();
            _id = 0;
            _dodatki = new List<Dodatek>(new DodatekRepository().PobierzWszystkie());
            cmbTyp.Items.Add("Pizza");
            cmbTyp.Items.Add("Napój");
            cmbRozmiar.DataSource = Enum.GetValues(typeof(RozmiarPizzy));
            foreach (var dodatek in _dodatki)
            {
                clbDodatki.Items.Add(dodatek);
            }
            cmbTyp.SelectedIndex = 0;
        }

        public ProduktForm(Produkt produkt) : this()
        {
            _id = produkt.Id;
            Text = "Edycja produktu";
            txtNazwa.Text = produkt.Nazwa;
            nudCena.Value = produkt.Cena_Bazowa;
            cmbTyp.Enabled = false;

            if (produkt is Pizza pizza)
            {
                cmbTyp.SelectedIndex = 0;
                cmbRozmiar.SelectedItem = pizza.Rozmiar;
                for (int i = 0; i < _dodatki.Count; i++)
                {
                    foreach (var wybrany in pizza.Dodatki)
                    {
                        if (wybrany.Id == _dodatki[i].Id)
                        {
                            clbDodatki.SetItemChecked(i, true);
                        }
                    }
                }
            }
            else if (produkt is Napoj napoj)
            {
                cmbTyp.SelectedIndex = 1;
                nudPojemnosc.Value = napoj.Pojemnosc_Ml;
            }
        }

        private void cmbTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelPizza.Visible = cmbTyp.SelectedIndex == 0;
            panelNapoj.Visible = cmbTyp.SelectedIndex == 1;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTyp.SelectedIndex == 0)
                {
                    var rozmiar = (RozmiarPizzy)cmbRozmiar.SelectedItem!;
                    var pizza = new Pizza(_id, txtNazwa.Text, nudCena.Value, rozmiar);
                    foreach (Dodatek dodatek in clbDodatki.CheckedItems)
                    {
                        pizza.DodajDodatek(dodatek);
                    }
                    Wynik = pizza;
                }
                else
                {
                    Wynik = new Napoj(_id, txtNazwa.Text, nudCena.Value, (int)nudPojemnosc.Value);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}