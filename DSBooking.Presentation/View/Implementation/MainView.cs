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
        IClientControlView _clientView;
        IPackageControlView _packageControlView;
        IReservationControlView _reservationControlView;

        public MainView(IClientControlView clientView, IPackageControlView packageView, IReservationControlView reservationView)
        {
            _clientView = clientView;
            _packageControlView = packageView;
            _reservationControlView = reservationView;

            InitializeComponent();

            actionComboBox.SelectedIndex = 0;
        }

        public Control Control => this;

        public event EventHandler? OnClientAddViewOpen;
        public event EventHandler<int>? OnActionChange;

        public void ProcessActionChange(int action)
        {
            if (action == 0) // show reservations for selected user
            {
            }
            else if (action == 1) // show available packages
            {
            }
        }

        public void ShowClientAddView()
        {
            throw new NotImplementedException();
        }
    }
}