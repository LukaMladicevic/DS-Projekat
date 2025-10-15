using DSBooking.Application.Service.Reservation;
using DSBooking.Domain.Object.Client;
using DSBooking.Domain.Object.Reservation;
using DSBooking.Presentation.View.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.Presenter.Reservation
{
    public class SimpleReservationPresenter : ReservationPresenter
    {
        IReservationView _view;
        IReservationService _service;

        public SimpleReservationPresenter(IReservationView view, IReservationService service)
        {
            _view = view;
            _service = service;

            Reservations = new List<ReservationObject>();
        }

        public override void ShowAll()
        {
            IEnumerable<ReservationObject> reservations = _service.GetAll();

            Reservations = reservations;

            _view.ShowReservations(reservations);
        }

        public override void ShowForClient(int clientId)
        {
            IEnumerable<ReservationObject> reservations = _service.GetForClient(clientId);

            Reservations = reservations;

            //var sb = new StringBuilder();
            //sb.AppendLine($"ClientId: {clientId}");
            //foreach (var reservation in reservations)
            //{
            //    sb.AppendLine($"Reservation ID: {reservation.Id}");
            //    sb.AppendLine($"Client: {reservation.Client.FirstName} {reservation.Client.LastName}");
            //    sb.AppendLine($"Package: {reservation.Package.Name}");
            //    sb.AppendLine($"Type: {reservation.Package.PackageTypeName}");
            //    sb.AppendLine(new string('-', 40));
            //}

            //MessageBox.Show(sb.ToString(), "Reservations Debug");

            _view.ShowReservations(reservations);
        }
    }
}
