namespace DSBooking.UI
{
    partial class MainForm
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
            mainTabControl = new TabControl();
            clientsAndReservationsTab = new TabPage();
            packagesTab = new TabPage();
            destinationsTab = new TabPage();
            mainTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(clientsAndReservationsTab);
            mainTabControl.Controls.Add(packagesTab);
            mainTabControl.Controls.Add(destinationsTab);
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1452, 581);
            mainTabControl.TabIndex = 1;
            // 
            // clientsAndReservationsTab
            // 
            clientsAndReservationsTab.Location = new Point(4, 24);
            clientsAndReservationsTab.Name = "clientsAndReservationsTab";
            clientsAndReservationsTab.Padding = new Padding(3);
            clientsAndReservationsTab.Size = new Size(1444, 553);
            clientsAndReservationsTab.TabIndex = 0;
            clientsAndReservationsTab.Text = "Clients & Reservations";
            clientsAndReservationsTab.UseVisualStyleBackColor = true;
            // 
            // packagesTab
            // 
            packagesTab.Location = new Point(4, 24);
            packagesTab.Name = "packagesTab";
            packagesTab.Padding = new Padding(3);
            packagesTab.Size = new Size(1444, 553);
            packagesTab.TabIndex = 1;
            packagesTab.Text = "Packages";
            packagesTab.UseVisualStyleBackColor = true;
            // 
            // destinationsTab
            // 
            destinationsTab.Location = new Point(4, 24);
            destinationsTab.Name = "destinationsTab";
            destinationsTab.Padding = new Padding(3);
            destinationsTab.Size = new Size(1444, 553);
            destinationsTab.TabIndex = 2;
            destinationsTab.Text = "Destinations";
            destinationsTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 579);
            Controls.Add(mainTabControl);
            Name = "MainForm";
            Text = "DSBooking";
            Load += DSForm_Load;
            mainTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage clientsAndReservationsTab;
        private TabPage packagesTab;
        private TabPage destinationsTab;
    }
}