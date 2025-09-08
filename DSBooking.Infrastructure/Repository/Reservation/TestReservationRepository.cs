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
        public void AddReservation(ReservationAddObject reservationAddObject)
        {
            throw new NotImplementedException();
        }

        public ReservationObject? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationObject> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationObject> GetForClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public void RemoveReservation(int reservationId)
        {
            throw new NotImplementedException();
        }
    }

}
