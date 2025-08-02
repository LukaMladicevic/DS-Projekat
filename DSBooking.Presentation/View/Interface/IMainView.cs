using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.View.Interface
{
    public interface IMainView : IView
    {
        event EventHandler? OnClientAddViewOpen;
        // action - reserve or remove reservation
        event EventHandler<int>? OnActionChange; // invalid eventhandler param type

        void SetActionMode(int action);

        IClientView ClientView { get; }
        IReservationView ReservationView { get; }
        IPackageView PackageView { get; }
    }
}
