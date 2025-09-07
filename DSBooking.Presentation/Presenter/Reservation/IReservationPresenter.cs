using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.Service.Reservation;
using DSBooking.Domain.Entity.Reservation;
using DSBooking.Presentation.View.Reservation;

namespace DSBooking.Presentation.Presenter.Reservation
{
    public interface IReservationPresenter
    {
        IEnumerable<ReservationEntity> Reservations { get; }
        void ShowAll();
        void ShowForClient(int clientId);

    }
}
