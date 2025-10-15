namespace DSBooking.Presentation.View.ClientAdd
{
    partial class ClientAddControlView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientAddControlView));
            tableLayoutPanel2 = new TableLayoutPanel();
            discardButton = new Button();
            confirmButton = new Button();
            inputLayoutPanel = new TableLayoutPanel();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            passportNoTextBox = new TextBox();
            emailAddressTextBox = new TextBox();
            phoneNoTextBox = new TextBox();
            firstNameLabel = new Label();
            passportNoLabel = new Label();
            lastNameLabel = new Label();
            dateOfBirthLabel = new Label();
            emailAddressLabel = new Label();
            phoneNoLabel = new Label();
            dateOfBirthPicker = new DateTimePicker();
            tableLayoutPanel2.SuspendLayout();
            inputLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(discardButton, 0, 0);
            tableLayoutPanel2.Controls.Add(confirmButton, 1, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // discardButton
            // 
            resources.ApplyResources(discardButton, "discardButton");
            discardButton.Name = "discardButton";
            discardButton.UseVisualStyleBackColor = true;
            discardButton.Click += discardButton_Click;
            // 
            // confirmButton
            // 
            resources.ApplyResources(confirmButton, "confirmButton");
            confirmButton.Name = "confirmButton";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // inputLayoutPanel
            // 
            resources.ApplyResources(inputLayoutPanel, "inputLayoutPanel");
            inputLayoutPanel.Controls.Add(firstNameTextBox, 1, 0);
            inputLayoutPanel.Controls.Add(lastNameTextBox, 1, 1);
            inputLayoutPanel.Controls.Add(passportNoTextBox, 1, 2);
            inputLayoutPanel.Controls.Add(emailAddressTextBox, 1, 4);
            inputLayoutPanel.Controls.Add(phoneNoTextBox, 1, 5);
            inputLayoutPanel.Controls.Add(firstNameLabel, 0, 0);
            inputLayoutPanel.Controls.Add(passportNoLabel, 0, 2);
            inputLayoutPanel.Controls.Add(lastNameLabel, 0, 1);
            inputLayoutPanel.Controls.Add(dateOfBirthLabel, 0, 3);
            inputLayoutPanel.Controls.Add(emailAddressLabel, 0, 4);
            inputLayoutPanel.Controls.Add(phoneNoLabel, 0, 5);
            inputLayoutPanel.Controls.Add(dateOfBirthPicker, 1, 3);
            inputLayoutPanel.Name = "inputLayoutPanel";
            inputLayoutPanel.Paint += inputLayoutPanel_Paint;
            // 
            // firstNameTextBox
            // 
            resources.ApplyResources(firstNameTextBox, "firstNameTextBox");
            firstNameTextBox.Name = "firstNameTextBox";
            // 
            // lastNameTextBox
            // 
            resources.ApplyResources(lastNameTextBox, "lastNameTextBox");
            lastNameTextBox.Name = "lastNameTextBox";
            // 
            // passportNoTextBox
            // 
            resources.ApplyResources(passportNoTextBox, "passportNoTextBox");
            passportNoTextBox.Name = "passportNoTextBox";
            // 
            // emailAddressTextBox
            // 
            resources.ApplyResources(emailAddressTextBox, "emailAddressTextBox");
            emailAddressTextBox.Name = "emailAddressTextBox";
            // 
            // phoneNoTextBox
            // 
            resources.ApplyResources(phoneNoTextBox, "phoneNoTextBox");
            phoneNoTextBox.Name = "phoneNoTextBox";
            // 
            // firstNameLabel
            // 
            resources.ApplyResources(firstNameLabel, "firstNameLabel");
            firstNameLabel.Name = "firstNameLabel";
            // 
            // passportNoLabel
            // 
            resources.ApplyResources(passportNoLabel, "passportNoLabel");
            passportNoLabel.Name = "passportNoLabel";
            // 
            // lastNameLabel
            // 
            resources.ApplyResources(lastNameLabel, "lastNameLabel");
            lastNameLabel.Name = "lastNameLabel";
            // 
            // dateOfBirthLabel
            // 
            resources.ApplyResources(dateOfBirthLabel, "dateOfBirthLabel");
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            // 
            // emailAddressLabel
            // 
            resources.ApplyResources(emailAddressLabel, "emailAddressLabel");
            emailAddressLabel.Name = "emailAddressLabel";
            // 
            // phoneNoLabel
            // 
            resources.ApplyResources(phoneNoLabel, "phoneNoLabel");
            phoneNoLabel.Name = "phoneNoLabel";
            // 
            // dateOfBirthPicker
            // 
            resources.ApplyResources(dateOfBirthPicker, "dateOfBirthPicker");
            dateOfBirthPicker.Format = DateTimePickerFormat.Custom;
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.ShowUpDown = true;
            // 
            // ClientAddControlView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(inputLayoutPanel);
            Controls.Add(tableLayoutPanel2);
            Name = "ClientAddControlView";
            Load += ClientAddControlView_Load;
            tableLayoutPanel2.ResumeLayout(false);
            inputLayoutPanel.ResumeLayout(false);
            inputLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel inputLayoutPanel;
        private DateTimePicker dateOfBirthPicker;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailAddressTextBox;
        private TextBox phoneNoTextBox;
        private Button discardButton;
        private Button confirmButton;
        private TextBox passportNoTextBox;
        private Label firstNameLabel;
        private Label passportNoLabel;
        private Label lastNameLabel;
        private Label dateOfBirthLabel;
        private Label emailAddressLabel;
        private Label phoneNoLabel;
    }
}