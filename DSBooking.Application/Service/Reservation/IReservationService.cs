using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Reservation;

namespace DSBooking.Application.Service.Reservation
{
    public interface IReservationService
    {
        IEnumerable<ReservationEntity> GetAll();
        IEnumerable<ReservationEntity> GetForClient(int clientId);

        ReservationEntity? Get(int id);

        // returns ID
        int AddReservation(ReservationAddObject reservationAddObject);
        void RemoveReservation(int reservationId);
    }
}
