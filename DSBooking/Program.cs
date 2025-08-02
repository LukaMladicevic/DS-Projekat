using DSBooking.Domain.Service.Implementation;
using DSBooking.Infrastructure;
using DSBooking.Presentation.Presenter;
using DSBooking.Presentation.Presenter.Implementation;
using DSBooking.Presentation.View;
using DSBooking.Presentation.View.Implementation;

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
            PackageRepository packageRepository = new PackageRepository();
            ReservationRepository reservationRepository = new ReservationRepository();

            // Services

            ClientService clientService = new ClientService(clientRepository);
            PackageService packageService = new PackageService(packageRepository);
            ReservationService reservationService = new ReservationService(reservationRepository);

            // Views

            ClientControlView clientControlView = new ClientControlView();
            PackageControlView packageControlView = new PackageControlView();
            ReservationControlView reservationControlView = new ReservationControlView();

            // Presenters

            ClientPresenter clientPresenter = new ClientPresenter(clientControlView, clientService);
            clientPresenter.Initialize();
            PackagePresenter packagePresenter = new PackagePresenter(packageControlView, packageService);
            packagePresenter.Initialize();
            ReservationPresenter reservationPresenter = new ReservationPresenter(reservationControlView, reservationService);
            reservationPresenter.Initialize();

            // MainView

            MainView mainView = new MainView(clientControlView, packageControlView, reservationControlView);

            // MainPresenter

            MainPresenter mainPresenter = new MainPresenter(mainView, clientPresenter, packagePresenter, reservationPresenter);
            mainPresenter.Initialize();

            Application.Run(mainView);

            // Application.Run(mainForm);
        }
    }
}