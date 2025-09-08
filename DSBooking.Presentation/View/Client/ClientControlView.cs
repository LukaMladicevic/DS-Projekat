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
        private readonly BindingSource _bindingSource = new BindingSource();
        public ClientControlView()
        {

            InitializeComponent();
            clientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsDataGridView.MultiSelect = false;
            clientsDataGridView.ReadOnly = true; // optional, prevents editing
            clientsDataGridView.RowHeadersVisible = false; // optional, hide headers
            clientsDataGridView.AutoGenerateColumns = true;
            clientsDataGridView.DataSource = _bindingSource;


            //clientsDataGridView.CellClick += clientsDataGridView_CellClick;
            //clientsDataGridView.SelectionChanged += ClientsDataGridView_SelectionChanged;
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

        public event EventHandler<string>? OnFilterStringChange;

        public void HighlightClient(ClientObject? client)
        {
            // throw new NotImplementedException();
        }

        public void ShowClients(IEnumerable<ClientObject> clients)
        {
            //clientsDataGridView.DataSource = clients;
            //clientsDataGridView.Refresh();
            _bindingSource.DataSource = clients?.ToList();
            clientsDataGridView.Refresh();
        }

        private void ClientsDataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            // CurrentRow is null when no rows are present
            MessageBox.Show("Cell cliecked"); ;
            var row = clientsDataGridView.CurrentRow;
            if (row == null) return;

            var client = row.DataBoundItem as ClientObject;
            if (client != null)
            {
                // optional debug:
                // MessageBox.Show($"Selected client: {client.FirstName} {client.LastName}");
                OnClientSelection?.Invoke(this, client);
            }
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

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            OnFilterStringChange?.Invoke(this, searchTextBox.Text);
        }

        private void clientsDataGridView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Cell cliecked"); ;

            if (e.RowIndex >= 0 && e.RowIndex < clientsDataGridView.Rows.Count)
            {
                // Get the ClientObject bound to this row
                var client = clientsDataGridView.Rows[e.RowIndex].DataBoundItem as ClientObject;
                if (client != null)
                {
                    OnClientSelection?.Invoke(this, client);
                    HighlightClient(client); // optional: highlight in the grid
                }
            }
        }
    }
}