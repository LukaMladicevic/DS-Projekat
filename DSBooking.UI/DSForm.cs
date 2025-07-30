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
using DSBooking.Domain.Entity;

namespace DSBooking.UI
{
    public partial class DSForm : Form
    {
        private IClientRepository _clientRepository;
        public DSForm(IClientRepository _clientRepository)
        {
            this._clientRepository = _clientRepository;
            InitializeComponent();
        }

        private void DSForm_Load(object sender, EventArgs e)
        {

        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            _clientRepository.AddClient(new Client());
        }
    }
}
