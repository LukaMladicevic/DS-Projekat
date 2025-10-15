namespace DSBooking.Presentation.View.Main
{
    partial class MainControlView
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
            components = new System.ComponentModel.Container();
            agencyNameLabel = new Label();
            addClientButton = new Button();
            topPanel = new Panel();
            bottomLayoutPanel = new TableLayoutPanel();
            modeComboBox = new ComboBox();
            showToggleButton = new Button();
            centerLayoutPanel = new TableLayoutPanel();
            panel1 = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            DatabaseBackupTimer = new System.Windows.Forms.Timer(components);
            topPanel.SuspendLayout();
            bottomLayoutPanel.SuspendLayout();
            centerLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // agencyNameLabel
            // 
            agencyNameLabel.AutoSize = true;
            agencyNameLabel.Font = new Font("Segoe UI", 30F);
            agencyNameLabel.Location = new Point(14, 25);
            agencyNameLabel.Name = "agencyNameLabel";
            agencyNameLabel.Size = new Size(272, 67);
            agencyNameLabel.TabIndex = 2;
            agencyNameLabel.Text = "DSBooking";
            // 
            // addClientButton
            // 
            addClientButton.Anchor = AnchorStyles.None;
            addClientButton.Font = new Font("Segoe UI", 18F);
            addClientButton.Location = new Point(987, 27);
            addClientButton.Margin = new Padding(57, 27, 57, 27);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(330, 75);
            addClientButton.TabIndex = 0;
            addClientButton.Text = "Dodaj klijenta...";
            addClientButton.UseVisualStyleBackColor = true;
            addClientButton.Click += addClientButton_Click;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(agencyNameLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1397, 124);
            topPanel.TabIndex = 3;
            topPanel.Paint += topPanel_Paint;
            // 
            // bottomLayoutPanel
            // 
            bottomLayoutPanel.ColumnCount = 3;
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            bottomLayoutPanel.Controls.Add(modeComboBox, 0, 0);
            bottomLayoutPanel.Controls.Add(showToggleButton, 1, 0);
            bottomLayoutPanel.Controls.Add(addClientButton, 2, 0);
            bottomLayoutPanel.Dock = DockStyle.Bottom;
            bottomLayoutPanel.Location = new Point(0, 622);
            bottomLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            bottomLayoutPanel.Name = "bottomLayoutPanel";
            bottomLayoutPanel.RowCount = 1;
            bottomLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottomLayoutPanel.Size = new Size(1397, 129);
            bottomLayoutPanel.TabIndex = 0;
            // 
            // modeComboBox
            // 
            modeComboBox.Anchor = AnchorStyles.None;
            modeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeComboBox.Font = new Font("Segoe UI", 24F);
            modeComboBox.FormattingEnabled = true;
            modeComboBox.IntegralHeight = false;
            modeComboBox.ItemHeight = 54;
            modeComboBox.Location = new Point(123, 33);
            modeComboBox.Margin = new Padding(57, 27, 57, 27);
            modeComboBox.Name = "modeComboBox";
            modeComboBox.Size = new Size(241, 62);
            modeComboBox.TabIndex = 1;
            modeComboBox.SelectedIndexChanged += modeComboBox_SelectedIndexChanged;
            // 
            // showToggleButton
            // 
            showToggleButton.Anchor = AnchorStyles.None;
            showToggleButton.Font = new Font("Segoe UI", 14F);
            showToggleButton.Location = new Point(587, 40);
            showToggleButton.Name = "showToggleButton";
            showToggleButton.Size = new Size(220, 48);
            showToggleButton.TabIndex = 2;
            showToggleButton.Text = "Show Reservations";
            showToggleButton.UseVisualStyleBackColor = true;
            showToggleButton.Click += showToggleButton_Click;
            // 
            // centerLayoutPanel
            // 
            centerLayoutPanel.ColumnCount = 3;
            centerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            centerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            centerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            centerLayoutPanel.Controls.Add(panel1, 1, 0);
            centerLayoutPanel.Dock = DockStyle.Fill;
            centerLayoutPanel.Location = new Point(0, 124);
            centerLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            centerLayoutPanel.Name = "centerLayoutPanel";
            centerLayoutPanel.Padding = new Padding(57, 0, 57, 0);
            centerLayoutPanel.RowCount = 1;
            centerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            centerLayoutPanel.Size = new Size(1397, 498);
            centerLayoutPanel.TabIndex = 4;
            centerLayoutPanel.Paint += centerLayoutPanel_Paint;
            // 
            // panel1
            // 
            panel1.Location = new Point(637, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 489);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // MainControlView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 751);
            Controls.Add(centerLayoutPanel);
            Controls.Add(topPanel);
            Controls.Add(bottomLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainControlView";
            Text = "MainView";
            Load += MainView_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            bottomLayoutPanel.ResumeLayout(false);
            centerLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label agencyNameLabel;
        private Button addClientButton;
        private Panel topPanel;
        private TableLayoutPanel bottomLayoutPanel;
        private TableLayoutPanel centerLayoutPanel;
        private Panel panel1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox modeComboBox;
        private System.Windows.Forms.Timer DatabaseBackupTimer;

        // NEW: toggle button field
        private Button showToggleButton;
    }
}
