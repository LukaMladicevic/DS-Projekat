using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Client;
using DSBooking.Application.DTO.Reservation;
using DSBooking.Domain.Entity;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Presentation.Presenter.Reservation
{
    public interface IReservationPresenter : IPresenter
    {
        void ShowReservationsFor(ClientDTO client);
        void ShowAllReservations();

        IEnumerable<ReservationDTO> Reservations { get; }
    }
}
