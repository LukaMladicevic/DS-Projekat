using DSBooking.Domain.Repository;
using DSBooking.Domain.Service.Implementation;
using DSBooking.Infrastructure;
using DSBooking.Presentation;
using DSBooking.Presentation.Presenter;
using DSBooking.Presentation.View;

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

            // Repositories
            ClientRepository clientRepository = new ClientRepository();
            ReservationRepository reservationRepository = new ReservationRepository();
            
            // Services
            ClientService clientService = new ClientService(clientRepository);
            ReservationService reservationService = new ReservationService(reservationRepository);
            
            // Views
            ClientControlView clientControlView = new ClientControlView();
            ReservationControlView reservationControlView = new ReservationControlView();
            PackageControlView packageControlView = new PackageControlView();

            MainForm mainForm = new MainForm(clientControlView, reservationControlView, packageControlView);

            Application.Run(mainForm);
        }
    }
}