using System.Data.Common;
using DSBooking.Application.Service.Client;
using DSBooking.Application.Service.Package;
using DSBooking.Application.Service.Reservation;
using DSBooking.Infrastructure;
using DSBooking.Infrastructure.Factory;
using DSBooking.Infrastructure.Repository.Client;
using DSBooking.Infrastructure.Repository.Package;
using DSBooking.Infrastructure.Repository.Reservation;
using DSBooking.Presentation.Presenter.Client;
using DSBooking.Presentation.Presenter.Main;
using DSBooking.Presentation.Presenter.Package;
using DSBooking.Presentation.Presenter.Reservation;
using DSBooking.Presentation.View.Client;
using DSBooking.Presentation.View.ClientAdd;
using DSBooking.Presentation.View.Main;
using DSBooking.Presentation.View.Package;
using DSBooking.Presentation.View.Reservation;
using DSBooking.Infrastructure.BackupDB;

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

            ConfigFileParser parser = new ConfigFileParser("config.txt");
            ConfigFileParseResult result = parser.Parse();

            DbConnectionFactoryMapper mapper = new DbConnectionFactoryMapper(result.ConnectionString);
            IDbConnectionFactory connectionFactory = mapper.Map();
            DSBooking.Infrastructure.DbConnection.Initialize(connectionFactory);

            //Backup

            //Ne znam dal ovde treba backupPath ali neka ga za sad

            string backupPath = "...path...";
            BackupManager manager = new BackupManager(result.ConnectionString,backupPath);

            // Repositories
            TestClientRepository clientRepository = new TestClientRepository();
            TestPackageRepository packageRepository = new TestPackageRepository();
            TestReservationRepository reservationRepository = new TestReservationRepository();

            // Services

            ClientService clientService = new ClientService(clientRepository);
            PackageService packageService = new PackageService(packageRepository);
            ReservationService reservationService = new ReservationService(reservationRepository);

            // Views

            ClientControlView clientControlView = new ClientControlView();
            PackageControlView packageControlView = new PackageControlView();
            ReservationControlView reservationControlView = new ReservationControlView();
            ClientAddFormView clientAddView = new ClientAddFormView();

            // Presenters

            ClientPresenter clientPresenter = new ClientPresenter(clientControlView, clientService);
            PackagePresenter packagePresenter = new PackagePresenter(packageControlView, packageService);
            ReservationPresenter reservationPresenter = new ReservationPresenter(reservationControlView, reservationService);

            // MainView

            //MainControlView mainView = new MainControlView(clientControlView, packageControlView, reservationControlView, clientAddView, result.Name);
            
            MainControlViewBuilder builder = new MainControlViewBuilder();
            MainControlView mainView = (
                builder.SetClientControlView(clientControlView)
                .SetPackageControlView(packageControlView)
                .SetReservationControlView(reservationControlView)
                .SetClientAddFormView(clientAddView)
                .SetTitle(result.Name)
                .Build())
                ?? throw new NullReferenceException();

            // MainPresenter

            MainPresenter mainPresenter = new MainPresenter(mainView, clientPresenter, packagePresenter, reservationPresenter, clientService, reservationService);

            System.Windows.Forms.Application.Run(mainView);

            // Application.Run(mainForm);
        }
    }
}