using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.Service.Client;
using DSBooking.Application.Service.Reservation;
using System.Xml.Linq;
using DSBooking.Domain.Object.Client;
using DSBooking.Presentation.Presenter.Package;
using DSBooking.Presentation.Presenter.Reservation;
using DSBooking.Presentation.View.Main;
using DSBooking.Presentation.Presenter.Client;
using DSBooking.Domain.Object.Reservation;
using DSBooking.Domain.Object.Package;
using DSBooking.Presentation.View.Client;
using DSBooking.Presentation.Presenter.ClientAdd;

namespace DSBooking.Presentation.Presenter.Main
{
    public abstract class MainPresenter
    {
        protected IMainView MainView { get; private set; }
        protected ClientPresenter ClientPresenter { get; private set; }
        protected PackagePresenter PackagePresenter { get; private set; }
        protected SimpleReservationPresenter ReservationPresenter { get; private set; }

        protected ClientAddPresenter ClientAddPresenter { get; private set; }

        protected IClientService ClientService { get; private set; }
        protected IReservationService ReservationService { get; private set; }

        protected MainViewMode Mode { get; set; }

        // TEMPLATE METHOD PATTERN
        protected MainPresenter(IMainView mainView, ClientPresenter clientPresenter, PackagePresenter packagePresenter, SimpleReservationPresenter reservationPresenter, ClientAddPresenter clientAddPresenter, IClientService clientService, IReservationService reservationService)
        {
            MainView = mainView;
            ClientPresenter = clientPresenter;
            ReservationPresenter = reservationPresenter;
            PackagePresenter = packagePresenter;
            ClientAddPresenter = clientAddPresenter;
            ClientService = clientService;
            ReservationService = reservationService;
            Mode = MainViewMode.ShowPackages;

            MainView.OnViewLoad += (_, _) => DoOnViewLoad();
            MainView.OnModeChange += (_, mode) => DoOnModeChange(mode);
            MainView.OnClientAddViewOpen += (_, _) => DoOnClientAddViewOpen();
            MainView.ClientAddView.ClientAddSubmitted += (_, newClient) => DoOnClientAddSubmitted(newClient);
            MainView.ClientAddView.ClientAddCancelled += (_, _) => DoOnClientAddCancelled();

            MainView.ReservationView.OnSelectedReservation += (_, reservation) => DoOnSelectedReservation(reservation);

            MainView.PackageView.OnSelectedPackage += (_, package) => DoOnSelectedPackage(package);

            MainView.ClientView.OnClientSelection += (_, client) => DoOnSelectedClient(client);
            MainView.ClientView.OnFilterStringChange += (_, filterString) => DoOnClientFilterStringChange(filterString);
            MainView.ClientView.OnFilterModeChange += (_, mode) => DoOnClientFilterModeChange(mode);
        }

        protected abstract void DoOnViewLoad();
        protected abstract void DoOnModeChange(MainViewMode mainViewMode);
        protected abstract void DoOnClientAddViewOpen();
        protected abstract void DoOnClientAddSubmitted(ClientAddObject newClient);
        protected abstract void DoOnClientAddCancelled();
        protected abstract void DoOnSelectedReservation(ReservationObject reservation);
        protected abstract void DoOnSelectedPackage(PackageObject package);
        protected abstract void DoOnSelectedClient(ClientObject client);
        protected abstract void DoOnClientFilterStringChange(string filterString);
        protected abstract void DoOnClientFilterModeChange(ClientViewFilterMode filterMode);
    }
}
