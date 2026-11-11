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


            StrefaDostawy centrum = new StrefaDostawy(1, "Centrum", 5.00M, 30.00M);
            MessageBox.Show(centrum.ToString());

            try
            {
                StrefaDostawy zla = new StrefaDostawy(2, "Wies", -1M, 40M);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }

            try
            {
                StrefaDostawy zla2 = new StrefaDostawy(3, "Obrzeza", 8M, -10M);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }




       
            Application.Run(new Form1());
        }
    }
}