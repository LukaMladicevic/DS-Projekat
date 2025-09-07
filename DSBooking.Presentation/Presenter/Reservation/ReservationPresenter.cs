using DSBooking.Application.Service.Reservation;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Reservation;
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

        IEnumerable<ReservationEntity> _reservations;

        public ReservationPresenter(IReservationView view, IReservationService service)
        {
            _view = view;
            _service = service;

            _reservations = new List<ReservationEntity>();
        }

        public IEnumerable<ReservationEntity> Reservations => _reservations;


        public void ShowAll()
        {
            IEnumerable<ReservationEntity> reservations = _service.GetAll();

            _reservations = reservations;

            _view.ShowReservations(reservations);
        }

        public void ShowForClient(int clientId)
        {
            IEnumerable<ReservationEntity> reservations = _service.GetForClient(clientId);

            _reservations = reservations;

            _view.ShowReservations(reservations);
        }
    }
}
