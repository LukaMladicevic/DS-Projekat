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
    public class ReservationPresenter : IReservationPresenter
    {
        IReservationView _view;
        IReservationService _service;

        IEnumerable<ReservationObject> _reservations;

        public ReservationPresenter(IReservationView view, IReservationService service)
        {
            _view = view;
            _service = service;

            _reservations = new List<ReservationObject>();
        }

        public IEnumerable<ReservationObject> Reservations => _reservations;

        public void Initialize()
        {
        }

        public void ShowAllReservations()
        {
            IEnumerable<ReservationObject> reservations = _service.GetAll();

            _reservations = reservations;

            _view.ShowReservations(reservations);
        }

        public void ShowReservationsFor(ClientObject client)
        {
            IEnumerable<ReservationObject> reservations = _service.GetForClient(client.Id);

            _reservations = reservations;

            _view.ShowReservations(reservations);
        }
    }
}
