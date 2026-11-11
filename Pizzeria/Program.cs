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

            Dostawca d = new Dostawca(1, "Piotr", "Wrona", "111222333", "Skuter");
            MessageBox.Show(d.ToString());

            d.RozpocznijDostawe();
            MessageBox.Show(d.ToString());

            try
            {
                d.RozpocznijDostawe();   
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message);
            }

            d.ZakonczDostawe();
            MessageBox.Show($"{d}, dostaw: {d.Liczba_Dostaw}");

            try
            {
                d.ZakonczDostawe();     
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message);
            }


            Application.Run(new Form1());

            Application.Run(new Form1());
            Application.Run(new Form1());
        }
    }
}