using Pizzeria.Models.Klasy;

namespace Pizzeria
{
    public class ProduktWiersz
    {
        public Produkt Produkt { get; }
        public string Typ { get; }
        public string Nazwa { get; }
        public string Szczegoly { get; }
        public decimal Cena { get; }

        public ProduktWiersz(Produkt produkt)
        {
            Produkt = produkt;
            Nazwa = produkt.Nazwa;
            Cena = produkt.ObliczCene();

            if (produkt is Pizza pizza)
            {
                Typ = "Pizza";
                Szczegoly = pizza.Rozmiar.ToString();
                if (pizza.Dodatki.Count > 0)
                {
                    Szczegoly += ", dodatki: " + string.Join(", ", pizza.Dodatki.Select(d => d.Nazwa));
                }
            }
            else if (produkt is Napoj napoj)
            {
                Typ = "Napój";
                Szczegoly = napoj.Pojemnosc_Ml + " ml";
            }
            else
            {
                Typ = string.Empty;
                Szczegoly = string.Empty;
            }
        }
    }
}