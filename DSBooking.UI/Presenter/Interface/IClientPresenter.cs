using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Presentation.Presenter
{
    public interface IClientPresenter
    {
        void ShowClients(object? sender, String filterString);

        void HighlightSelectedClient(object? sender, Client c);
    }
}
