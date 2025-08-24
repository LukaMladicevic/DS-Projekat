using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Reservation;

namespace DSBooking.Application.Service.Reservation
{
    public interface IReservationService
    {
        IEnumerable<ReservationObject> GetAll();
        IEnumerable<ReservationObject> GetForClient(int clientId);

        ReservationObject? Get(int id);

        // returns ID
        int AddReservation(ReservationAddObject reservationAddObject);
        void RemoveReservation(int reservationId);
    }
}
