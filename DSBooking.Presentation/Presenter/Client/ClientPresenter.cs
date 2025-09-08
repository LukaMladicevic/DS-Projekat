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
    public abstract class ClientPresenter
    {
        protected IClientView View { get; private set; }
        protected IClientService Service { get; private set; }

        public ClientPresenter(IClientView clientView, IClientService clientService)
        {
            View = clientView;
            Service = clientService;

            Clients = new List<ClientObject>();
            SelectedClient = null;
            FilterString = "";
        }

        public ClientViewFilterMode SelectedFilterMode { get; protected set; }
        public abstract void SelectFilterMode(ClientViewFilterMode mode);

        public string FilterString { get; protected set; } = string.Empty;
        public abstract void SelectFilterString(string filterString);

        public IEnumerable<ClientObject> Clients { get; protected set; } = Enumerable.Empty<ClientObject>();
        public abstract void ShowClients();

        public abstract void SelectClient(ClientObject? c);
        public ClientObject? SelectedClient { get; protected set; }
    }
}
