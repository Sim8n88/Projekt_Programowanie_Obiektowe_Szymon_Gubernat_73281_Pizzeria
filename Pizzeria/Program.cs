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


            Pizza p = new Pizza(1, "Pepperoni", 20.00M, RozmiarPizzy.Duza);
            p.DodajDodatek(new Dodatek(1, "Ser", 3.00M));

            PozycjaZamowienia poz = new PozycjaZamowienia(1, p, 2);
            MessageBox.Show(poz.ToString());

            try
            {
                PozycjaZamowienia zla = new PozycjaZamowienia(2, p, 0);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }

            try
            {
                PozycjaZamowienia zla2 = new PozycjaZamowienia(3, null!, 1);
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message);
            }




            Application.Run(new Form1());
        }
    }
}