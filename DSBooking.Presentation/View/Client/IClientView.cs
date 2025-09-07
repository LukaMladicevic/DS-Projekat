using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Presentation.View.Client
{
    public enum ClientViewFilterMode { FilterFirstName, FilterLastName, FilterPassportNo }
    public interface IClientView : IView
    {
        event EventHandler<ClientEntity>? OnClientSelection;

        event EventHandler<string>? OnFilterChange;

        event EventHandler<ClientViewFilterMode>? OnFilterModeChange;

        void ShowClients(IEnumerable<ClientEntity> clients);
        void HighlightClient(ClientEntity? client);
    }
}
