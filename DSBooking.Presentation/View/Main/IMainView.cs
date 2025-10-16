using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Presentation.View.Client;
using DSBooking.Presentation.View.ClientAdd;
using DSBooking.Presentation.View.Package;
using DSBooking.Presentation.View.PackageAdd;
using DSBooking.Presentation.View.Reservation;

namespace DSBooking.Presentation.View.Main
{
    public enum MainViewMode { ShowReservations, ShowPackages }
    public interface IMainView : IView
    {
        event EventHandler? OnClientAddViewOpen;
        event EventHandler<MainViewMode>? OnModeChange;
        event EventHandler? OnPackageAddViewOpen;
        event EventHandler? OnBackupRequested;
        void ShowForMode(MainViewMode mode);
        void ShowAddClientDialog();
        void CloseAddClientDialog();
        void ShowAddPackageDialog();    
        void CloseAddPackageDialog();   

        IClientView ClientView { get; }
        IReservationView ReservationView { get; }
        IPackageView PackageView { get; }
        IClientAddView ClientAddView { get; }
        IPackageAddControlView PackageAddView { get; }
    }
}
