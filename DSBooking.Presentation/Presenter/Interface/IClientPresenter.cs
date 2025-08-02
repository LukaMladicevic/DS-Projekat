using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Presentation.View.Interface;

namespace DSBooking.Presentation.Presenter.Interface
{
    public interface IClientPresenter : IPresenter
    {
        void SelectClient(Client? c);
        void ShowClientsMatchingFilter(string filterString);

        IEnumerable<Client> Clients { get; }
        Client? SelectedClient { get; }
        
        string FilterString { get; }
    }
}
