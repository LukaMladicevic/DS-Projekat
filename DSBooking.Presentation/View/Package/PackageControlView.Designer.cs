namespace DSBooking.Presentation.View.Package
{
    partial class PackageControlView
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
            packageDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)packageDataGridView).BeginInit();
            SuspendLayout();
            // 
            // packageDataGridView
            // 
            packageDataGridView.AllowUserToAddRows = false;
            packageDataGridView.AllowUserToDeleteRows = false;
            packageDataGridView.BorderStyle = BorderStyle.None;
            packageDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            packageDataGridView.Dock = DockStyle.Fill;
            packageDataGridView.Location = new Point(0, 0);
            packageDataGridView.Margin = new Padding(0);
            packageDataGridView.Name = "packageDataGridView";
            packageDataGridView.ReadOnly = true;
            packageDataGridView.RowHeadersWidth = 51;
            packageDataGridView.Size = new Size(1200, 915);
            packageDataGridView.TabIndex = 0;
            packageDataGridView.CellContentClick += packageDataGridView_CellContentClick_1;
            // 
            // PackageControlView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(packageDataGridView);
            Margin = new Padding(0);
            Name = "PackageControlView";
            Size = new Size(1200, 915);
            Load += PackageControlView_Load;
            ((System.ComponentModel.ISupportInitialize)packageDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView packageDataGridView;
        private TableLayoutPanel actionPanel;
        private Button undoButton;
        private Button redoButton;
    }
}