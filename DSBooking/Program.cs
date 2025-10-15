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
            string cwd = Directory.GetCurrentDirectory();
            MessageBox.Show("Directory.GetCurrentDirectory():\n" + cwd);

            InitFacade initFacade = new InitFacade("config.txt");

            MainControlView mainView = initFacade.Initialize();

            System.Windows.Forms.Application.Run(mainView);

            //    ConfigFileParser parser = new ConfigFileParser("config.txt");
            //    ConfigFileParseResult result = parser.Parse();
            //    DbInfrastructureMapper mapper = new DbInfrastructureMapper(result.ConnectionString);
            //    IDbInfrastructureFactory connectionFactory = mapper.Map();
            //    DSBooking.Infrastructure.DbConnection.Initialize(connectionFactory);

            //    // Mappers

            //    ClientMapper clientMapper = new ClientMapper();
            //    PackageMapper packageMapper = new PackageMapper();
            //    ReservationMapper reservationMapper = new ReservationMapper(clientMapper, packageMapper);

            //    // Encryptors

            //    BasicEncryptor encryptor = new BasicEncryptor();

            //    // Repositories
            //    SqlClientRepository _clientRepository = new SqlClientRepository(clientMapper);
            //    EncryptedClientRepository encryptedClientRepository = new EncryptedClientRepository(_clientRepository, encryptor);
            //    SqlPackageRepository packageRepository = new SqlPackageRepository(packageMapper);
            //    SqlReservationRepository reservationRepository = new SqlReservationRepository(reservationMapper);

            //    // Services

            //    ClientService clientService = new ClientService(encryptedClientRepository);
            //    PackageService packageService = new PackageService(packageRepository);
            //    ReservationService reservationService = new ReservationService(reservationRepository);

            //    var reservations = reservationService.GetForClient(1);
            //    if (reservations == null || !reservations.Any())
            //    {
            //        MessageBox.Show("No reservations found for client 1.");
            //    }
            //    else
            //    {
            //        var sb = new StringBuilder();

            //        foreach (var reservation in reservations)
            //        {
            //            sb.AppendLine($"Reservation ID: {reservation.Id}");
            //            sb.AppendLine($"Client: {reservation.Client.FirstName} {reservation.Client.LastName}");
            //            sb.AppendLine($"Package: {reservation.Package.Name}");
            //            sb.AppendLine($"Type: {reservation.Package.PackageTypeName}");
            //            sb.AppendLine(new string('-', 40)); // separator line
            //        }

            //        MessageBox.Show(sb.ToString(), "Reservations Debug");
            //    }
        }
    }
}