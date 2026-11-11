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
            Klient zwykly = new Klient(2, "Anna", "Nowak", "987654321", "Lipowa 5", false);

            MessageBox.Show($"{staly} rabat: {staly.RabatProcent()}%");
            MessageBox.Show($"{zwykly} rabat: {zwykly.RabatProcent()}%");

            try
            {
                Klient zly = new Klient(3, "Adam", "Test", "12345678", "Dluga 2", false);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }

            try
            {
                Klient zly2 = new Klient(4, "Ewa", "Test", "12345abcd", "Dluga 3", false);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }

            Application.Run(new Form1());
            Application.Run(new Form1());
        }
    }
}