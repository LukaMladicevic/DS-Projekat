using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Domain.Service
{
    public interface IReservationService
    {
        IEnumerable<Reservation> GetAll();
        IEnumerable<Reservation> GetReservationsForClient(Client client);
    }
}
