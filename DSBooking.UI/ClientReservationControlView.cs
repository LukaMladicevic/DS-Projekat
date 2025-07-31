using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSBooking.Presentation.View;

namespace DSBooking.Presentation
{
    public partial class ClientReservationControlView : UserControl, IClientReservationControlView
    {
        public ClientReservationControlView()
        {
            InitializeComponent();
        }

        public Control Control => this;

        public event EventHandler? ShowAllClients;
        public event EventHandler? AddClient;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ClientReservationControlView_Load(object sender, EventArgs e)
        {

        }
    }
}
