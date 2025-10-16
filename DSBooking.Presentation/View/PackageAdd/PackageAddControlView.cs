using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DSBooking.Presentation.View.PackageAdd
{
    public partial class PackageAddControlView : Form, IPackageAddControlView
    {
        public PackageAddControlView()
        {
            InitializeComponent();

            this.AcceptButton = confirmButton;
            this.CancelButton = discardButton;

            this.Text = "Add Package";

            try
            {
                packageTypeComboBox.Items.Clear();
                packageTypeComboBox.Items.AddRange(new object[] { "Seaside", "Mountain", "Travel", "Cruise" });
                packageTypeComboBox.SelectedIndex = 0;
            }
            catch {}
        }

        private void PackageAddControlView_Load(object sender, EventArgs e)
        {
        }

        public string PackageName => nameTextBox.Text;
        string IPackageAddView.Name => nameTextBox.Text;
        //public string Name => nameTextBox.Text;
        public double Price => double.TryParse(priceTextBox.Text, out var v) ? v : 0.0;
        public string PackageTypeName => packageTypeComboBox.SelectedItem?.ToString() ?? string.Empty;

        public string DestinationName => destinationTextBox.Text;
        public string TransportTypeName => transportTextBox.Text;
        public string AccommodationTypeName => accommodationTextBox.Text;

        public string GuideName => guideTextBox.Text;
        public int LengthInDays => (int)lengthNumericUpDown.Value;

        public string ShipName => shipTextBox.Text;
        public string RouteName => routeTextBox.Text;
        public DateTime DepartureDate => departureDatePicker.Value;
        public string CabinTypeName => cabinTextBox.Text;

        public string AdditionalActivities => additionalActivitiesTextBox.Text;

        public Control Control => this;

        public event EventHandler? PackageAddSubmitted;
        public event EventHandler? PackageAddCancelled;

        public void MarkName(PackageAddViewMarkOption option) => MarkLabel(nameLabel, option);
        public void MarkPrice(PackageAddViewMarkOption option) => MarkLabel(priceLabel, option);
        public void MarkPackageType(PackageAddViewMarkOption option) => MarkLabel(packageTypeLabel, option);

        public void MarkDestination(PackageAddViewMarkOption option) => MarkLabel(destinationLabel, option);
        public void MarkTransportType(PackageAddViewMarkOption option) => MarkLabel(transportLabel, option);
        public void MarkAccommodationType(PackageAddViewMarkOption option) => MarkLabel(accommodationLabel, option);

        public void MarkGuide(PackageAddViewMarkOption option) => MarkLabel(guideLabel, option);
        public void MarkLengthInDays(PackageAddViewMarkOption option) => MarkLabel(lengthLabel, option);

        public void MarkShip(PackageAddViewMarkOption option) => MarkLabel(shipLabel, option);
        public void MarkRoute(PackageAddViewMarkOption option) => MarkLabel(routeLabel, option);
        public void MarkDepartureDate(PackageAddViewMarkOption option) => MarkLabel(departureLabel, option);
        public void MarkCabinType(PackageAddViewMarkOption option) => MarkLabel(cabinLabel, option);

        public void MarkAdditionalActivities(PackageAddViewMarkOption option) => MarkLabel(additionalActivitiesLabel, option);

        private void MarkLabel(Label lbl, PackageAddViewMarkOption option)
        {
            if (lbl == null) return;
            lbl.ForeColor = option == PackageAddViewMarkOption.Incorrect ? Color.Red : Color.Black;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            PackageAddSubmitted?.Invoke(this, EventArgs.Empty);
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            PackageAddCancelled?.Invoke(this, EventArgs.Empty);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void PackageAddControlView_Load_1(object sender, EventArgs e)
        {

        }
    }
}
