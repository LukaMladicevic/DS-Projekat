using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Reservation;
using DSBooking.Infrastructure.Repository.Reservation;

namespace DSBooking.Application.Service.Reservation
{
    public class ReservationService : IReservationService
    {
        IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public IEnumerable<ReservationObject> GetAll()
        {
            return _reservationRepository.GetAll();
        }

        public IEnumerable<ReservationObject> GetForClient(int clientId)
        {
            return _reservationRepository.GetForClient(clientId);
        }
    }
}
