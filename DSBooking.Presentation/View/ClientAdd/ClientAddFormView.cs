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
    public partial class ClientAddControlView : Form, IClientAddControlView
    {
        public ClientAddControlView()
        {
            InitializeComponent();

            this.AcceptButton = confirmButton;
            this.CancelButton = discardButton;
        }

        public string FirstName => firstNameTextBox.Text;

        public string LastName => lastNameTextBox.Text;

        public string PassportNo => passportNoTextBox.Text;

        public DateTime DateOfBirth => dateOfBirthPicker.Value;

        public string Email => emailAddressTextBox.Text;

        public string PhoneNo => phoneNoTextBox.Text;

        public Control Control => this;

        public event EventHandler<ClientAddObject>? ClientAddSubmitted;
        public event EventHandler? ClientAddCancelled;

        public void MarkDateOfBirth(ClientAddViewMarkOption markOption)
        {
            if (markOption == ClientAddViewMarkOption.Incorrect)
                dateOfBirthLabel.ForeColor = Color.Red;
            else
                dateOfBirthLabel.ForeColor = Color.Black;
        }

        public void MarkEmail(ClientAddViewMarkOption markOption)
        {
            if (markOption == ClientAddViewMarkOption.Incorrect)
                emailAddressLabel.ForeColor = Color.Red;
            else
                emailAddressLabel.ForeColor = Color.Black;
        }

        public void MarkFirstName(ClientAddViewMarkOption markOption)
        {
            if (markOption == ClientAddViewMarkOption.Incorrect)
                firstNameLabel.ForeColor = Color.Red;
            else
                firstNameLabel.ForeColor = Color.Black;
        }

        public void MarkLastName(ClientAddViewMarkOption markOption)
        {
            if (markOption == ClientAddViewMarkOption.Incorrect)
                lastNameLabel.ForeColor = Color.Red;
            else
                lastNameLabel.ForeColor = Color.Black;
        }

        public void MarkPassportNo(ClientAddViewMarkOption markOption)
        {
            if (markOption == ClientAddViewMarkOption.Incorrect)
                passportNoLabel.ForeColor = Color.Red;
            else
                passportNoLabel.ForeColor = Color.Black;
        }

        public void MarkPhoneNo(ClientAddViewMarkOption markOption)
        {
            if (markOption == ClientAddViewMarkOption.Incorrect)
                phoneNoLabel.ForeColor = Color.Red;
            else
                phoneNoLabel.ForeColor = Color.Black;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            ClientAddObject newClient = new ClientAddObject(FirstName, LastName, PassportNo, DateOfBirth, Email, PhoneNo);
            ClientAddSubmitted?.Invoke(this, newClient);
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            ClientAddCancelled?.Invoke(this, EventArgs.Empty);
        }

        private void ClientAddControlView_Load(object sender, EventArgs e)
        {

        }

        private void inputLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
