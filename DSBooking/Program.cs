using DSBooking.Application.Service.Client;
using DSBooking.Application.Service.Package;
using DSBooking.Application.Service.Reservation;
using DSBooking.Infrastructure.Encryptor;
using DSBooking.Infrastructure.Factory;
using DSBooking.Infrastructure.Mappers;
using DSBooking.Infrastructure.Repository.Client;
using DSBooking.Infrastructure.Repository.Package;
using DSBooking.Infrastructure.Repository.Reservation;
using DSBooking.Infrastructure;
using DSBooking.Presentation.View.Client;
using DSBooking.Presentation.View.ClientAdd;
using DSBooking.Presentation.View.Main;
using DSBooking.Presentation.View.Package;
using DSBooking.Presentation.View.Reservation;

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

            InitFacade initFacade = new InitFacade("config.txt");

            MainControlView mainView = initFacade.Initialize();

            System.Windows.Forms.Application.Run(mainView);
        }
    }
}