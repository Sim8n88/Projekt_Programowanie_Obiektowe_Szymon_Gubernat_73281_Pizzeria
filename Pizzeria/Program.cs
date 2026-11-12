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

            ApplicationConfiguration.Initialize();

            Klient staly = new Klient(1, "Jan", "Kowalski", "123456789", "Rynek 1", true);
            Pizza pizza = new Pizza(1, "Pepperoni", 20.00M, RozmiarPizzy.Duza);
            pizza.DodajDodatek(new Dodatek(1, "Ser", 3.00M));
            Napoj cola = new Napoj(2, "Cola", 6.00M, 500);

            ZamowienieNaWynos z = new ZamowienieNaWynos(1, staly, DateTime.Now.AddMinutes(30));
            z.DodajPozycje(new PozycjaZamowienia(1, pizza, 2));
            z.DodajPozycje(new PozycjaZamowienia(2, cola, 1));
            MessageBox.Show(z.ToString());

            z.ZmienStatus(StatusZamowienia.W_Przygotowaniu);
            z.ZmienStatus(StatusZamowienia.Gotowe);
            MessageBox.Show($"Status: {z.Status}");

            try
            {
                z.ZmienStatus(StatusZamowienia.Przyjete);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message);
            }

            try
            {
                z.DodajPozycje(new PozycjaZamowienia(3, cola, 1));
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message);
            }

            try
            {
                ZamowienieNaWynos zle = new ZamowienieNaWynos(2, staly, DateTime.Now.AddHours(-1));
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }

            Application.Run(new Form1());




        }
    }
}