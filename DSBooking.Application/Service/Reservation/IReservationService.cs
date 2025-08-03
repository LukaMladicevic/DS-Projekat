using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Client;
using DSBooking.Application.DTO.Reservation;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Application.Service.Reservation
{
    public interface IReservationService
    {
        IEnumerable<ReservationDTO> GetAllReservations();

        IEnumerable<ReservationDTO> GetReservationsForClient(ClientDTO client);
    }
}
