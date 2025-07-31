namespace DSBooking.Presentation
{
    partial class ClientReservationControlView
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
            addClientButton = new Button();
            removeClientButton = new Button();
            listAllClientsButton = new Button();
            SuspendLayout();
            // 
            // addClientButton
            // 
            addClientButton.Location = new Point(75, 14);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(168, 46);
            addClientButton.TabIndex = 0;
            addClientButton.Text = "Add Client";
            addClientButton.UseVisualStyleBackColor = true;
            addClientButton.Click += button1_Click;
            // 
            // removeClientButton
            // 
            removeClientButton.Location = new Point(657, 14);
            removeClientButton.Name = "removeClientButton";
            removeClientButton.Size = new Size(168, 46);
            removeClientButton.TabIndex = 1;
            removeClientButton.Text = "Remove Client";
            removeClientButton.UseVisualStyleBackColor = true;
            // 
            // listAllClientsButton
            // 
            listAllClientsButton.Location = new Point(1227, 14);
            listAllClientsButton.Name = "listAllClientsButton";
            listAllClientsButton.Size = new Size(168, 46);
            listAllClientsButton.TabIndex = 2;
            listAllClientsButton.Text = "List All Clients";
            listAllClientsButton.UseVisualStyleBackColor = true;
            // 
            // ClientReservationControlView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listAllClientsButton);
            Controls.Add(removeClientButton);
            Controls.Add(addClientButton);
            Name = "ClientReservationControlView";
            Size = new Size(1457, 608);
            Load += ClientReservationControlView_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addClientButton;
        private Button removeClientButton;
        private Button listAllClientsButton;
    }
}
