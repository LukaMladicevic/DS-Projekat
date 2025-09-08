using DSBooking.Presentation.View.Main;

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
            ApplicationConfiguration.Initialize();

            InitFacade initFacade = new InitFacade(@"C:\Users\Emilija\source\repos\DS-Projekat\DS_Projekat\configLITE.txt");

            MainControlView mainView = initFacade.Initialize();

            System.Windows.Forms.Application.Run(mainView);
        }
    }
}