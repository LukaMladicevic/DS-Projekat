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
using DSBooking.Presentation.View.Interface;

namespace DSBooking.Presentation.Presenter
{
    public partial class ClientControlView : UserControl, IClientControlView
    {
        public ClientControlView()
        {
            InitializeComponent();

            //clientsDataGridView.Visible = false;
        }

        public Control Control => this;

        public event EventHandler<Client>? OnClientSelection;
        public event EventHandler<string>? OnFilterChange;

        public void HighlightClient(Client? client)
        {
        }

        public void ShowClients(IEnumerable<Client> clients)
        {
            clientsDataGridView.DataSource = clients;
            clientsDataGridView.Refresh();
        }

        private void ClientControlView_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"Kliknuo si");
            OnFilterChange?.Invoke(this, ((TextBox)sender).Text);
        }
    }
}
