using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Reservation;
using DSBooking.Domain.Repository;
using DSBooking.Domain.Service;
using DSBooking.Presentation.Presenter.Interface;
using DSBooking.Presentation.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.Presenter.Implementation
{
    public class ReservationPresenter : IReservationPresenter
    {
        IReservationView _view;
        IReservationService _service;

        IEnumerable<Reservation> _reservations;

        public ReservationPresenter(IReservationView view, IReservationService service)
        {
            _view = view;
            _service = service;

            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> Reservations => _reservations;

        public void Initialize()
        {
        }

        public void ShowAllReservations()
        {
            IEnumerable<Reservation> reservations = _service.GetAllReservations();

            _reservations = reservations;

            _view.ShowReservations(reservations);
        }

        public void ShowReservationsFor(Client client)
        {
            IEnumerable<Reservation> reservations = _service.GetReservationsForClient(client);

            _reservations = reservations;

            _view.ShowReservations(reservations);
        }
    }
}
