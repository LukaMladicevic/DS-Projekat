using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Infrastructure.Repository.Reservation
{
    public class TestReservationRepository : TestRepository<ReservationEntity>, IReservationRepository
    {
        List<ReservationEntity> reservations = new List<ReservationEntity>();
        public TestReservationRepository()
        {
            reservations.Add(new ReservationEntity(1, 1, 1));
            reservations.Add(new ReservationEntity(2, 1, 2));
        }

        public IEnumerable<ReservationEntity> GetReservationsForClient(int clientId)
        {
            return (from r in reservations
                    where r.ClientId == clientId
                    select r).ToList();
        }
    }
}
