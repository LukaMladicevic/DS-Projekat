using DSBooking.Application.Service.Client;
using DSBooking.Domain.Object.Client;
using DSBooking.Presentation.Presenter.Client;
using DSBooking.Presentation.Presenter.Package;
using DSBooking.Presentation.Presenter.Reservation;
using DSBooking.Presentation.View.Main;
using System;
using System.Collections.Generic;
using System.Linq;
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

        MainViewMode _mode;

        public MainPresenter(IMainView mainView, IClientPresenter clientPresenter, IPackagePresenter packagePresenter, IReservationPresenter reservationPresenter, IClientService clientService)
        {
            _mainView = mainView;
            _clientPresenter = clientPresenter;
            _reservationPresenter = reservationPresenter;
            _packagePresenter = packagePresenter;
            _clientService = clientService;

            _mode = MainViewMode.ShowPackages;
        }

        public void Initialize()
        {
            _mainView.ClientView.OnClientSelection += (_, client) => SelectClient(client);
            _mainView.ClientView.OnFilterChange += (_, filterString) => _clientPresenter.ShowClientsMatchingFilter(filterString);

            _mainView.OnModeChange += (_, _) => SelectMode(
                (_mode == MainViewMode.ShowPackages) ?
                MainViewMode.ShowReservations :
                MainViewMode.ShowPackages);
            _mainView.OnViewLoad += (_, _) => ShowOnViewLoad();
            _mainView.OnClientAddViewOpen += (_, _) => _mainView.ShowAddClientDialog();
            _mainView.ClientAddView.ClientAddSubmitted += (_, newClient) => _clientService.AddClient(newClient);

        }
        public void ShowOnViewLoad()
        {
            _clientPresenter.ShowClientsMatchingFilter(_clientPresenter.FilterString);
            _clientPresenter.SelectClient(_clientPresenter.SelectedClient);

            _mainView.SetMode(_mode);
            _packagePresenter.ShowAll();
        }

        public MainViewMode Mode => _mode;

        public void SelectMode(MainViewMode mode)
        {
            _mode = mode;

            _mainView.SetMode(mode);

            ShowPackagesOrReservations(_clientPresenter.SelectedClient);
        }

        public void SelectClient(ClientObject? client)
        {
            _clientPresenter.SelectClient(client);

            ShowPackagesOrReservations(client);
        }

        private void ShowPackagesOrReservations(ClientObject? client)
        {
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
