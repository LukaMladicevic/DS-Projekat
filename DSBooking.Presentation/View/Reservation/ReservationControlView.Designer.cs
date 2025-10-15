namespace DSBooking.Presentation.View.Reservation
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
            reservationsGridView.BorderStyle = BorderStyle.None;
            reservationsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservationsGridView.Dock = DockStyle.Fill;
            reservationsGridView.Enabled = false;
            reservationsGridView.Location = new Point(0, 0);
            reservationsGridView.Margin = new Padding(0);
            reservationsGridView.MultiSelect = false;
            reservationsGridView.Name = "reservationsGridView";
            reservationsGridView.RowHeadersWidth = 51;
            reservationsGridView.Size = new Size(1107, 916);
            reservationsGridView.TabIndex = 0;
            reservationsGridView.CellContentClick += reservationsGridView_CellContentClick_1;
            // 
            // ReservationControlView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(reservationsGridView);
            Margin = new Padding(0);
            Name = "ReservationControlView";
            Size = new Size(1107, 916);
            Load += ReservationControlView_Load;
            ((System.ComponentModel.ISupportInitialize)reservationsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView reservationsGridView;
    }
}
