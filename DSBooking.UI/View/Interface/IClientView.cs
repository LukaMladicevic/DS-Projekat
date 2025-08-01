using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Presentation.View
{
    public interface IClientView
    {
        event EventHandler<Client>? OnClientSelection;
        event EventHandler<String>? OnFilterChange;

        void HighlightSelectedClient(Client c);
        
        void ShowClients(IEnumerable<Client> clients);
    }
}
