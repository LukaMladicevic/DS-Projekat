using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Reservation;

namespace DSBooking.Infrastructure.Repository.Reservation
{
    public interface IReservationRepository
    {
        IEnumerable<ReservationObject> GetForClient(int clientId);
        IEnumerable<ReservationObject> GetAll();

        ReservationObject? Get(int id);
        
        // returns ID
        int AddReservation(ReservationAddObject reservationAddObject);
        int RemoveReservation(int reservationId);
    }
}
