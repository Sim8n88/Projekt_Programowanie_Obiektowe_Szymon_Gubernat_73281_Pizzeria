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
            var repo = new Pizzeria.Data.StrefaRepository();

       
            int id = repo.Dodaj(new StrefaDostawy(1, "Test", 7.00M, 40.00M));
            MessageBox.Show($"Dodano, Id = {id}");

            repo.Zmien(new StrefaDostawy(id, "Test zmieniony", 9.00M, 50.00M));
            var po = repo.PobierzWszystkie().Find(s => s.Id == id);
            MessageBox.Show($"Po zmianie: {po.Nazwa}, {po.Koszt_Dowozu} zł");

            repo.Usun(id);
            MessageBox.Show($"Po usunięciu: {repo.PobierzWszystkie().Count} stref w bazie");
            Application.Run(new Form1());




        }
    }
}