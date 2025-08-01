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

        public int Action => _action;

        public void Initialize()
        {
            _mainView.ClientView.OnClientSelection += (_, client) => SelectClient(client);
            _mainView.OnActionChange += (_, action) => SelectAction(action);
        }

        public void SelectAction(int action)
        {
            _action = action;

            if (_action == 0)
                _mainView.ShowPackages();
            else
                _mainView.ShowReservations();

            _clientPresenter.ShowClients(_clientPresenter.FilterString);

            if (_action == 0)
                _packagePresenter.ShowPackages();
            else
            {
                if (_clientPresenter.SelectedClient != null)
                    _reservationPresenter.ShowReservationsFor(_clientPresenter.SelectedClient);
                else
                    _reservationPresenter.ShowAllReservations();
            }
        }

        public void SelectClient(Client? client)
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
