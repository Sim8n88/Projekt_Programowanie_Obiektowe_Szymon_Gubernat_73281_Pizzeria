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

            Pizza pizza1 = new Pizza(1, "Pepporoni", 20.00M, RozmiarPizzy.Mala);
            Pizza pizza2 = new Pizza(1, "Pepporoni", 20.00M, RozmiarPizzy.Srednia);
            Pizza pizza3 = new Pizza(1, "Pepporoni", 20.00M, RozmiarPizzy.Duza);
            MessageBox.Show(pizza1.ToString());
            MessageBox.Show(pizza2.ToString());
            MessageBox.Show(pizza3.ToString());
            Application.Run(new Form1());
        }
    }
}