using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSBooking.Presentation.View.Interface;

namespace DSBooking.Presentation.View.Implementation
{
    public partial class MainView : Form, IMainControlView
    {
        IClientControlView _clientControlView;
        IPackageControlView _packageControlView;
        IReservationControlView _reservationControlView;

        public MainView(IClientControlView clientView, IPackageControlView packageView, IReservationControlView reservationView)
        {
            _clientControlView = clientView;
            _packageControlView = packageView;
            _reservationControlView = reservationView;

            InitializeComponent();
        }

        public Control Control => this;

        public IClientView ClientView => _clientControlView;

        public IReservationView ReservationView => _reservationControlView;

        public IPackageView PackageView => _packageControlView;

        public event EventHandler? OnClientAddViewOpen;
        public event EventHandler<int>? OnActionChange;

        public void ShowPackages()
        {
            mainSplitContainer.Panel2.Controls.Clear();
            mainSplitContainer.Panel2.Controls.Add(_packageControlView.Control);
        }

        public void ShowReservations()
        {
            mainSplitContainer.Panel2.Controls.Clear();
            mainSplitContainer.Panel2.Controls.Add(_reservationControlView.Control);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            actionComboBox.SelectedIndex = 0;

            mainSplitContainer.Panel1.Controls.Add(_clientControlView.Control);
        }

        private void actionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int action = (int)actionComboBox.SelectedIndex;
            OnActionChange?.Invoke(this, action);
        }
        private void addClientButton_Click(object sender, EventArgs e)
        {
            OnClientAddViewOpen?.Invoke(this, e);
        }
    }
}