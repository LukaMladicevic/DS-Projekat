using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Client;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Presentation.Presenter.Client
{
    public interface IClientPresenter : IPresenter
    {
        void SelectClient(ClientDTO? c);
        void ShowClientsMatchingFilter(string filterString);

        IEnumerable<ClientDTO> Clients { get; }
        ClientDTO? SelectedClient { get; }

        string FilterString { get; }
    }
}
