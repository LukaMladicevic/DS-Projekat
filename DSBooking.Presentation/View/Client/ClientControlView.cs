using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSBooking.Application.DTO.Client;
using DSBooking.Domain.Entity.Client;
using DSBooking.Presentation.View.Client;

namespace DSBooking.Presentation.View.Client
{
    public partial class ClientControlView : UserControl, IClientControlView
    {
        public ClientControlView()
        {
            InitializeComponent();

            clientsDataGridView.ScrollBars = ScrollBars.None;
        }

        public Control Control => this;

        public event EventHandler<ClientDTO>? OnClientSelection;
        public event EventHandler<string>? OnFilterChange;
        public event EventHandler? OnViewLoad;

        public void HighlightClient(ClientDTO? client)
        {
            // throw new NotImplementedException();
        }

        public void ShowClients(IEnumerable<ClientDTO> clients)
        {
            clientsDataGridView.DataSource = clients;
            clientsDataGridView.Refresh();
        }

        private void ClientControlView_Load(object sender, EventArgs e)
        {
            OnViewLoad?.Invoke(this, EventArgs.Empty);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            OnFilterChange?.Invoke(this, searchTextBox.Text);
        }
    }
}