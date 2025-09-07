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
    public interface IReservationPresenter
    {
        IEnumerable<ReservationObject> Reservations { get; }
        void ShowAll();
        void ShowForClient(int clientId);

    }
}
