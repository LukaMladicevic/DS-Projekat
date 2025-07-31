using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Presentation.View;

namespace DSBooking.Presentation.Presenter
{
    public interface IClientReservationPresenter
    {
        public void showAllClients(object? view, EventArgs e);
    }
}
