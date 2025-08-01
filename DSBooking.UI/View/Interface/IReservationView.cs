using DSBooking.Domain.Entity;
using DSBooking.Domain.Entity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.View
{
    public interface IReservationView
    {
        event EventHandler<Client>? OnSelectedReservation;

        void ShowReservations(IEnumerable<Reservation> reservations);

    }
}
