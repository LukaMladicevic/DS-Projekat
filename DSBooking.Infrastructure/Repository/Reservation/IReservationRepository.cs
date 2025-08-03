using DSBooking.Domain.Entity;
using DSBooking.Domain.Entity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Repository.Reservation
{
    public interface IReservationRepository : IRepository<ReservationEntity>
    {
        // ???
        IEnumerable<ReservationEntity> GetReservationsForClient(int clientId);
    }
}
