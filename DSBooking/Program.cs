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
using System.Text;
using DSBooking.Domain.Object.Package;

namespace DSBooking
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            string cwd = Directory.GetCurrentDirectory();
            //MessageBox.Show("Directory.GetCurrentDirectory():\n" + cwd);

            InitFacade initFacade = new InitFacade("config.txt");

            MainControlView mainView = initFacade.Initialize();

            System.Windows.Forms.Application.Run(mainView);

            //ConfigFileParser parser = new ConfigFileParser("config.txt");
            //ConfigFileParseResult result = parser.Parse();
            //DbInfrastructureMapper mapper = new DbInfrastructureMapper(result.ConnectionString);
            //IDbInfrastructureFactory connectionFactory = mapper.Map();
            //DSBooking.Infrastructure.DbConnection.Initialize(connectionFactory);

            //// Mappers

            //ClientMapper clientMapper = new ClientMapper();
            //PackageMapper packageMapper = new PackageMapper();
            //ReservationMapper reservationMapper = new ReservationMapper(clientMapper, packageMapper);

            //// Encryptors

            //BasicEncryptor encryptor = new BasicEncryptor();

            //// Repositories
            //SqlClientRepository _clientRepository = new SqlClientRepository(clientMapper);
            ////EncryptedClientRepository encryptedClientRepository = new EncryptedClientRepository(_clientRepository, encryptor);
            //SqlPackageRepository packageRepository = new SqlPackageRepository(packageMapper);
            //SqlReservationRepository reservationRepository = new SqlReservationRepository(reservationMapper);

            //// Services

            //ClientService clientService = new ClientService(_clientRepository);
            //PackageService packageService = new PackageService(packageRepository);
            //ReservationService reservationService = new ReservationService(reservationRepository);

            //var packages = packageService.GetAll();
            //var count = 0;
            //var count1 = 0;

            //foreach (var package in packages)
            //{
            //    count++;
            //}

            //SeasidePackageObject seasidePackage = (SeasidePackageObject)new SeasidePackageObject.Builder()
            //                                                                .WithId(0) // 0 or -1 for "not yet persisted" — your convention
            //                                                                .WithName("Sunny Beach Escape")
            //                                                                .WithPrice(299.99)
            //                                                                .WithPackageTypeName("Seaside") // optional if your builder sets package type automatically
            //                                                                .WithDestinationName("Hvar")
            //                                                                .WithTravelTypeName("Flight")
            //                                                                .WithAccommodationTypeName("Hotel")
            //                                                                .Build();

            //var aff = packageRepository.AddPackage(seasidePackage);
            //packages = packageService.GetAll();
            //foreach (var package in packages)
            //{
            //    count1++;
            //}
            //MessageBox.Show(count + " " + count1);

        }
    }
}