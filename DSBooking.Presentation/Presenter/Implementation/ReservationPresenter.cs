using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Reservation;
using DSBooking.Domain.Repository;
using DSBooking.Domain.Service.Interface;
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

        public ReservationPresenter(IReservationView view, IReservationService service)
        {
            _view = view;
            _service = service;
        }

        public void ShowReservationsForClient(object? sender, Client c)
        {
            IEnumerable<Reservation> reservations = _service.GetReservationsForClient(c);
            _view.ShowReservations(reservations);
        }
    }
}
