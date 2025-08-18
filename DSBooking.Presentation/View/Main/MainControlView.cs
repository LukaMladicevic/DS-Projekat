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
using DSBooking.Presentation.View.ClientAdd;
using DSBooking.Presentation.View.Package;
using DSBooking.Presentation.View.Reservation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DSBooking.Presentation.View.Main
{
    public partial class MainControlView : Form, IMainControlView
    {
        IClientControlView _clientControlView;
        IPackageControlView _packageControlView;
        IReservationControlView _reservationControlView;
        IClientAddFormView _clientAddFormView;

        public MainControlView(IClientControlView clientView, IPackageControlView packageView, IReservationControlView reservationView, IClientAddFormView clientAddForm)
        {
            _clientControlView = clientView;
            _packageControlView = packageView;
            _reservationControlView = reservationView;
            _clientAddFormView = clientAddForm;

            InitializeComponent();

            centerLayoutPanel.Controls.Add(_clientControlView.Control);

            ConfigureControl(_clientControlView.Control);
            //_clientControlView.Control.Margin = new Padding(0, 0, 0, 0);
            ConfigureControl(_packageControlView.Control);
            //_packageControlView.Control.Margin = new Padding(200, 0, 0, 0);
            ConfigureControl(_reservationControlView.Control);
            //_reservationControlView.Control.Margin = new Padding(200, 0, 0, 0);

            modeComboBox.DataSource = new[]
            {
                new KeyValuePair<MainViewMode, string>(MainViewMode.ShowPackages, "Rezervisi"),
                new KeyValuePair<MainViewMode, string>(MainViewMode.ShowReservations, "Otkaži"),
            };
            modeComboBox.DisplayMember = "Value";
            modeComboBox.ValueMember = "Key";
            modeComboBox.SelectedIndex = 0;

            SetMode(MainViewMode.ShowPackages); // Just in case the presenter doesn't set it
            this.Text = "DSBooking";
        }

        public Control Control => this;

        public IClientView ClientView => _clientControlView;

        public IReservationView ReservationView => _reservationControlView;

        public IPackageView PackageView => _packageControlView;

        public IClientAddView ClientAddView => _clientAddFormView;

        public event EventHandler? OnClientAddViewOpen;
        public event EventHandler<MainViewMode>? OnModeChange;
        public event EventHandler? OnViewLoad;

        private void ShowPackages()
        {
            centerLayoutPanel.Controls.Remove(_reservationControlView.Control);
            centerLayoutPanel.Controls.Add(_packageControlView.Control);
        }

        private void ShowReservations()
        {
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

        public void SetMode(MainViewMode mode)
        {
            if (mode == MainViewMode.ShowPackages) ShowPackages();
            else ShowReservations();
        }

        public DialogResult ShowAddClientDialog()
        {
            return _clientAddFormView.Form.ShowDialog();
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeComboBox.SelectedValue is MainViewMode mode)
            {
                OnModeChange?.Invoke(this, mode);
            }
        }
    }
}