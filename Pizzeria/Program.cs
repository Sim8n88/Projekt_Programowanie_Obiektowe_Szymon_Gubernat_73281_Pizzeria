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

           

            Klient staly = new Klient(1, "Jan", "Kowalski", "123456789", "Rynek 1", true);
            StrefaDostawy centrum = new StrefaDostawy(1, "Centrum", 5.00M, 30.00M);
            Dostawca piotr = new Dostawca(1, "Piotr", "Wrona", "111222333", "Skuter");

            Pizza pizza = new Pizza(1, "Pepperoni", 20.00M, RozmiarPizzy.Duza);
            pizza.DodajDodatek(new Dodatek(1, "Ser", 3.00M));
            Napoj cola = new Napoj(2, "Cola", 6.00M, 500);

            ZamowienieZDostawa z = new ZamowienieZDostawa(1, staly, "Rynek 1", centrum);
            z.DodajPozycje(new PozycjaZamowienia(1, pizza, 2));
            z.DodajPozycje(new PozycjaZamowienia(2, cola, 1));
            MessageBox.Show(z.ToString());

            try
            {
                z.PrzydzielDostawce(piotr);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message);
            }

            z.ZmienStatus(StatusZamowienia.W_Przygotowaniu);
            z.ZmienStatus(StatusZamowienia.Gotowe);
            z.PrzydzielDostawce(piotr);
            MessageBox.Show($"Status: {z.Status}, dostawca: {piotr}");

            ZamowienieZDostawa male = new ZamowienieZDostawa(2, staly, "Lipowa 5", centrum);
            male.DodajPozycje(new PozycjaZamowienia(3, cola, 1));
            male.ZmienStatus(StatusZamowienia.W_Przygotowaniu);
            male.ZmienStatus(StatusZamowienia.Gotowe);
            try
            {
                male.PrzydzielDostawce(new Dostawca(2, "Adam", "Nowak", "444555666", "Rower"));
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message);
            }

            ZamowienieZDostawa trzecie = new ZamowienieZDostawa(3, staly, "Dluga 2", centrum);
            trzecie.DodajPozycje(new PozycjaZamowienia(4, pizza, 2));
            trzecie.ZmienStatus(StatusZamowienia.W_Przygotowaniu);
            trzecie.ZmienStatus(StatusZamowienia.Gotowe);
            try
            {
                trzecie.PrzydzielDostawce(piotr);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message);
            }

            Application.Run(new Form1());




        }
    }
}