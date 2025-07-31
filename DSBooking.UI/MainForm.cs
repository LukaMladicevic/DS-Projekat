using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSBooking.Domain.Repository;
using DSBooking.Domain.Entity.Client;
using DSBooking.Presentation;
using DSBooking.Presentation.View;

namespace DSBooking.UI
{
    public partial class MainForm : Form
    {
        IClientReservationControlView _clientReservationView;
        public MainForm(IClientReservationControlView clientReservationView)
        {
            this._clientReservationView = clientReservationView;

            InitializeComponent();

            // clientsAndReservationsTab.Dock = DockStyle.Fill;
            clientsAndReservationsTab.Controls.Add(clientReservationView.Control);
        }

        private void DSForm_Load(object sender, EventArgs e)
        {

        }
    }
}
