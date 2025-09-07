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
    public class MainControlViewBuilder
    {
        private IClientControlView? _clientControlView;
        private IPackageControlView? _packageControlView;
        private IReservationControlView? _reservationControlView;
        private IClientAddFormView? _clientAddFormView;
        private string? _title;

        public MainControlViewBuilder SetClientControlView(IClientControlView clientControlView)
        {
            _clientControlView = clientControlView;
            return this;
        }

        public MainControlViewBuilder SetPackageControlView(IPackageControlView packageControlView)
        {
            _packageControlView = packageControlView;
            return this;
        }

        public MainControlViewBuilder SetReservationControlView(IReservationControlView reservationControlView)
        {
            _reservationControlView = reservationControlView;
            return this;
        }

        public MainControlViewBuilder SetClientAddFormView(IClientAddFormView clientAddFormView)
        {
            _clientAddFormView = clientAddFormView;
            return this;
        }

        public MainControlViewBuilder SetTitle(string title)
        {
            _title = title;
            return this;
        }
        public MainControlView? Build()
        {
            if (_clientControlView == null ||
                _packageControlView == null ||
                _reservationControlView == null ||
                _clientAddFormView == null ||
                string.IsNullOrWhiteSpace(_title))
            {
                return null;
            }

            return new MainControlView(
                _clientControlView,
                _packageControlView,
                _reservationControlView,
                _clientAddFormView,
                _title
            );
        }
    }
}