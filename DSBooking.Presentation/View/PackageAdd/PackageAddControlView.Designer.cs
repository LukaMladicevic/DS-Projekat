using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DSBooking.Presentation.View.PackageAdd
{
    partial class PackageAddControlView
    {
        private IContainer components = null;

        // Controls referenced in code-behind
        private Button confirmButton;
        private Button discardButton;

        private ComboBox packageTypeComboBox;

        private TextBox nameTextBox;
        private Label nameLabel;

        private TextBox priceTextBox;
        private Label priceLabel;

        private Label packageTypeLabel;

        private TextBox destinationTextBox;
        private Label destinationLabel;

        private TextBox transportTextBox;
        private Label transportLabel;

        private TextBox accommodationTextBox;
        private Label accommodationLabel;

        private TextBox guideTextBox;
        private Label guideLabel;

        private NumericUpDown lengthNumericUpDown;
        private Label lengthLabel;

        private TextBox shipTextBox;
        private Label shipLabel;

        private TextBox routeTextBox;
        private Label routeLabel;

        private DateTimePicker departureDatePicker;
        private Label departureLabel;

        private TextBox cabinTextBox;
        private Label cabinLabel;

        private TextBox additionalActivitiesTextBox;
        private Label additionalActivitiesLabel;

        /// <summary> 
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            confirmButton = new Button();
            discardButton = new Button();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            priceLabel = new Label();
            priceTextBox = new TextBox();
            packageTypeLabel = new Label();
            packageTypeComboBox = new ComboBox();
            destinationLabel = new Label();
            destinationTextBox = new TextBox();
            transportLabel = new Label();
            transportTextBox = new TextBox();
            accommodationLabel = new Label();
            accommodationTextBox = new TextBox();
            guideLabel = new Label();
            guideTextBox = new TextBox();
            lengthLabel = new Label();
            lengthNumericUpDown = new NumericUpDown();
            shipLabel = new Label();
            shipTextBox = new TextBox();
            routeLabel = new Label();
            routeTextBox = new TextBox();
            departureLabel = new Label();
            departureDatePicker = new DateTimePicker();
            cabinLabel = new Label();
            cabinTextBox = new TextBox();
            additionalActivitiesLabel = new Label();
            additionalActivitiesTextBox = new TextBox();
            ((ISupportInitialize)lengthNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // confirmButton
            // 
            confirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            confirmButton.Location = new Point(548, 462);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(100, 28);
            confirmButton.TabIndex = 26;
            confirmButton.Text = "Confirm";
            confirmButton.Click += confirmButton_Click;
            // 
            // discardButton
            // 
            discardButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            discardButton.Location = new Point(168, 462);
            discardButton.Name = "discardButton";
            discardButton.Size = new Size(100, 28);
            discardButton.TabIndex = 27;
            discardButton.Text = "Cancel";
            discardButton.Click += discardButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(12, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(150, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(170, 10);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(480, 27);
            nameTextBox.TabIndex = 1;
            // 
            // priceLabel
            // 
            priceLabel.Location = new Point(12, 42);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(150, 20);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(170, 40);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(480, 27);
            priceTextBox.TabIndex = 3;
            // 
            // packageTypeLabel
            // 
            packageTypeLabel.Location = new Point(12, 72);
            packageTypeLabel.Name = "packageTypeLabel";
            packageTypeLabel.Size = new Size(150, 20);
            packageTypeLabel.TabIndex = 4;
            packageTypeLabel.Text = "Package Type:";
            // 
            // packageTypeComboBox
            // 
            packageTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            packageTypeComboBox.Location = new Point(170, 70);
            packageTypeComboBox.Name = "packageTypeComboBox";
            packageTypeComboBox.Size = new Size(480, 28);
            packageTypeComboBox.TabIndex = 5;
            // 
            // destinationLabel
            // 
            destinationLabel.Location = new Point(12, 102);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new Size(150, 20);
            destinationLabel.TabIndex = 6;
            destinationLabel.Text = "Destination:";
            // 
            // destinationTextBox
            // 
            destinationTextBox.Location = new Point(170, 100);
            destinationTextBox.Name = "destinationTextBox";
            destinationTextBox.Size = new Size(480, 27);
            destinationTextBox.TabIndex = 7;
            // 
            // transportLabel
            // 
            transportLabel.Location = new Point(12, 132);
            transportLabel.Name = "transportLabel";
            transportLabel.Size = new Size(150, 20);
            transportLabel.TabIndex = 8;
            transportLabel.Text = "Transport Type:";
            // 
            // transportTextBox
            // 
            transportTextBox.Location = new Point(170, 130);
            transportTextBox.Name = "transportTextBox";
            transportTextBox.Size = new Size(480, 27);
            transportTextBox.TabIndex = 9;
            // 
            // accommodationLabel
            // 
            accommodationLabel.Location = new Point(12, 162);
            accommodationLabel.Name = "accommodationLabel";
            accommodationLabel.Size = new Size(150, 20);
            accommodationLabel.TabIndex = 10;
            accommodationLabel.Text = "Accommodation Type:";
            // 
            // accommodationTextBox
            // 
            accommodationTextBox.Location = new Point(170, 160);
            accommodationTextBox.Name = "accommodationTextBox";
            accommodationTextBox.Size = new Size(480, 27);
            accommodationTextBox.TabIndex = 11;
            // 
            // guideLabel
            // 
            guideLabel.Location = new Point(12, 192);
            guideLabel.Name = "guideLabel";
            guideLabel.Size = new Size(150, 20);
            guideLabel.TabIndex = 12;
            guideLabel.Text = "Guide:";
            // 
            // guideTextBox
            // 
            guideTextBox.Location = new Point(170, 190);
            guideTextBox.Name = "guideTextBox";
            guideTextBox.Size = new Size(480, 27);
            guideTextBox.TabIndex = 13;
            // 
            // lengthLabel
            // 
            lengthLabel.Location = new Point(12, 222);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(150, 20);
            lengthLabel.TabIndex = 14;
            lengthLabel.Text = "Length (days):";
            // 
            // lengthNumericUpDown
            // 
            lengthNumericUpDown.Location = new Point(170, 220);
            lengthNumericUpDown.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            lengthNumericUpDown.Name = "lengthNumericUpDown";
            lengthNumericUpDown.Size = new Size(100, 27);
            lengthNumericUpDown.TabIndex = 15;
            // 
            // shipLabel
            // 
            shipLabel.Location = new Point(12, 252);
            shipLabel.Name = "shipLabel";
            shipLabel.Size = new Size(150, 20);
            shipLabel.TabIndex = 16;
            shipLabel.Text = "Ship:";
            // 
            // shipTextBox
            // 
            shipTextBox.Location = new Point(170, 250);
            shipTextBox.Name = "shipTextBox";
            shipTextBox.Size = new Size(480, 27);
            shipTextBox.TabIndex = 17;
            // 
            // routeLabel
            // 
            routeLabel.Location = new Point(12, 282);
            routeLabel.Name = "routeLabel";
            routeLabel.Size = new Size(150, 20);
            routeLabel.TabIndex = 18;
            routeLabel.Text = "Route:";
            // 
            // routeTextBox
            // 
            routeTextBox.Location = new Point(170, 279);
            routeTextBox.Name = "routeTextBox";
            routeTextBox.Size = new Size(480, 27);
            routeTextBox.TabIndex = 19;
            // 
            // departureLabel
            // 
            departureLabel.Location = new Point(12, 312);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new Size(150, 20);
            departureLabel.TabIndex = 20;
            departureLabel.Text = "Departure Date:";
            // 
            // departureDatePicker
            // 
            departureDatePicker.Format = DateTimePickerFormat.Short;
            departureDatePicker.Location = new Point(170, 310);
            departureDatePicker.Name = "departureDatePicker";
            departureDatePicker.Size = new Size(140, 27);
            departureDatePicker.TabIndex = 21;
            // 
            // cabinLabel
            // 
            cabinLabel.Location = new Point(12, 342);
            cabinLabel.Name = "cabinLabel";
            cabinLabel.Size = new Size(150, 20);
            cabinLabel.TabIndex = 22;
            cabinLabel.Text = "Cabin Type:";
            // 
            // cabinTextBox
            // 
            cabinTextBox.Location = new Point(170, 340);
            cabinTextBox.Name = "cabinTextBox";
            cabinTextBox.Size = new Size(480, 27);
            cabinTextBox.TabIndex = 23;
            // 
            // additionalActivitiesLabel
            // 
            additionalActivitiesLabel.Location = new Point(12, 372);
            additionalActivitiesLabel.Name = "additionalActivitiesLabel";
            additionalActivitiesLabel.Size = new Size(150, 20);
            additionalActivitiesLabel.TabIndex = 24;
            additionalActivitiesLabel.Text = "Additional Activities:";
            // 
            // additionalActivitiesTextBox
            // 
            additionalActivitiesTextBox.Location = new Point(170, 370);
            additionalActivitiesTextBox.Name = "additionalActivitiesTextBox";
            additionalActivitiesTextBox.Size = new Size(480, 27);
            additionalActivitiesTextBox.TabIndex = 25;
            // 
            // PackageAddControlView
            // 
            ClientSize = new Size(700, 560);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(priceLabel);
            Controls.Add(priceTextBox);
            Controls.Add(packageTypeLabel);
            Controls.Add(packageTypeComboBox);
            Controls.Add(destinationLabel);
            Controls.Add(destinationTextBox);
            Controls.Add(transportLabel);
            Controls.Add(transportTextBox);
            Controls.Add(accommodationLabel);
            Controls.Add(accommodationTextBox);
            Controls.Add(guideLabel);
            Controls.Add(guideTextBox);
            Controls.Add(lengthLabel);
            Controls.Add(lengthNumericUpDown);
            Controls.Add(shipLabel);
            Controls.Add(shipTextBox);
            Controls.Add(routeLabel);
            Controls.Add(routeTextBox);
            Controls.Add(departureLabel);
            Controls.Add(departureDatePicker);
            Controls.Add(cabinLabel);
            Controls.Add(cabinTextBox);
            Controls.Add(additionalActivitiesLabel);
            Controls.Add(additionalActivitiesTextBox);
            Controls.Add(confirmButton);
            Controls.Add(discardButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PackageAddControlView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Package";
            Load += PackageAddControlView_Load_1;
            ((ISupportInitialize)lengthNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
