namespace DSBooking.Presentation.View.Implementation
{
    partial class MainView
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
            mainSplitContainer = new SplitContainer();
            actionComboBox = new ComboBox();
            agencyNameLabel = new Label();
            addClientButton = new Button();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Location = new Point(68, 77);
            mainSplitContainer.Name = "mainSplitContainer";
            mainSplitContainer.Size = new Size(1080, 386);
            mainSplitContainer.SplitterDistance = 438;
            mainSplitContainer.SplitterWidth = 200;
            mainSplitContainer.TabIndex = 0;
            // 
            // actionComboBox
            // 
            actionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            actionComboBox.Font = new Font("Segoe UI", 22F);
            actionComboBox.FormattingEnabled = true;
            actionComboBox.ItemHeight = 40;
            actionComboBox.Items.AddRange(new object[] { "Rezervisi", "Ukloni Rezervaciju" });
            actionComboBox.Location = new Point(482, 503);
            actionComboBox.Name = "actionComboBox";
            actionComboBox.Size = new Size(250, 48);
            actionComboBox.TabIndex = 1;
            actionComboBox.SelectedIndexChanged += actionComboBox_SelectedIndexChanged;
            // 
            // agencyNameLabel
            // 
            agencyNameLabel.AutoSize = true;
            agencyNameLabel.Font = new Font("Segoe UI", 30F);
            agencyNameLabel.Location = new Point(12, 9);
            agencyNameLabel.Name = "agencyNameLabel";
            agencyNameLabel.Size = new Size(218, 54);
            agencyNameLabel.TabIndex = 2;
            agencyNameLabel.Text = "DSBooking";
            // 
            // addClientButton
            // 
            addClientButton.Font = new Font("Segoe UI", 16F);
            addClientButton.Location = new Point(960, 12);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(250, 48);
            addClientButton.TabIndex = 0;
            addClientButton.Text = "Dodaj klijenta...";
            addClientButton.UseVisualStyleBackColor = true;
            addClientButton.Click += addClientButton_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 563);
            Controls.Add(addClientButton);
            Controls.Add(agencyNameLabel);
            Controls.Add(actionComboBox);
            Controls.Add(mainSplitContainer);
            Name = "MainView";
            Text = "MainView";
            Load += MainView_Load;
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer mainSplitContainer;
        private ComboBox actionComboBox;
        private Label agencyNameLabel;
        private Button addClientButton;
    }
}