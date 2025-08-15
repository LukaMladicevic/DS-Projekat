using DSBooking.Domain.Object.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.View.Reservation
{
    public interface IReservationView : IView
    {
        event EventHandler<ReservationObject>? OnSelectedReservation;

        void ShowReservations(IEnumerable<ReservationObject> reservations);
    }
}
