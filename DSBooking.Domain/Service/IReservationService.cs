using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Reservation;

namespace DSBooking.Domain.Service
{
    public interface IReservationService
    {
        IEnumerable<Reservation> GetAllReservations();

        IEnumerable<Reservation> GetReservationsForClient(Client client);
    }
}
