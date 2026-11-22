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

            var repo = new Pizzeria.Data.DostawcaRepository();

            int id = repo.Dodaj(new Dostawca(1, "Piotr", "Wrona", "111222333", "Skuter"));
            MessageBox.Show($"Dodano, Id = {id}");

            repo.Zmien(new Dostawca(id, "Piotr", "Wrona", "111222333", "Rower", StatusDostawcy.W_Drodze, 5));
            var po = repo.PobierzWszystkie().Find(d => d.Id == id);
            MessageBox.Show($"Po zmianie: {po.Pojazd}, {po.Status_Dostawcy}, dostaw: {po.Liczba_Dostaw}");

            repo.Usun(id);
            MessageBox.Show($"Po usunięciu: {repo.PobierzWszystkie().Count} dostawców w bazie");

            Application.Run(new Form1());




        }
    }
}