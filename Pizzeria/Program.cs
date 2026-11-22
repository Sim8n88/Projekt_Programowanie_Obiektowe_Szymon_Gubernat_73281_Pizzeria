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

            var dodatki = new Pizzeria.Data.DodatekRepository();
            int idDodatku = dodatki.Dodaj(new Dodatek(1, "Ser", 3.00M));

            var pizza = new Pizza(1, "Pepperoni", 20.00M, RozmiarPizzy.Duza);
            pizza.DodajDodatek(new Dodatek(idDodatku, "Ser", 3.00M));

            var repo = new Pizzeria.Data.ProduktRepository();
            int idPizzy = repo.Dodaj(pizza);
            int idNapoju = repo.Dodaj(new Napoj(1, "Cola", 6.00M, 500));

            var wszystkie = repo.PobierzWszystkie();
            MessageBox.Show(string.Join("\n", wszystkie));

            repo.Usun(idPizzy);
            repo.Usun(idNapoju);
            dodatki.Usun(idDodatku);
            MessageBox.Show($"Po usunięciu: {repo.PobierzWszystkie().Count} produktów w bazie");

            Application.Run(new Form1());




        }
    }
}