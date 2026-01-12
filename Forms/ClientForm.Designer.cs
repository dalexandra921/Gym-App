namespace GymApp_final
{
    partial class ClientForm
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
            tabClient = new TabControl();
            tabSchedule = new TabPage();
            tabMyBookings = new TabPage();
            tabClient.SuspendLayout();
            SuspendLayout();
            // 
            // tabClient
            // 
            tabClient.Controls.Add(tabSchedule);
            tabClient.Controls.Add(tabMyBookings);
            tabClient.Dock = DockStyle.Fill;
            tabClient.Location = new Point(0, 0);
            tabClient.Name = "tabClient";
            tabClient.SelectedIndex = 0;
            tabClient.Size = new Size(884, 487);
            tabClient.TabIndex = 0;
            // 
            // tabSchedule
            // 
            tabSchedule.Location = new Point(4, 29);
            tabSchedule.Name = "tabSchedule";
            tabSchedule.Padding = new Padding(3);
            tabSchedule.Size = new Size(876, 454);
            tabSchedule.TabIndex = 0;
            tabSchedule.Text = "Clase disponibile";
            tabSchedule.UseVisualStyleBackColor = true;
            // 
            // tabMyBookings
            // 
            tabMyBookings.Location = new Point(4, 29);
            tabMyBookings.Name = "tabMyBookings";
            tabMyBookings.Padding = new Padding(3);
            tabMyBookings.Size = new Size(876, 454);
            tabMyBookings.TabIndex = 1;
            tabMyBookings.Text = "Rezervările mele";
            tabMyBookings.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 487);
            Controls.Add(tabClient);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            tabClient.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabClient;
        private TabPage tabSchedule;
        private TabPage tabMyBookings;
    }
}