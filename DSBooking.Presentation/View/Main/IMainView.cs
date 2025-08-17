using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Presentation.View.Client;
using DSBooking.Presentation.View.ClientAdd;
using DSBooking.Presentation.View.Package;
using DSBooking.Presentation.View.Reservation;

namespace DSBooking.Presentation.View.Main
{
    public enum MainViewMode { ShowReservations, ShowPackages }
    public interface IMainView : IView
    {
        event EventHandler? OnClientAddViewOpen;
        // action - reserve or remove reservation
        event EventHandler? OnModeChange;

        void SetMode(MainViewMode mode);
        DialogResult ShowAddClientDialog();

        IClientView ClientView { get; }
        IReservationView ReservationView { get; }
        IPackageView PackageView { get; }
        IClientAddView ClientAddView { get; }
    }
}
