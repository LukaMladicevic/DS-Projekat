using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Presentation.View.Interface
{
    public interface IClientView
    {
        event EventHandler<Client>? OnClientSelection;
        event EventHandler<string>? OnFilterChange;

        void ShowClients(IEnumerable<Client> clients);
        void HighlightClient(Client? client);
    }
}
