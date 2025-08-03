using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Client;
using DSBooking.Application.Service.Client;
using DSBooking.Presentation.View.Client;

namespace DSBooking.Presentation.Presenter.Client
{
    public class ClientPresenter : IClientPresenter
    {
        IClientView _view;
        IClientService _service;

        IEnumerable<ClientDTO> _clients;
        ClientDTO? _selectedClient;
        string _filterString;

        public ClientPresenter(IClientView clientView, IClientService clientService)
        {
            _view = clientView;
            _service = clientService;

            _clients = new List<ClientDTO>();
            _selectedClient = null;
            _filterString = "";
        }
        public void Initialize()
        {
        }

        public IEnumerable<ClientDTO> Clients => _clients;

        public ClientDTO? SelectedClient => _selectedClient;

        public string FilterString { get => _filterString; }

        public void SelectClient(ClientDTO? c)
        {
            _selectedClient = c;
            _view.HighlightClient(c);
        }

        public void ShowClientsMatchingFilter(string filterString)
        {
            IEnumerable<ClientDTO> clients = _service.GetClientsByName(filterString);

            _clients = clients;

            _view.ShowClients(clients);
        }
    }
}
