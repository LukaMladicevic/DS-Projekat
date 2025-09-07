using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Reservation;

namespace DSBooking.Infrastructure.Repository.Reservation
{
    public class TestReservationRepository : IReservationRepository
    {
        public int AddReservation(ReservationAddObject reservationAddObject)
        {
            return 0;
        }

        public ReservationObject? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationObject> GetAll()
        {
            return new List<ReservationObject>();
        }

        public IEnumerable<ReservationObject> GetForClient(int clientId)
        {
            return new List<ReservationObject>();
        }

        public void RemoveReservation(int reservationId)
        {
            throw new NotImplementedException();
        }
    }

}
