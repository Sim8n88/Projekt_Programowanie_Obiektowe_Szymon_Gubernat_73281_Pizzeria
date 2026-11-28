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
            Pizzeria.Data.DaneStartowe.Wstaw();
            Application.Run(new MainForm());
        }
    }
}