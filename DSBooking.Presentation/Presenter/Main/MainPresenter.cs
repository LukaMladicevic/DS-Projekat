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
using DSBooking.Presentation.Presenter.PackageAdd;
using DSBooking.Infrastructure.Backup.Service;

namespace DSBooking.Presentation.Presenter.Main
{
    public abstract class MainPresenter
    {
        protected IMainView MainView { get; private set; }
        protected ClientPresenter ClientPresenter { get; private set; }
        protected PackagePresenter PackagePresenter { get; private set; }
        protected SimpleReservationPresenter ReservationPresenter { get; private set; }
        protected PackageAddPresenter PackageAddPresenter { get; private set; }
        protected ClientAddPresenter ClientAddPresenter { get; private set; }

        protected IClientService ClientService { get; private set; }
        protected IReservationService ReservationService { get; private set; }
        protected IBackupService BackupService{ get; private set; }
        protected MainViewMode Mode { get; set; }

        // TEMPLATE METHOD PATTERN
        protected MainPresenter(IMainView mainView, ClientPresenter clientPresenter, PackagePresenter packagePresenter, SimpleReservationPresenter reservationPresenter, PackageAddPresenter packageAddPresenter, ClientAddPresenter clientAddPresenter, IClientService clientService, IReservationService reservationService, IBackupService backupService)
        {
            MainView = mainView;
            ClientPresenter = clientPresenter;
            ReservationPresenter = reservationPresenter;
            PackagePresenter = packagePresenter;
            PackageAddPresenter = packageAddPresenter;
            ClientAddPresenter = clientAddPresenter;
            ClientService = clientService;
            ReservationService = reservationService;
            Mode = MainViewMode.ShowPackages;
            BackupService = backupService;

            MainView.OnViewLoad += (_, _) => DoOnViewLoad();
            MainView.OnModeChange += (_, mode) => DoOnModeChange(mode);
            MainView.OnPackageAddViewOpen += (_, _) => DoOnPackageAddViewOpen();
            MainView.OnClientAddViewOpen += (_, _) => DoOnClientAddViewOpen();
            MainView.ClientAddView.ClientAddSubmitted += (_, newClient) => DoOnClientAddSubmitted(newClient);
            MainView.ClientAddView.ClientAddCancelled += (_, _) => DoOnClientAddCancelled();

            MainView.PackageAddView.PackageAddSubmitted += (_, _) => DoOnPackageAddSubmitted(); 
            MainView.PackageAddView.PackageAddCancelled += (_, _) => DoOnPackageAddCancelled(); 
            MainView.ReservationView.OnSelectedReservation += (_, reservation) => DoOnSelectedReservation(reservation);

            MainView.PackageView.OnSelectedPackage += (_, package) => DoOnSelectedPackage(package);

            MainView.ClientView.OnClientSelection += (_, client) => DoOnSelectedClient(client);
            MainView.ClientView.OnFilterStringChange += (_, filterString) => DoOnClientFilterStringChange(filterString);
            MainView.ClientView.OnFilterModeChange += (_, mode) => DoOnClientFilterModeChange(mode);

            //MainView.OnBackupRequested += (_, _) =>
            //{
            //    try
            //    {
            //        string createdPath = BackupService.Backup();
            //        MessageBox.Show($"Backup completed:\n{createdPath}", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Backup failed: {ex.Message}", "Backup error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //};

            MainView.OnBackupRequested += (_, _) => DoOnBackupRequested();
        }

        protected abstract void DoOnViewLoad();
        protected abstract void DoOnBackupRequested();
        protected abstract void DoOnModeChange(MainViewMode mainViewMode);
        protected abstract void DoOnClientAddViewOpen();
        protected abstract void DoOnClientAddSubmitted(ClientAddObject newClient);
        protected abstract void DoOnClientAddCancelled();
        protected abstract void DoOnPackageAddViewOpen();
        protected abstract void DoOnPackageAddSubmitted();
        protected abstract void DoOnPackageAddCancelled();
        protected abstract void DoOnSelectedReservation(ReservationObject reservation);
        protected abstract void DoOnSelectedPackage(PackageObject package);
        protected abstract void DoOnSelectedClient(ClientObject client);
        protected abstract void DoOnClientFilterStringChange(string filterString);
        protected abstract void DoOnClientFilterModeChange(ClientViewFilterMode filterMode);
    }
}
