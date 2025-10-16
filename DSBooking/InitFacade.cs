using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.Service.Client;
using DSBooking.Application.Service.Package;
using DSBooking.Application.Service.Reservation;
using DSBooking.Infrastructure.Factory;
using DSBooking.Infrastructure.Repository.Client;
using DSBooking.Infrastructure.Repository.Package;
using DSBooking.Infrastructure.Repository.Reservation;
using DSBooking.Infrastructure;
using DSBooking.Presentation.Presenter.Client;
using DSBooking.Presentation.Presenter.ClientAdd;
using DSBooking.Presentation.Presenter.Main;
using DSBooking.Presentation.Presenter.Package;
using DSBooking.Presentation.Presenter.Reservation;
using DSBooking.Presentation.View.Client;
using DSBooking.Presentation.View.ClientAdd;
using DSBooking.Presentation.View.Main;
using DSBooking.Presentation.View.Package;
using DSBooking.Presentation.View.Reservation;
using DSBooking.Infrastructure.Mappers;
using DSBooking.Infrastructure.Encryptor;
using DSBooking.Presentation.View.PackageAdd;
using DSBooking.Presentation.Presenter.PackageAdd;

namespace DSBooking
{
    public class InitFacade
    {
        string _configFilepath;

        // FACADE PATTERN
        public InitFacade(string configFilepath) 
        {
            _configFilepath = configFilepath;
        }

        public MainControlView Initialize()
        {
            ConfigFileParser parser = new ConfigFileParser(_configFilepath);
            ConfigFileParseResult result = parser.Parse();
            DbInfrastructureMapper mapper = new DbInfrastructureMapper(result.ConnectionString);
            IDbInfrastructureFactory connectionFactory = mapper.Map();
            DSBooking.Infrastructure.DbConnection.Initialize(connectionFactory);

            // Mappers

            ClientMapper clientMapper = new ClientMapper();
            PackageMapper packageMapper = new PackageMapper();
            ReservationMapper reservationMapper = new ReservationMapper(clientMapper, packageMapper);

            // Encryptors

            BasicEncryptor encryptor = new BasicEncryptor();

            // Repositories
            SqlClientRepository _clientRepository = new SqlClientRepository(clientMapper);
            //EncryptedClientRepository encryptedClientRepository = new EncryptedClientRepository(_clientRepository, encryptor);
            SqlPackageRepository packageRepository = new SqlPackageRepository(packageMapper);
            SqlReservationRepository reservationRepository = new SqlReservationRepository(reservationMapper);

            // Services

            ClientService clientService = new ClientService(_clientRepository);
            PackageService packageService = new PackageService(packageRepository);
            ReservationService reservationService = new ReservationService(reservationRepository);

            // Views

            ClientControlView clientControlView = new ClientControlView();
            PackageControlView packageControlView = new PackageControlView();
            ReservationControlView reservationControlView = new ReservationControlView();
            ClientAddControlView clientAddView = new ClientAddControlView();
            PackageAddControlView packageAddControlView = new PackageAddControlView();

            // Presenters

            SimpleClientPresenter clientPresenter = new SimpleClientPresenter(clientControlView, clientService);
            SimplePackagePresenter packagePresenter = new SimplePackagePresenter(packageControlView, packageService);
            SimpleReservationPresenter reservationPresenter = new SimpleReservationPresenter(reservationControlView, reservationService);
            SimpleClientAddPresenter clientAddPresenter = new SimpleClientAddPresenter(clientAddView, clientService);
            SimplePackageAddPresenter packageAddPresenter = new SimplePackageAddPresenter(packageAddControlView, packageService);

            // MainView

            //MainControlView mainView = new MainControlView(clientControlView, packageControlView, reservationControlView, clientAddView, result.Name);
            MainControlViewBuilder mainViewBuilder = new MainControlViewBuilder();
            MainControlView mainView = (
                mainViewBuilder.SetClientControlView(clientControlView)
                .SetPackageControlView(packageControlView)
                .SetReservationControlView(reservationControlView)
                .SetClientAddFormView(clientAddView)
                .SetPackageAddFormView(packageAddControlView)
                .SetTitle(result.Name)
                .Build())
                ?? throw new NullReferenceException();

            // LeadingMainPresenter

            LeadingMainPresenter mainPresenter = new LeadingMainPresenter(mainView, clientPresenter, packagePresenter, reservationPresenter, packageAddPresenter, clientAddPresenter, clientService, reservationService);

            return mainView;
        }
    }
}
