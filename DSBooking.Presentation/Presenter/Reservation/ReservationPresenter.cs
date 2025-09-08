using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.Service.Reservation;
using DSBooking.Domain.Object.Reservation;
using DSBooking.Presentation.View.Reservation;

namespace DSBooking.Presentation.Presenter.Reservation
{
    public abstract class ReservationPresenter
    {
        public IEnumerable<ReservationObject> Reservations { get; protected set; } = Enumerable.Empty<ReservationObject>();
        public abstract void ShowAll();
        public abstract void ShowForClient(int clientId);

    }
}
