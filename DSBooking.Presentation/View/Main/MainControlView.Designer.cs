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
            agencyNameLabel = new Label();
            addClientButton = new Button();
            topPanel = new Panel();
            bottomLayoutPanel = new TableLayoutPanel();
            actionButton = new Button();
            centerLayoutPanel = new TableLayoutPanel();
            panel1 = new Panel();
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
            agencyNameLabel.Location = new Point(507, 22);
            agencyNameLabel.Name = "agencyNameLabel";
            agencyNameLabel.Size = new Size(218, 54);
            agencyNameLabel.TabIndex = 2;
            agencyNameLabel.Text = "DSBooking";
            // 
            // addClientButton
            // 
            addClientButton.Anchor = AnchorStyles.Right;
            addClientButton.Font = new Font("Segoe UI", 16F);
            addClientButton.Location = new Point(919, 24);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(250, 48);
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
            bottomLayoutPanel.ColumnCount = 2;
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bottomLayoutPanel.Controls.Add(addClientButton, 1, 0);
            bottomLayoutPanel.Controls.Add(actionButton, 0, 0);
            bottomLayoutPanel.Dock = DockStyle.Bottom;
            bottomLayoutPanel.Location = new Point(0, 466);
            bottomLayoutPanel.Name = "bottomLayoutPanel";
            bottomLayoutPanel.Padding = new Padding(50, 0, 50, 0);
            bottomLayoutPanel.RowCount = 1;
            bottomLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bottomLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bottomLayoutPanel.Size = new Size(1222, 97);
            bottomLayoutPanel.TabIndex = 0;
            // 
            // actionButton
            // 
            actionButton.Anchor = AnchorStyles.Left;
            actionButton.Font = new Font("Segoe UI", 16F);
            actionButton.Location = new Point(53, 24);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(250, 48);
            actionButton.TabIndex = 1;
            actionButton.Text = "Rezervisanje";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
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
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 563);
            Controls.Add(centerLayoutPanel);
            Controls.Add(topPanel);
            Controls.Add(bottomLayoutPanel);
            Name = "MainView";
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
        private Button actionButton;
    }
}