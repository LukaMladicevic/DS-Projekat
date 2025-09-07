using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.Service.Client;
using DSBooking.Domain.Entity.Client;
using DSBooking.Presentation.View.Client;

namespace DSBooking.Presentation.Presenter.Client
{
    public class ClientPresenter : IClientPresenter
    {
        IClientView _view;
        IClientService _service;

        public ClientPresenter(IClientView clientView, IClientService clientService)
        {
            _view = clientView;
            _service = clientService;

            Clients = new List<ClientEntity>();
            SelectedClient = null;
            FilterString = "";
        }
        public IEnumerable<ClientEntity> Clients { get; private set; }

        public ClientEntity? SelectedClient { get; private set; }

        public ClientViewFilterMode SelectedFilterMode { get; private set; }

        public string FilterString { get; private set; }

        public void SelectClient(ClientEntity? c)
        {
            SelectedClient = c;
            _view.HighlightClient(c);
        }

        public void SelectFilterMode(ClientViewFilterMode mode)
        {
            SelectedFilterMode = mode;
            switch (mode)
            {
                case ClientViewFilterMode.FilterFirstName:
                    Clients = _service.GetByFirstName(FilterString);
                    break;
                case ClientViewFilterMode.FilterLastName:
                    Clients = _service.GetByLastName(FilterString);
                    break;
                case ClientViewFilterMode.FilterPassportNo:
                    Clients = _service.GetByPassportNo(FilterString);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public void SelectFilterString(string filterString)
        {
            FilterString = filterString;
        }

        public void ShowClients()
        {
            _view.ShowClients(Clients);
        }
    }
}
