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


            Napoj cola = new Napoj(1, "Cola", 6.00M, 500);
            MessageBox.Show(cola.ToString());

            try
            {
                Napoj zly = new Napoj(2, "Woda", 4.00M, 0);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }

            try
            {
                Napoj zly2 = new Napoj(3, "Sok", 5.00M, -250);
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