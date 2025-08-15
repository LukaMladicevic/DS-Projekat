using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;

namespace DSBooking.Presentation.Presenter.Client
{
    public interface IClientPresenter : IPresenter
    {
        void SelectClient(ClientObject? c);
        void ShowClientsMatchingFilter(string filterString);

        IEnumerable<ClientObject> Clients { get; }
        ClientObject? SelectedClient { get; }

        string FilterString { get; }
    }
}
