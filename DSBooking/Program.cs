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
            string _configFilepath = @"C:\Users\Emilija\source\repos\DS-Projekat\DS_Projekat\configLITE.txt";

            //InitFacade initFacade = new InitFacade(@"C:\Users\Emilija\source\repos\DS-Projekat\DS_Projekat\configLITE.txt");

            //MainControlView mainView = initFacade.Initialize();

            //System.Windows.Forms.Application.Run(mainView);
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
            EncryptedClientRepository encryptedClientRepository = new EncryptedClientRepository(_clientRepository, encryptor);
            SqlPackageRepository packageRepository = new SqlPackageRepository(packageMapper);
            SqlReservationRepository reservationRepository = new SqlReservationRepository(reservationMapper);

            // Services

            ClientService clientService = new ClientService(encryptedClientRepository);
            PackageService packageService = new PackageService(packageRepository);
            ReservationService reservationService = new ReservationService(reservationRepository);

            //var packages = packageRepository.GetAll();
            //if (packages == null || !packages.Any())
            //{
            //    MessageBox.Show("No packages found!");
            //} else
            //{
            //    //foreach (var package in packages)
            //    //{
            //    //    MessageBox.Show(package.Name);
            //    //}
            //    var num = packages.Count();
            //    MessageBox.Show(num.ToString());
            //}
            var package = packageRepository.Get(4);
            if (package != null)
            {
                MessageBox.Show(package.Name);
            }
            MessageBox.Show("karja");
            
            

        }
    }
}