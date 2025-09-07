using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Reservation;

namespace DSBooking.Infrastructure.Repository.Reservation
{
    public class TestReservationRepository : IReservationRepository
    {
        public int AddReservation(ReservationAddObject reservationAddObject)
        {
            return 0;
        }

        public ReservationEntity? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationEntity> GetAll()
        {
            return new List<ReservationEntity>();
        }

        public IEnumerable<ReservationEntity> GetForClient(int clientId)
        {
            return new List<ReservationEntity>();
        }

        public void RemoveReservation(int reservationId)
        {
            throw new NotImplementedException();
        }
    }

}
