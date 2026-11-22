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

            var repo = new Pizzeria.Data.KlientRepository();

            int id = repo.Dodaj(new Klient(1, "Jan", "Kowalski", "123456789", "Rynek 1", false));
            MessageBox.Show($"Dodano, Id = {id}");

            repo.Zmien(new Klient(id, "Jan", "Nowak", "987654321", "Lipowa 5", true));
            var po = repo.PobierzWszystkie().Find(k => k.Id == id);
            MessageBox.Show($"Po zmianie: {po.Nazwisko}, {po.Adres}, stały: {po.Staly_Klient}");

            repo.Usun(id);
            MessageBox.Show($"Po usunięciu: {repo.PobierzWszystkie().Count} klientów w bazie");

            Application.Run(new Form1());




        }
    }
}