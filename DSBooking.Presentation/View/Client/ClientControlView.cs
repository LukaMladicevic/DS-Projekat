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
        private int? _highlightedClientId = null;
        private bool _suppressSelectionEvents = false;
        public ClientControlView()
        {
            InitializeComponent();

            clientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsDataGridView.MultiSelect = false;
            clientsDataGridView.ReadOnly = true; 
            clientsDataGridView.RowHeadersVisible = false;
            clientsDataGridView.AutoGenerateColumns = false;
            clientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientsDataGridView.DataSource = _bindingSource;

            selectedClientLabel = new System.Windows.Forms.Label();
            selectedClientLabel.AutoSize = true;
            selectedClientLabel.Location = new System.Drawing.Point(8, 8);
            selectedClientLabel.Name = "selectedClientLabel";
            selectedClientLabel.Size = new System.Drawing.Size(200, 20);
            selectedClientLabel.TabIndex = 999;
            selectedClientLabel.Text = "Selected client: none";
            this.Controls.Add(selectedClientLabel);


            clientsDataGridView.AllowUserToAddRows = false;    
            clientsDataGridView.Enabled = true;              
            clientsDataGridView.BringToFront();               

            clientsDataGridView.Columns.Clear();

            clientsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FirstName",
                HeaderText = "First name",
                DataPropertyName = "FirstName",
                ReadOnly = true
            });

            clientsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LastName",
                HeaderText = "Last name",
                DataPropertyName = "LastName",
                ReadOnly = true
            });

            clientsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email address",
                DataPropertyName = "Email",
                ReadOnly = true
            });

            clientsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PhoneNo",
                HeaderText = "Phone number",
                DataPropertyName = "PhoneNo",
                ReadOnly = true
            });

            clientsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DOB",
                HeaderText = "Date of birth",
                DataPropertyName = "DateOfBirth",
                ReadOnly = true
            });

            var detailsCol = new DataGridViewButtonColumn
            {
                Name = "DetailsButton",
                HeaderText = "",
                Text = "Show",
                UseColumnTextForButtonValue = true,
                ReadOnly = false,
                Width = 80
            };
            clientsDataGridView.Columns.Add(detailsCol);

            clientsDataGridView.ScrollBars = ScrollBars.None;
            clientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            clientsDataGridView.CellContentClick += ClientsDataGridView_CellContentClick;
            clientsDataGridView.CellClick += clientsDataGridView_CellClick;
            clientsDataGridView.CellMouseDown += ClientsDataGridView_CellMouseDown; 
            clientsDataGridView.SelectionChanged += ClientsDataGridView_SelectionChanged;
            clientsDataGridView.DataBindingComplete += ClientsDataGridView_DataBindingComplete;

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

        public event EventHandler<ClientObject>? OnDetailsButtonClicked;

        public void HighlightClient(ClientObject? client)
        {
            _highlightedClientId = client?.Id;

            _suppressSelectionEvents = true;
            try
            {
                for (int r = 0; r < clientsDataGridView.Rows.Count; r++)
                {
                    var row = clientsDataGridView.Rows[r];
                    row.DefaultCellStyle.BackColor = Color.Empty;
                    row.DefaultCellStyle.ForeColor = Color.Empty;
                    row.Selected = false;
                }

                if (client == null) return;

                for (int i = 0; i < clientsDataGridView.Rows.Count; i++)
                {
                    var row = clientsDataGridView.Rows[i];
                    var c = row.DataBoundItem as ClientObject;
                    if (c != null && c.Id == client.Id)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSkyBlue; 
                        row.Selected = true;
                        try { clientsDataGridView.FirstDisplayedScrollingRowIndex = i; } catch { }
                        break;
                    }
                }
            }
            finally
            {
                _suppressSelectionEvents = false;
            }
        }

        public void ShowClients(IEnumerable<ClientObject> clients)
        {
            _bindingSource.DataSource = clients?.ToList();
            clientsDataGridView.Refresh();
        }

        private void ClientsDataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            //var client = row.DataBoundItem as ClientObject;
            //if (client != null)
            //{
            //    OnClientSelection?.Invoke(this, client);
            //}

            if (_suppressSelectionEvents) return;

            var row = clientsDataGridView.CurrentRow;
            if (row == null) return;

            var client = row.DataBoundItem as ClientObject;
            if (client != null)
            {
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var grid = (DataGridView)sender!;
            var column = grid.Columns[e.ColumnIndex];
            if (column != null && column.Name == "DetailsButton")
            {
                var client = grid.Rows[e.RowIndex].DataBoundItem as ClientObject;
                if (client != null)
                {
                    OnDetailsButtonClicked?.Invoke(this, client);
                    OnClientSelection?.Invoke(this, client);
                }
            }
        }

        public void SetSelectedClientLabel(string text)
        {
            if (selectedClientLabel == null) return;
            selectedClientLabel.Text = string.IsNullOrWhiteSpace(text) ? "Selected client: none" : $"Selected client: {text}";
        }

        private void ClientsDataGridView_CellMouseDown(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (e.Button != MouseButtons.Left) return;

            clientsDataGridView.CurrentCell = clientsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            clientsDataGridView.Rows[e.RowIndex].Selected = true;
            clientsDataGridView.Focus();
        }

        private void ClientsDataGridView_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            clientsDataGridView.ClearSelection();

            if (!_highlightedClientId.HasValue) return;

            _suppressSelectionEvents = true;
            try
            {
                for (int i = 0; i < clientsDataGridView.Rows.Count; i++)
                {
                    var row = clientsDataGridView.Rows[i];
                    var c = row.DataBoundItem as ClientObject;
                    if (c != null && c.Id == _highlightedClientId.Value)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                        row.Selected = true;
                        try { clientsDataGridView.FirstDisplayedScrollingRowIndex = i; } catch { }
                        break;
                    }
                }
            }
            finally
            {
                _suppressSelectionEvents = false;
            }
        }

        private void ClientsDataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var grid = (DataGridView)sender!;
            var colName = grid.Columns[e.ColumnIndex].Name;

            if (colName == "DetailsButton")
            {
                var client = grid.Rows[e.RowIndex].DataBoundItem as ClientObject;
                if (client != null)
                {
                    MessageBox.Show($"Button clicked for: {client.FirstName} {client.LastName}");
                    OnClientSelection?.Invoke(this, client);
                    OnDetailsButtonClicked?.Invoke(this, client);
                }
            }
        }
    }



}