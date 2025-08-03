using DSBooking.Application.DTO.Client;
using DSBooking.Application.DTO.Reservation;
using DSBooking.Application.Service.Reservation;
using DSBooking.Domain.Entity;
using DSBooking.Domain.Entity.Client;
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

        IEnumerable<ReservationDTO> _reservations;

        public ReservationPresenter(IReservationView view, IReservationService service)
        {
            _view = view;
            _service = service;

            _reservations = new List<ReservationDTO>();
        }

        public IEnumerable<ReservationDTO> Reservations => _reservations;

        public void Initialize()
        {
        }

        public void ShowAllReservations()
        {
            IEnumerable<ReservationDTO> reservations = _service.GetAllReservations();

            _reservations = reservations;

            _view.ShowReservations(reservations);
        }

        public void ShowReservationsFor(ClientDTO client)
        {
            IEnumerable<ReservationDTO> reservations = _service.GetReservationsForClient(client);

            _reservations = reservations;

            _view.ShowReservations(reservations);
        }
    }
}
