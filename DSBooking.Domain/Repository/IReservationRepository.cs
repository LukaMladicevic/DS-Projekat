using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Repository
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> getReservationsForClient(Client c);
    }
}
