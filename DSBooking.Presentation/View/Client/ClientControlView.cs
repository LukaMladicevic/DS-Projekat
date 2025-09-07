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
using DSBooking.Presentation.View.Main;

namespace DSBooking.Presentation.View.Client
{
    public partial class ClientControlView : UserControl, IClientControlView
    {
        public ClientControlView()
        {
            InitializeComponent();

            clientsDataGridView.ScrollBars = ScrollBars.None;
            clientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            filterComboBox.DataSource = new[]
{
                new KeyValuePair<ClientViewFilterMode, string>(ClientViewFilterMode.FilterFirstName, "Ime"),
                new KeyValuePair<ClientViewFilterMode, string>(ClientViewFilterMode.FilterLastName, "Prezime"),
                new KeyValuePair<ClientViewFilterMode, string>(ClientViewFilterMode.FilterPassportNo, "Broj pasoša"),
            };
            filterComboBox.DisplayMember = "Value";
            filterComboBox.ValueMember = "Key";
            filterComboBox.SelectedIndex = 0;
        }

        public Control Control => this;

        public event EventHandler<ClientObject>? OnClientSelection;
        public event EventHandler? OnViewLoad;
        public event EventHandler<ClientViewFilterMode>? OnFilterModeChange;

        public event EventHandler<string>? OnFilterChange;

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

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterComboBox.SelectedValue is ClientViewFilterMode mode)
            {
                OnFilterModeChange?.Invoke(this, mode);
            }
        }
    }
}