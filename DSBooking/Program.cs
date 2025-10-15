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
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            string cwd = Directory.GetCurrentDirectory();
            //MessageBox.Show("Directory.GetCurrentDirectory():\n" + cwd);

            InitFacade initFacade = new InitFacade("config.txt");

            MainControlView mainView = initFacade.Initialize();

            System.Windows.Forms.Application.Run(mainView);
        }
    }
}