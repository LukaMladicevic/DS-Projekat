using DSBooking.Application.Service.Client;
using DSBooking.Application.Service.Reservation;
using DSBooking.Domain.Object.Client;
using DSBooking.Domain.Object.Package;
using DSBooking.Domain.Object.Reservation;
using DSBooking.Presentation.Presenter.Client;
using DSBooking.Presentation.Presenter.Command;
using DSBooking.Presentation.Presenter.Package;
using DSBooking.Presentation.Presenter.Reservation;
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
    public class MainPresenter : IMainPresenter
    {
        IMainView _mainView;
        IClientPresenter _clientPresenter;
        IPackagePresenter _packagePresenter;
        IReservationPresenter _reservationPresenter;

        IClientService _clientService;
        IReservationService _reservationService;

        MainViewMode _mode;

        CommandManager _commandManager;

        public MainPresenter(IMainView mainView, IClientPresenter clientPresenter, IPackagePresenter packagePresenter, IReservationPresenter reservationPresenter, IClientService clientService, IReservationService reservationService)
        {
            _mainView = mainView;
            _clientPresenter = clientPresenter;
            _reservationPresenter = reservationPresenter;
            _packagePresenter = packagePresenter;
            _clientService = clientService;
            _reservationService = reservationService;
            _commandManager = new CommandManager();

            _mode = MainViewMode.ShowPackages;

            _mainView.OnModeChange += (_, mode) => OnModeChange(mode);
            _mainView.OnViewLoad += (_, _) => ShowOnViewLoad();
            _mainView.OnClientAddViewOpen += (_, _) => _mainView.ShowAddClientDialog();
            _mainView.ClientAddView.ClientAddSubmitted += (_, newClient) => OnClientAddSubmitted(newClient);
            _mainView.UndoPerformed += (_, _) => _commandManager.Undo();
            _mainView.RedoPerformed += (_, _) => _commandManager.Redo();

            _mainView.ReservationView.OnSelectedReservation += (_, reservation) => OnSelectedReservation(reservation);

            _mainView.PackageView.OnSelectedPackage += (_, package) => OnSelectedPackage(package);

            _mainView.ClientView.OnClientSelection += (_, client) => SelectClient(client);
            _mainView.ClientView.OnFilterChange += (_, filterString) => _clientPresenter.SelectFilterString(filterString);
            _mainView.ClientView.OnFilterModeChange += (_, mode) => _clientPresenter.SelectFilterMode(mode);
        }

        private void OnClientAddSubmitted(ClientAddObject newClient)
        {
            AddClientCommand command = new AddClientCommand(_clientService, newClient);
            _commandManager.ExecuteCommand(command);
        }

        private void OnSelectedReservation(ReservationObject reservation)
        {
            RemoveReservationCommand command = new RemoveReservationCommand(_reservationService, reservation.Id);
            _commandManager.ExecuteCommand(command);
        }

        private void OnSelectedPackage(PackageObject package)
        {
            if (_clientPresenter.SelectedClient == null) throw new NullReferenceException();
            ReservationAddObject addObject = new ReservationAddObject(DateTime.Now, _clientPresenter.SelectedClient.Id, package.Id);
            AddReservationCommand command = new AddReservationCommand(_reservationService, addObject);
            _commandManager.ExecuteCommand(command);
        }

        private void ShowOnViewLoad()
        {
            _clientPresenter.ShowClients();
            _clientPresenter.SelectClient(_clientPresenter.SelectedClient);

            _mainView.ShowForMode(_mode);
            _packagePresenter.ShowAll();
        }

        private void OnModeChange(MainViewMode mode)
        {
            _mode = mode;
            ShowPackagesOrReservations();
        }

        private void SelectClient(ClientObject? client)
        {
            _clientPresenter.SelectClient(client);
            ShowPackagesOrReservations();
        }

        private void ShowPackagesOrReservations()
        {
            ClientObject? client = _clientPresenter.SelectedClient;
            _mainView.ShowForMode(_mode);
            if (_mode == MainViewMode.ShowPackages)
            {
                if (client != null)
                    _packagePresenter.ShowForClient(client.Id);
                else
                    _packagePresenter.ShowAll();
            }
            else
            {
                if(client != null)
                    _reservationPresenter.ShowForClient(client.Id);
                else
                    _reservationPresenter.ShowAll();
            }
        }

    }
}
