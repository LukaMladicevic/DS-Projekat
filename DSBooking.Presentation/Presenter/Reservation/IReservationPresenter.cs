using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;
using DSBooking.Domain.Object.Reservation;

namespace DSBooking.Presentation.Presenter.Reservation
{
    public interface IReservationPresenter : IPresenter
    {
        void ShowForClient(int clientId);
        void ShowAll();

        IEnumerable<ReservationObject> Reservations { get; }
    }
}
