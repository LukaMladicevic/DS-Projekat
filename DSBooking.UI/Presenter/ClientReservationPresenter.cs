using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Service;
using DSBooking.Presentation.View;

namespace DSBooking.Presentation.Presenter
{
    public class ClientReservationPresenter : IClientReservationPresenter
    {
        IClientReservationView _view;
        IClientService _service;
        IReservationService _reservationService;

        public ClientReservationPresenter(IClientReservationView view, IClientService service, IReservationService reservationService)
        {
            _view = view;
            _service = service;
            _reservationService = reservationService;

            _view.ShowAllClients += showAllClients;
        }

        public void showAllClients(object? view, EventArgs e)
        {
            // service.getClients();

            // view.showClients(...)
        }
    }
}
