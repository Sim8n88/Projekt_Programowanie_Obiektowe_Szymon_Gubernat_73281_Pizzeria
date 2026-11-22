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
            var repo = new Pizzeria.Data.DodatekRepository();

            int id = repo.Dodaj(new Dodatek(1, "Ser", 3.00M));
            MessageBox.Show($"Dodano, Id = {id}");

            repo.Zmien(new Dodatek(id, "Podwójny ser", 4.50M));
            var po = repo.PobierzWszystkie().Find(d => d.Id == id);
            MessageBox.Show($"Po zmianie: {po.Nazwa}, {po.Cena} zł");

            repo.Usun(id);
            MessageBox.Show($"Po usunięciu: {repo.PobierzWszystkie().Count} dodatków w bazie");
            Application.Run(new Form1());




        }
    }
}