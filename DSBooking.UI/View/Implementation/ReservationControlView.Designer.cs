namespace DSBooking.Presentation.View
{
    partial class ReservationControlView
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
            reservationsGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)reservationsGridView).BeginInit();
            SuspendLayout();
            // 
            // reservationsGridView
            // 
            reservationsGridView.AllowUserToAddRows = false;
            reservationsGridView.AllowUserToDeleteRows = false;
            reservationsGridView.AllowUserToResizeColumns = false;
            reservationsGridView.AllowUserToResizeRows = false;
            reservationsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservationsGridView.Enabled = false;
            reservationsGridView.Location = new Point(0, 0);
            reservationsGridView.Margin = new Padding(3, 4, 3, 4);
            reservationsGridView.MultiSelect = false;
            reservationsGridView.Name = "reservationsGridView";
            reservationsGridView.RowHeadersWidth = 51;
            reservationsGridView.Size = new Size(122, 159);
            reservationsGridView.TabIndex = 0;
            // 
            // ReservationControlView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(reservationsGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReservationControlView";
            Size = new Size(405, 615);
            Load += ReservationControlView_Load;
            ((System.ComponentModel.ISupportInitialize)reservationsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView reservationsGridView;
    }
}
