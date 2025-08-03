using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Client;
using DSBooking.Application.DTO.Package;
using DSBooking.Application.DTO.Reservation;
using DSBooking.Domain.Entity;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Package;
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

        public IEnumerable<ReservationDTO> GetAllReservations()
        {
            IEnumerable<ReservationEntity> reservations = _reservationRepository.GetAll();
            List<ReservationDTO> result = new List<ReservationDTO>();

            // TODO
            return result;
        }

        public IEnumerable<ReservationDTO> GetReservationsForClient(ClientDTO client)
        {
            IEnumerable<ReservationEntity> reservations = _reservationRepository.GetAll();
            List<ReservationDTO> result = new List<ReservationDTO>();

            // TODO
            return result;
        }
    }
}
