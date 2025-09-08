using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Error;
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

        public AddResult AddReservation(ReservationAddObject reservationAddObject)
        {
            _reservationRepository.AddReservation(reservationAddObject);

            return new AddResult(Enumerable.Empty<DomainError>());
        }

        public void RemoveReservation(int reservationId)
        {
            _reservationRepository.RemoveReservation(reservationId);
        }

        public ReservationObject? Get(int id)
        {
            return _reservationRepository.Get(id);
        }
    }
}
