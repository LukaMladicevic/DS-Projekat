using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Reservation;
using DSBooking.Presentation.View.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSBooking.Presentation.View
{
    public partial class ReservationControlView : UserControl, IReservationControlView
    {
        public ReservationControlView()
        {
            InitializeComponent();

            reservationsGridView.ColumnCount = 3;
            reservationsGridView.Columns[0].Name = "ID";
            reservationsGridView.Columns[1].Name = "Name";
            reservationsGridView.Columns[2].Name = "Age";

            // Add a row and set cell values
            reservationsGridView.Rows.Add("1", "Alice", "25");
            //reservationsGridView.Visible = false;
        }

        public Control Control => throw new NotImplementedException();

        public event EventHandler<Client>? OnSelectedReservation;

        public void ShowReservations(IEnumerable<Reservation> reservations)
        {
            throw new NotImplementedException();
        }

        private void ReservationControlView_Load(object sender, EventArgs e)
        {

        }
    }
}
