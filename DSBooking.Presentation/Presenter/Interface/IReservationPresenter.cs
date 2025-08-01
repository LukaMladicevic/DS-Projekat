using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Reservation;
using DSBooking.Presentation.View.Interface;

namespace DSBooking.Presentation.Presenter.Interface
{
    public interface IReservationPresenter : IPresenter
    {
        void ShowReservationsFor(Client client);
        void ShowAllReservations();

        IEnumerable<Reservation> Reservations { get; }
    }
}
