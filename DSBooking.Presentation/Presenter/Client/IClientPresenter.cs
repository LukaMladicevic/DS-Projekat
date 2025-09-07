using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Presentation.View.Client;

namespace DSBooking.Presentation.Presenter.Client
{
    public interface IClientPresenter
    {
        ClientViewFilterMode SelectedFilterMode { get; }
        void SelectFilterMode(ClientViewFilterMode mode);

        string FilterString { get; }
        void SelectFilterString(string filterString);

        IEnumerable<ClientEntity> Clients { get; }
        void ShowClients();

        void SelectClient(ClientEntity? c);
        ClientEntity? SelectedClient { get; }
    }
}
