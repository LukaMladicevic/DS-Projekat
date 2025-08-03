using DSBooking.Application.DTO.Reservation;
using DSBooking.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.View.Reservation
{
    public interface IReservationView : IView
    {
        event EventHandler<ReservationDTO>? OnSelectedReservation;

        void ShowReservations(IEnumerable<ReservationDTO> reservations);
    }
}
