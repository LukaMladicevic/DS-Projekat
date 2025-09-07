using DSBooking.Domain.Object.Reservation;
using DSBooking.Presentation.View.Reservation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSBooking.Presentation.View.Reservation
{
    public partial class ReservationControlView : UserControl, IReservationControlView
    {
        public ReservationControlView()
        {
            InitializeComponent();

            reservationsGridView.ScrollBars = ScrollBars.None;
            reservationsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public Control Control => this;

        public event EventHandler<ReservationObject>? OnSelectedReservation;
        public event EventHandler? OnViewLoad;

        public void ShowReservations(IEnumerable<ReservationObject> reservations)
        {
            reservationsGridView.DataSource = reservations;
            reservationsGridView.Refresh();
        }

        private void ReservationControlView_Load(object sender, EventArgs e)
        {
            OnViewLoad?.Invoke(this, EventArgs.Empty);
        }
    }
}
