namespace DSBooking.Presentation.View
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
            packageDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            packageDataGridView.Location = new Point(0, -1);
            packageDataGridView.Name = "packageDataGridView";
            packageDataGridView.ReadOnly = true;
            packageDataGridView.Size = new Size(540, 480);
            packageDataGridView.TabIndex = 0;
            // 
            // PackageControlView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(packageDataGridView);
            Name = "PackageControlView";
            Size = new Size(540, 479);
            ((System.ComponentModel.ISupportInitialize)packageDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView packageDataGridView;
    }
}