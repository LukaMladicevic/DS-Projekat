using DSBooking.Application.Service.Client;
using DSBooking.Application.Service.Reservation;
using DSBooking.Domain.Object.Client;
using DSBooking.Domain.Object.Package;
using DSBooking.Domain.Object.Reservation;
using DSBooking.Presentation.Presenter.Client;
using DSBooking.Presentation.Presenter.ClientAdd;
using DSBooking.Presentation.Presenter.Package;
using DSBooking.Presentation.Presenter.Reservation;
using DSBooking.Presentation.View.Client;
using DSBooking.Presentation.View.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.Presenter.Main
{
    public class LeadingMainPresenter : MainPresenter
    {
        public LeadingMainPresenter(IMainView mainView, ClientPresenter clientPresenter, PackagePresenter packagePresenter, SimpleReservationPresenter reservationPresenter, ClientAddPresenter clientAddPresenter, IClientService clientService, IReservationService reservationService) : base(mainView, clientPresenter, packagePresenter, reservationPresenter, clientAddPresenter, clientService, reservationService)
        {
        }

        private void ShowPackagesOrReservations()
        {
            ClientObject? client = ClientPresenter.SelectedClient;
            MainView.ShowForMode(Mode);
            if (Mode == MainViewMode.ShowPackages)
            {
                if (client != null)
                    PackagePresenter.ShowForClient(client.Id);
                else
                    PackagePresenter.ShowAll();
            }
            else
            {
                if (client != null)
                    ReservationPresenter.ShowForClient(client.Id);
                else
                    ReservationPresenter.ShowAll();
            }
        }

        protected override void DoOnViewLoad()
        {
            ClientPresenter.SelectFilterMode(ClientViewFilterMode.FilterFirstName);
            ClientPresenter.SelectFilterString("");
            ClientPresenter.ShowClients();
            ClientPresenter.SelectClient(ClientPresenter.SelectedClient);

            MainView.ShowForMode(Mode);
            PackagePresenter.ShowAll();
        }
        protected override void DoOnModeChange(MainViewMode mainViewMode)
        {
            Mode = mainViewMode;
            ShowPackagesOrReservations();
        }

        protected override void DoOnClientAddViewOpen()
        {
            MainView.ShowAddClientDialog();   
        }
        protected override void DoOnClientAddSubmitted(ClientAddObject newClient)
        {
            ClientAddPresenter.DoOnClientAddSubmitted(newClient);

            MainView.CloseAddClientDialog();
        }

        protected override void DoOnClientAddCancelled()
        {
            MainView.CloseAddClientDialog();
        }

        protected override void DoOnSelectedReservation(ReservationObject reservation)
        {
            ReservationService.RemoveReservation(reservation.Id);
        }
        protected override void DoOnSelectedPackage(PackageObject package)
        {
            if (ClientPresenter.SelectedClient == null) return;

            ReservationService.AddReservation(new ReservationAddObject(DateTime.Now, ClientPresenter.SelectedClient.Id, package.Id));
        }
        protected override void DoOnSelectedClient(ClientObject client)
        {
            ClientPresenter.SelectClient(client);
            ShowPackagesOrReservations();
        }
        protected override void DoOnClientFilterStringChange(string filterString)
        {
            ClientPresenter.SelectFilterString(filterString);
            ClientPresenter.ShowClients();
        }
        protected override void DoOnClientFilterModeChange(ClientViewFilterMode filterMode)
        {
            ClientPresenter.SelectFilterMode(filterMode);
            ClientPresenter.ShowClients();

        }
    }
}
