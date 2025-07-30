using DSBooking.Domain.Repository;
using DSBooking.Infrastructure;
using DSBooking.UI;

namespace DSBooking
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
            DSForm form = new DSForm(new ClientRepository());
            Application.Run(form);
        }
    }
}