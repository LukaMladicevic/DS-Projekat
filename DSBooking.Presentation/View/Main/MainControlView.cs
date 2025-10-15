using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DSBooking.Presentation.View.Client;
using DSBooking.Presentation.View.ClientAdd;
using DSBooking.Presentation.View.Package;
using DSBooking.Presentation.View.Reservation;

namespace DSBooking.Presentation.View.Main
{
    public partial class MainControlView : Form, IMainControlView
    {
        IClientControlView _clientControlView;
        IPackageControlView _packageControlView;
        IReservationControlView _reservationControlView;
        IClientAddControlView _clientAddFormView;
        //System.Windows.Forms.Timer _timer;

        public MainControlView(IClientControlView clientView, IPackageControlView packageView, IReservationControlView reservationView, IClientAddControlView clientAddForm, string title)
        {
            _clientControlView = clientView;
            _packageControlView = packageView;
            _reservationControlView = reservationView;
            _clientAddFormView = clientAddForm;

            InitializeComponent();

            //_timer = new System.Windows.Forms.Timer();
            //_timer.Interval = (int)TimeSpan.FromHours(24).TotalMilliseconds;
            //_timer.Tick += DatabaseBackupTimer_Tick;
            //_timer.Start();

            centerLayoutPanel.Controls.Add(_clientControlView.Control);

            ConfigureControl(_clientControlView.Control);
            //_clientControlView.Control.Margin = new Padding(0, 0, 0, 0);
            ConfigureControl(_packageControlView.Control);
            //_packageControlView.Control.Margin = new Padding(200, 0, 0, 0);
            ConfigureControl(_reservationControlView.Control);
            //_reservationControlView.Control.Margin = new Padding(200, 0, 0, 0);

            modeComboBox.DataSource = new[]
            {
                new KeyValuePair<MainViewMode, string>(MainViewMode.ShowPackages, "Rezerviši"),
                new KeyValuePair<MainViewMode, string>(MainViewMode.ShowReservations, "Otkaži"),
            };
            modeComboBox.DisplayMember = "Value";
            modeComboBox.ValueMember = "Key";
            modeComboBox.SelectedIndex = 0;

            UpdateToggleButtonText();

            ShowForMode(MainViewMode.ShowPackages); 
            this.Text = title;
            agencyNameLabel.Text = title;
        }

        public Control Control => this;

        public IClientView ClientView => _clientControlView;

        public IReservationView ReservationView => _reservationControlView;

        public IPackageView PackageView => _packageControlView;

        public IClientAddView ClientAddView => _clientAddFormView;

        public event EventHandler? OnClientAddViewOpen;
        public event EventHandler<MainViewMode>? OnModeChange;
        public event EventHandler? OnViewLoad;
        //public event EventHandler? DatabaseBackup;


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

        public void ShowForMode(MainViewMode mode)
        {
            if (mode == MainViewMode.ShowPackages) ShowPackages();
            else ShowReservations();

            UpdateToggleButtonText();
        }

        public void ShowAddClientDialog()
        {
            _clientAddFormView.Control.Show();
        }

        public void CloseAddClientDialog()
        {
            _clientAddFormView.Control.Hide();
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeComboBox.SelectedValue is MainViewMode mode)
            {
                OnModeChange?.Invoke(this, mode);

                UpdateToggleButtonText();
            }
        }

        private void showToggleButton_Click(object sender, EventArgs e)
        {
            modeComboBox.SelectedIndex = modeComboBox.SelectedIndex == 0 ? 1 : 0;
        }

        private void UpdateToggleButtonText()
        {
            if (showToggleButton == null) return; 

            showToggleButton.Text = (modeComboBox.SelectedIndex == 0) ? "Show Reservations" : "Show Packages";
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void centerLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void DatabaseBackupTimer_Tick(object sender, EventArgs e)
        //{
        //    DatabaseBackup?.Invoke(this, EventArgs.Empty);
        //}
    }
}
