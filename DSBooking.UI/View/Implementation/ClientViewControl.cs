using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSBooking.Domain.Entity.Client;
using DSBooking.Presentation.View;

namespace DSBooking.Presentation.Presenter
{
    public partial class ClientControlView : UserControl, IClientControlView
    {
        public ClientControlView()
        {
            InitializeComponent();

            clientsDataGridView.Visible = false;
        }

        public Control Control => this;

        public event EventHandler<Client>? OnClientSelection;
        public event EventHandler<Client>? OnClientAdd;
        public event EventHandler<string>? OnFilterChange;

        public void HighlightSelectedClient(Client c)
        {
            throw new NotImplementedException();
        }

        public void ShowClients(IEnumerable<Client> clients)
        {
            throw new NotImplementedException();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
