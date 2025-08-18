using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSBooking.Domain.Object.Client;
using DSBooking.Presentation.View.Client;

namespace DSBooking.Presentation.View.Client
{
    public partial class ClientControlView : UserControl, IClientControlView
    {
        public ClientControlView()
        {
            InitializeComponent();

            clientsDataGridView.ScrollBars = ScrollBars.None;
            clientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public Control Control => this;

        public event EventHandler<ClientObject>? OnClientSelection;
        public event EventHandler<string>? OnFilterChange;
        public event EventHandler? OnViewLoad;

        public void HighlightClient(ClientObject? client)
        {
            // throw new NotImplementedException();
        }

        public void ShowClients(IEnumerable<ClientObject> clients)
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

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}