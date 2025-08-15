using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;

namespace DSBooking.Presentation.View.Client
{
    public interface IClientView : IView
    {
        event EventHandler<ClientObject>? OnClientSelection;
        event EventHandler<string>? OnFilterChange;

        void ShowClients(IEnumerable<ClientObject> clients);
        void HighlightClient(ClientObject? client);
    }
}
