using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Repository;
using DSBooking.Presentation.Presenter.Interface;
using DSBooking.Presentation.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.Presenter.Implementation
{
    public class MainPresenter : IMainPresenter
    {
        IMainView _mainView;
        IClientPresenter _clientPresenter;
        IPackagePresenter _packagePresenter;
        IReservationPresenter _reservationPresenter;

        int _action;

        public MainPresenter(IMainView mainView, IClientPresenter clientPresenter, IPackagePresenter packagePresenter, IReservationPresenter reservationPresenter)
        {
            _mainView = mainView;
            _clientPresenter = clientPresenter;
            _reservationPresenter = reservationPresenter;
            _packagePresenter = packagePresenter;

            _action = 0;
        }

        public void Initialize()
        {
            _mainView.ClientView.OnClientSelection += (_, client) => SelectClient(client);
            _mainView.ClientView.OnFilterChange += (_, filterString) => _clientPresenter.ShowClientsMatchingFilter(filterString);

            _mainView.OnActionChange += (_, selectedAction) => SelectAction(selectedAction);
            _mainView.OnViewLoad += (_, _) => ShowOnViewLoad();
        }
        public void ShowOnViewLoad()
        {
            _clientPresenter.ShowClientsMatchingFilter(_clientPresenter.FilterString);
            _clientPresenter.SelectClient(_clientPresenter.SelectedClient);

            _mainView.SetActionMode(_action);
            _packagePresenter.ShowPackages();
        }

        public int Action => _action;

        public void SelectAction(int action)
        {
            _action = action;

            _mainView.SetActionMode(action);

            ShowPackagesOrReservations(_clientPresenter.SelectedClient);
        }

        public void SelectClient(Client? client)
        {
            _clientPresenter.SelectClient(client);

            ShowPackagesOrReservations(client);
        }

        private void ShowPackagesOrReservations(Client? client)
        {
            if (_action == 0)
                _packagePresenter.ShowPackages();
            else
            {
                if (client != null)
                    _reservationPresenter.ShowReservationsFor(client);
                else
                    _reservationPresenter.ShowAllReservations();
            }
        }

    }
}
