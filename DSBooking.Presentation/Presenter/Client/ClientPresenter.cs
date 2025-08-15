using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.Service.Client;
using DSBooking.Domain.Object.Client;
using DSBooking.Presentation.View.Client;

namespace DSBooking.Presentation.Presenter.Client
{
    public class ClientPresenter : IClientPresenter
    {
        IClientView _view;
        IClientService _service;

        IEnumerable<ClientObject> _clients;
        ClientObject? _selectedClient;
        string _filterString;

        public ClientPresenter(IClientView clientView, IClientService clientService)
        {
            _view = clientView;
            _service = clientService;

            _clients = new List<ClientObject>();
            _selectedClient = null;
            _filterString = "";
        }
        public void Initialize()
        {
        }

        public IEnumerable<ClientObject> Clients => _clients;

        public ClientObject? SelectedClient => _selectedClient;

        public string FilterString { get => _filterString; }

        public void SelectClient(ClientObject? c)
        {
            _selectedClient = c;
            _view.HighlightClient(c);
        }

        public void ShowClientsMatchingFilter(string filterString)
        {
            IEnumerable<ClientObject> clients = _service.GetByName(filterString);

            _clients = clients;

            _view.ShowClients(clients);
        }
    }
}
