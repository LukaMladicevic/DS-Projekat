using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Reservation;

namespace DSBooking.Infrastructure.Repository.Reservation
{
    public interface IReservationRepository
    {
        IEnumerable<ReservationEntity> GetForClient(int clientId);
        IEnumerable<ReservationEntity> GetAll();

        ReservationEntity? Get(int id);
        
        // returns ID
        int AddReservation(ReservationAddObject reservationAddObject);
        void RemoveReservation(int reservationId);
    }
}
