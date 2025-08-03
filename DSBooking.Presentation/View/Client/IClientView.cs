using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Client;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Presentation.View.Client
{
    public interface IClientView : IView
    {
        event EventHandler<ClientDTO>? OnClientSelection;
        event EventHandler<string>? OnFilterChange;

        void ShowClients(IEnumerable<ClientDTO> clients);
        void HighlightClient(ClientDTO? client);
    }
}
