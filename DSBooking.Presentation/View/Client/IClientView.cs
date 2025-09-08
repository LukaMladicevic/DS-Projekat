using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;

namespace DSBooking.Presentation.View.Client
{
    public enum ClientViewFilterMode { FilterFirstName, FilterLastName, FilterPassportNo }
    public interface IClientView : IView
    {
        event EventHandler<ClientObject>? OnClientSelection;

        event EventHandler<string>? OnFilterStringChange;

        event EventHandler<ClientViewFilterMode>? OnFilterModeChange;

        void ShowClients(IEnumerable<ClientObject> clients);
        void HighlightClient(ClientObject? client);
    }
}
