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
        }

        public IEnumerable<ReservationObject> GetAll()
        {
            return new List<ReservationObject>();
        }

        public IEnumerable<ReservationObject> GetForClient(int clientId)
        {
            return new List<ReservationObject>();
        }
    }

}
