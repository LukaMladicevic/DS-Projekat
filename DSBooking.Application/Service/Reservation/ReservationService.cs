using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Reservation;
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

        public IEnumerable<ReservationEntity> GetAll()
        {
            return _reservationRepository.GetAll();
        }

        public IEnumerable<ReservationEntity> GetForClient(int clientId)
        {
            return _reservationRepository.GetForClient(clientId);
        }

        public int AddReservation(ReservationAddObject reservationAddObject)
        {
            return _reservationRepository.AddReservation(reservationAddObject);
        }

        public void RemoveReservation(int reservationId)
        {
            _reservationRepository.RemoveReservation(reservationId);
        }

        public ReservationEntity? Get(int id)
        {
            return _reservationRepository.Get(id);
        }
    }
}
