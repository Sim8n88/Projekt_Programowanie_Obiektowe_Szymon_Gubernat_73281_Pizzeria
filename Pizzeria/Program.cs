using Pizzeria.Models.Klasy;
using Pizzeria.Models.Enums;
namespace Pizzeria
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Pizzeria.Data.Baza.Inicjalizuj();
            Application.Run(new Form1());
        }
    }
}