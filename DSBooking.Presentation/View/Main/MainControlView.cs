using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSBooking.Presentation.View.Client;
using DSBooking.Presentation.View.Package;
using DSBooking.Presentation.View.Reservation;

namespace DSBooking.Presentation.View.Main
{
    public partial class MainControlView : Form, IMainControlView
    {
        IClientControlView _clientControlView;
        IPackageControlView _packageControlView;
        IReservationControlView _reservationControlView;

        int _action;

        public MainControlView(IClientControlView clientView, IPackageControlView packageView, IReservationControlView reservationView)
        {
            _clientControlView = clientView;
            _packageControlView = packageView;
            _reservationControlView = reservationView;

            InitializeComponent();

            centerLayoutPanel.Controls.Add(_clientControlView.Control);

            ConfigureControl(_clientControlView.Control);
            //_clientControlView.Control.Margin = new Padding(0, 0, 0, 0);
            ConfigureControl(_packageControlView.Control);
            //_packageControlView.Control.Margin = new Padding(200, 0, 0, 0);
            ConfigureControl(_reservationControlView.Control);
            //_reservationControlView.Control.Margin = new Padding(200, 0, 0, 0);

            SetActionMode(0); // Just in case the presenter doesn't set it
            this.Text = "DSBooking";
        }

        public Control Control => this;

        public IClientView ClientView => _clientControlView;

        public IReservationView ReservationView => _reservationControlView;

        public IPackageView PackageView => _packageControlView;

        public event EventHandler? OnClientAddViewOpen;
        public event EventHandler<int>? OnActionChange;
        public event EventHandler? OnViewLoad;

        private void ShowPackages()
        {
            actionButton.Text = "Rezervisanje";
            centerLayoutPanel.Controls.Remove(_reservationControlView.Control);
            centerLayoutPanel.Controls.Add(_packageControlView.Control);
        }

        private void ShowReservations()
        {
            actionButton.Text = "Otkazivanje";
            centerLayoutPanel.Controls.Remove(_packageControlView.Control);
            centerLayoutPanel.Controls.Add(_reservationControlView.Control);
        }

        private void ConfigureControl(Control control)
        {
            control.Dock = DockStyle.Fill;
            //control.MinimumSize = new Size(500, 500);
            //control.MaximumSize = new Size(10000, 10000);
            control.Anchor = AnchorStyles.None;
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            OnViewLoad?.Invoke(this, EventArgs.Empty);
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            OnClientAddViewOpen?.Invoke(this, EventArgs.Empty);
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            _action = (_action == 0) ? 1 : 0;
            OnActionChange?.Invoke(this, _action);
        }

        public void SetActionMode(int action)
        {
            _action = action;
            if(action == 0) ShowPackages();
            else ShowReservations();
        }
    }
}