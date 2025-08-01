using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Presentation.Presenter
{
    public interface IReservationPresenter
    {
        void ShowReservationsForClient(object? sender, Client c);
    }
}
