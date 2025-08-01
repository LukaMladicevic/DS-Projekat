using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Service;
using DSBooking.Presentation.Presenter.Interface;
using DSBooking.Presentation.View.Interface;

namespace DSBooking.Presentation.Presenter.Implementation
{
    public class ClientPresenter : IClientPresenter
    {
        IClientView _view;
        IClientService _service;

        IEnumerable<Client> _clients;
        Client? _selectedClient;
        String _filterString;

        public ClientPresenter(IClientView clientView, IClientService clientService)
        {
            _view = clientView;
            _service = clientService;

            _clients = new List<Client>();
            _selectedClient = null;
            _filterString = "";
        }

        public IEnumerable<Client> Clients => _clients;

        public Client? SelectedClient => _selectedClient;

        public string FilterString { get => _filterString; }

        public void Initialize()
        {
            _view.OnClientSelection += (_, client) => SelectClient(client);
            _view.OnFilterChange += (_, filterString) => ShowClients(filterString);
        }

        public void SelectClient(Client? c)
        {
            _selectedClient = c;
            _view.HighlightClient(c);
        }

        public void ShowClients(String filterString)
        {
            IEnumerable<Client> clients = _service.GetClientsByName(filterString);

            _clients = clients;

            _view.ShowClients(clients);
        }
    }
}
