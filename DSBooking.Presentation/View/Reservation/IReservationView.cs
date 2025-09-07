using DSBooking.Domain.Entity.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.View.Reservation
{
    public interface IReservationView : IView
    {
        event EventHandler<ReservationEntity>? OnSelectedReservation;

        void ShowReservations(IEnumerable<ReservationEntity> reservations);
    }
}
