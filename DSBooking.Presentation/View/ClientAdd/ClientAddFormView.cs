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

namespace DSBooking.Presentation.View.ClientAdd
{
    public partial class ClientAddFormView : Form, IClientAddFormView
    {
        public ClientAddFormView()
        {
            InitializeComponent();

            confirmButton.DialogResult = DialogResult.OK;
            discardButton.DialogResult = DialogResult.Cancel;

            this.AcceptButton = confirmButton;
            this.CancelButton = discardButton;
        }

        public string FirstName => firstNameTextBox.Text;

        public string LastName => lastNameTextBox.Text;

        public string PassportNo => passportNoTextBox.Text;

        public DateTime DateOfBirth => dateOfBirthPicker.Value;

        public string Email => emailAddressTextBox.Text;

        public string PhoneNo => phoneNoTextBox.Text;

        public Form Form => this;

        public event EventHandler<ClientAddObject>? ClientAddSubmitted;

        private void confirmButton_Click(object sender, EventArgs e)
        {
            ClientAddObject newClient = new ClientAddObject(FirstName, LastName, PassportNo, DateOfBirth, Email, PhoneNo);
            ClientAddSubmitted?.Invoke(this, newClient);
        }
    }
}
