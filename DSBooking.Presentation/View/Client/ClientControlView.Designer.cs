namespace DSBooking.Presentation.View.Client
{
    partial class ClientControlView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clientsDataGridView = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            filterComboBox = new ComboBox();
            searchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.AllowUserToAddRows = false;
            clientsDataGridView.AllowUserToResizeColumns = false;
            clientsDataGridView.AllowUserToResizeRows = false;
            clientsDataGridView.BorderStyle = BorderStyle.None;
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.Dock = DockStyle.Fill;
            clientsDataGridView.Enabled = false;
            clientsDataGridView.Location = new Point(0, 0);
            clientsDataGridView.Margin = new Padding(0);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.ReadOnly = true;
            clientsDataGridView.RowHeadersWidth = 51;
            clientsDataGridView.Size = new Size(1175, 876);
            clientsDataGridView.TabIndex = 1;
            clientsDataGridView.CellContentClick += clientsDataGridView_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(filterComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(searchTextBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 776);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1175, 100);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // filterComboBox
            // 
            filterComboBox.Anchor = AnchorStyles.None;
            filterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filterComboBox.Font = new Font("Segoe UI", 14F);
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { "Ime", "Prezime", "Broj pasoša" });
            filterComboBox.Location = new Point(795, 30);
            filterComboBox.Margin = new Padding(3, 4, 3, 4);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(171, 39);
            filterComboBox.TabIndex = 1;
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.None;
            searchTextBox.Font = new Font("Segoe UI", 16F);
            searchTextBox.Location = new Point(208, 28);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(171, 43);
            searchTextBox.TabIndex = 2;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // ClientControlView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(clientsDataGridView);
            Margin = new Padding(0);
            Name = "ClientControlView";
            Size = new Size(1175, 876);
            Load += ClientControlView_Load;
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView clientsDataGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox filterComboBox;
        private TextBox searchTextBox;
    }
}
