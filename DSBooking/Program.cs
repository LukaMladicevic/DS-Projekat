using DSBooking.Domain.Repository;
using DSBooking.Domain.Service;
using DSBooking.Infrastructure;
using DSBooking.Presentation;
using DSBooking.Presentation.Presenter;
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

            // Repositories
            ClientRepository clientRepository = new ClientRepository();
            ReservationRepository reservationRepository = new ReservationRepository();
            
            // Services
            ClientService clientService = new ClientService(clientRepository);
            ReservationService reservationService = new ReservationService(reservationRepository);

            // Views
            ClientReservationControlView clientReservationControlView = new ClientReservationControlView();

            // Presenters
            ClientReservationPresenter clientPresenter = new ClientReservationPresenter(clientReservationControlView, clientService, reservationService);

            MainForm form = new MainForm(clientReservationControlView);
            Application.Run(form);
        }
    }
}