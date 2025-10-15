using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.Service.Client;
using DSBooking.Domain.Object.Client;
using DSBooking.Presentation.View.Client;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace DSBooking.Presentation.Presenter.Client
{
    public class SimpleClientPresenter : ClientPresenter
    {
        private Dictionary<ClientViewFilterMode, IFilterStrategy> _filterStrategies;

        public SimpleClientPresenter(IClientView clientView, IClientService clientService) : base(clientView, clientService)
        {
            _filterStrategies = new Dictionary<ClientViewFilterMode, IFilterStrategy>();

            _filterStrategies.Add(ClientViewFilterMode.FilterFirstName, new FirstNameFilterStrategy(clientService));
            _filterStrategies.Add(ClientViewFilterMode.FilterLastName, new LastNameFilterStrategy(clientService));
            _filterStrategies.Add(ClientViewFilterMode.FilterPassportNo, new PassportFilterStrategy(clientService));
        }

        public override void SelectClient(ClientObject? c)
        {
            SelectedClient = c;
            View.HighlightClient(c);
        }

        public override void SelectFilterMode(ClientViewFilterMode mode)
        {
            SelectedFilterMode = mode;


            Clients = _filterStrategies[SelectedFilterMode].Filter(FilterString);

        }

        public override void SelectFilterString(string filterString)
        {
            FilterString = filterString;

            Clients = _filterStrategies[SelectedFilterMode].Filter(filterString);
        }

        public override void ShowClients()
        {
            Clients = _filterStrategies[SelectedFilterMode].Filter(FilterString);
            View.ShowClients(Clients);
        }
    }
}
