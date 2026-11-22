using Pizzeria.Models.Klasy;
using Pizzeria.Models.Enums;
namespace Pizzeria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

           

            Pizzeria.Data.Baza.Inicjalizuj();

            var klienci = new Pizzeria.Data.KlientRepository();
            var strefy = new Pizzeria.Data.StrefaRepository();
            var produkty = new Pizzeria.Data.ProduktRepository();
            var zamowienia = new Pizzeria.Data.ZamowienieRepository();

            int idKlienta = klienci.Dodaj(new Klient(1, "Jan", "Kowalski", "123456789", "Rynek 1", true));
            int idStrefy = strefy.Dodaj(new StrefaDostawy(1, "Centrum", 5.00M, 30.00M));
            int idPizzy = produkty.Dodaj(new Pizza(1, "Pepperoni", 20.00M, RozmiarPizzy.Duza));
            int idNapoju = produkty.Dodaj(new Napoj(1, "Cola", 6.00M, 500));

            var klient = new Klient(idKlienta, "Jan", "Kowalski", "123456789", "Rynek 1", true);
            var strefa = new StrefaDostawy(idStrefy, "Centrum", 5.00M, 30.00M);
            var pizza = new Pizza(idPizzy, "Pepperoni", 20.00M, RozmiarPizzy.Duza);
            var cola = new Napoj(idNapoju, "Cola", 6.00M, 500);

            var zamowienie = new ZamowienieZDostawa(1, klient, "Rynek 1", strefa);
            zamowienie.DodajPozycje(new PozycjaZamowienia(1, pizza, 2));
            zamowienie.DodajPozycje(new PozycjaZamowienia(2, cola, 1));
            int idZamowienia = zamowienia.Dodaj(zamowienie);

            var odczytane = zamowienia.PobierzWszystkie().Find(z => z.Id == idZamowienia);
            MessageBox.Show($"{odczytane}\nStatus: {odczytane.Status}, pozycji: {odczytane.Pozycje.Count}");

            odczytane.ZmienStatus(StatusZamowienia.W_Przygotowaniu);
            zamowienia.Zmien(odczytane);
            var poZmianie = zamowienia.PobierzWszystkie().Find(z => z.Id == idZamowienia);
            MessageBox.Show($"Po zmianie statusu: {poZmianie.Status}");

            zamowienia.Usun(idZamowienia);
            produkty.Usun(idPizzy);
            produkty.Usun(idNapoju);
            strefy.Usun(idStrefy);
            klienci.Usun(idKlienta);
            MessageBox.Show($"Po usunięciu: {zamowienia.PobierzWszystkie().Count} zamówień w bazie");

            Application.Run(new Form1());




        }
    }
}