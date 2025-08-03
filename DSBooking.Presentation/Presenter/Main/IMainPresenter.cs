using DSBooking.Application.DTO.Client;
using DSBooking.Domain.Entity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.Presenter.Main
{
    public interface IMainPresenter : IPresenter
    {
        void SelectClient(ClientDTO? client);
        void SelectAction(int action);

        int Action { get; }
    }
}
