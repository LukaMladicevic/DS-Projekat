using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;
using DSBooking.Presentation.View.Main;

namespace DSBooking.Presentation.Presenter.Main
{
    public interface IMainPresenter : IPresenter
    {
        void SelectClient(ClientObject? client);
        void SelectMode(MainViewMode mode);

        MainViewMode Mode { get; }
    }
}
