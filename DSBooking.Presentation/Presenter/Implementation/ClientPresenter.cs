using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Service.Interface;
using DSBooking.Presentation.Presenter.Interface;
using DSBooking.Presentation.View.Interface;

namespace DSBooking.Presentation.Presenter.Implementation
{
    public class ClientPresenter : IClientPresenter
    {
        IClientView _clientView;
        IClientService _clientService;

        public ClientPresenter(IClientView clientView, IClientService clientService)
        {
            _clientView = clientView;
            _clientService = clientService;

            _clientView.OnClientSelection += HighlightSelectedClient;
            _clientView.OnFilterChange += ShowClients;
        }


        public void ShowClients(object? sender, string filterString)
        {
            _clientView.ShowClients(new List<Client>());
            throw new NotImplementedException();
        }

        public void HighlightSelectedClient(object? sender, Client c)
        {
            _clientView.HighlightSelectedClient(c);
        }
    }
}
