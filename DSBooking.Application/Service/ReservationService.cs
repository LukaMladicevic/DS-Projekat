using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Reservation;
using DSBooking.Domain.Repository;

namespace DSBooking.Domain.Service.Implementation
{
    public class ReservationService : IReservationService
    {
        IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationRepository.GetAllReservations();
        }

        public IEnumerable<Reservation> GetReservationsForClient(Client client)
        {
            return _reservationRepository.GetReservationsForClient(client);
        }
    }
}
