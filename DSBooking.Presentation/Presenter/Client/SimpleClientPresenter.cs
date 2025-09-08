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
    public class SimpleClientPresenter : ClientPresenter
    {
        public SimpleClientPresenter(IClientView clientView, IClientService clientService) : base(clientView, clientService)
        {
        }

        public override void SelectClient(ClientObject? c)
        {
            SelectedClient = c;
            View.HighlightClient(c);
        }

        public override void SelectFilterMode(ClientViewFilterMode mode)
        {
            SelectedFilterMode = mode;
            switch (mode)
            {
                case ClientViewFilterMode.FilterFirstName:
                    Clients = Service.GetByFirstName(FilterString);
                    break;
                case ClientViewFilterMode.FilterLastName:
                    Clients = Service.GetByLastName(FilterString);
                    break;
                case ClientViewFilterMode.FilterPassportNo:
                    Clients = Service.GetByPassportNo(FilterString);
                    break;
                default:
                    throw new NotImplementedException();
            }

        }

        public override void SelectFilterString(string filterString)
        {
            FilterString = filterString;
        }

        public override void ShowClients()
        {
            View.ShowClients(Clients);
        }
    }
}
