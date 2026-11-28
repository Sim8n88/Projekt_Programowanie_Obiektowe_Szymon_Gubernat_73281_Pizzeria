using Pizzeria.Models.Klasy;

namespace Pizzeria
{
    public class ZamowienieWiersz
    {
        public Zamowienie Zamowienie { get; }

        public ZamowienieWiersz(Zamowienie zamowienie)
        {
            Zamowienie = zamowienie;
        }

        public int Id => Zamowienie.Id;
        public string Typ => Zamowienie is ZamowienieZDostawa ? "Z dostawą" : "Na wynos";
        public string Klient => $"{Zamowienie.Klient.Imie} {Zamowienie.Klient.Nazwisko}";
        public DateTime Data => Zamowienie.Data_Zlozenia;
        public string Status => Zamowienie.Status.ToString().Replace('_', ' ');
        public string Dostawca => Zamowienie is ZamowienieZDostawa z && z.Dostawca != null
            ? $"{z.Dostawca.Imie} {z.Dostawca.Nazwisko}"
            : "-";
        public decimal Razem => Zamowienie.CalkowitaCena();
    }
}