using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.View
{
    public interface IClientReservationView
    {
        event EventHandler? ShowAllClients, AddClient;
    }
}
