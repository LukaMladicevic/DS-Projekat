using DSBooking.Domain.Entity;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Repository;
using DSBooking.Domain.Service;
using DSBooking.Presentation.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.Presenter
{
    internal class ReservationPresenter : IReservationPresenter
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
