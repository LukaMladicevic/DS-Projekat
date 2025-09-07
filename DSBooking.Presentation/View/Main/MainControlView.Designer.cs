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
            undoButton = new Button();
            redoButton = new Button();
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
            agencyNameLabel.Anchor = AnchorStyles.None;
            agencyNameLabel.AutoSize = true;
            agencyNameLabel.Font = new Font("Segoe UI", 30F);
            agencyNameLabel.Location = new Point(12, 19);
            agencyNameLabel.Name = "agencyNameLabel";
            agencyNameLabel.Size = new Size(218, 54);
            agencyNameLabel.TabIndex = 2;
            agencyNameLabel.Text = "DSBooking";
            // 
            // addClientButton
            // 
            addClientButton.Anchor = AnchorStyles.None;
            addClientButton.Font = new Font("Segoe UI", 18F);
            addClientButton.Location = new Point(863, 20);
            addClientButton.Margin = new Padding(50, 20, 50, 20);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(289, 57);
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
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1222, 93);
            topPanel.TabIndex = 3;
            // 
            // bottomLayoutPanel
            // 
            bottomLayoutPanel.ColumnCount = 4;
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            bottomLayoutPanel.Controls.Add(modeComboBox, 0, 0);
            bottomLayoutPanel.Controls.Add(addClientButton, 3, 0);
            bottomLayoutPanel.Controls.Add(undoButton, 1, 0);
            bottomLayoutPanel.Controls.Add(redoButton, 2, 0);
            bottomLayoutPanel.Dock = DockStyle.Bottom;
            bottomLayoutPanel.Location = new Point(0, 466);
            bottomLayoutPanel.Name = "bottomLayoutPanel";
            bottomLayoutPanel.RowCount = 1;
            bottomLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottomLayoutPanel.Size = new Size(1222, 97);
            bottomLayoutPanel.TabIndex = 0;
            // 
            // modeComboBox
            // 
            modeComboBox.Anchor = AnchorStyles.None;
            modeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeComboBox.Font = new Font("Segoe UI", 24F);
            modeComboBox.FormattingEnabled = true;
            modeComboBox.IntegralHeight = false;
            modeComboBox.ItemHeight = 45;
            modeComboBox.Location = new Point(108, 22);
            modeComboBox.Margin = new Padding(50, 20, 50, 20);
            modeComboBox.Name = "modeComboBox";
            modeComboBox.Size = new Size(211, 53);
            modeComboBox.TabIndex = 1;
            modeComboBox.SelectedIndexChanged += modeComboBox_SelectedIndexChanged;
            // 
            // undoButton
            // 
            undoButton.Anchor = AnchorStyles.None;
            undoButton.Font = new Font("Segoe UI", 18F);
            undoButton.Location = new Point(447, 20);
            undoButton.Margin = new Padding(20);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(143, 57);
            undoButton.TabIndex = 2;
            undoButton.Text = "Poništi";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += undoButton_Click;
            // 
            // redoButton
            // 
            redoButton.Anchor = AnchorStyles.None;
            redoButton.Font = new Font("Segoe UI", 18F);
            redoButton.Location = new Point(630, 20);
            redoButton.Margin = new Padding(20);
            redoButton.Name = "redoButton";
            redoButton.Size = new Size(143, 57);
            redoButton.TabIndex = 3;
            redoButton.Text = "Ponovi";
            redoButton.UseVisualStyleBackColor = true;
            redoButton.Click += redoButton_Click;
            // 
            // centerLayoutPanel
            // 
            centerLayoutPanel.ColumnCount = 3;
            centerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            centerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            centerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            centerLayoutPanel.Controls.Add(panel1, 1, 0);
            centerLayoutPanel.Dock = DockStyle.Fill;
            centerLayoutPanel.Location = new Point(0, 93);
            centerLayoutPanel.Name = "centerLayoutPanel";
            centerLayoutPanel.Padding = new Padding(50, 0, 50, 0);
            centerLayoutPanel.RowCount = 1;
            centerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            centerLayoutPanel.Size = new Size(1222, 373);
            centerLayoutPanel.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Location = new Point(557, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(106, 367);
            panel1.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // DatabaseBackupTimer
            // 
            DatabaseBackupTimer.Tick += DatabaseBackupTimer_Tick;
            // 
            // MainControlView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 563);
            Controls.Add(centerLayoutPanel);
            Controls.Add(topPanel);
            Controls.Add(bottomLayoutPanel);
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
        private Button undoButton;
        private Button redoButton;
        private System.Windows.Forms.Timer DatabaseBackupTimer;
    }
}