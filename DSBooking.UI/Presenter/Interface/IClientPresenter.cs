using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Presentation.Presenter.Interface
{
    public interface IClientPresenter
    {
        void ShowClients(object? sender, string filterString);

        void HighlightSelectedClient(object? sender, Client c);
    }
}
