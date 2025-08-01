namespace DSBooking.Presentation.Presenter
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
            searchTextBox = new TextBox();
            clientsDataGridView = new DataGridView();
            comboBox1 = new ComboBox();
            addClientButton = new Button();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(14, 17);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(100, 23);
            searchTextBox.TabIndex = 0;
            searchTextBox.Text = "Search...";
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.Location = new Point(0, 64);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.Size = new Size(502, 474);
            clientsDataGridView.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "emilija", "novak" });
            comboBox1.Location = new Point(120, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // addClientButton
            // 
            addClientButton.Location = new Point(301, 17);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(75, 23);
            addClientButton.TabIndex = 3;
            addClientButton.Text = "Add Client";
            addClientButton.UseVisualStyleBackColor = true;
            // 
            // ClientViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addClientButton);
            Controls.Add(comboBox1);
            Controls.Add(clientsDataGridView);
            Controls.Add(searchTextBox);
            Name = "ClientViewControl";
            Size = new Size(418, 438);
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private DataGridView clientsDataGridView;
        private ComboBox comboBox1;
        private Button addClientButton;
    }
}
