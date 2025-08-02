using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.View.Interface
{
    public interface IReservationView : IView
    {
        event EventHandler<Reservation>? OnSelectedReservation;

        void ShowReservations(IEnumerable<Reservation> reservations);
    }
}
