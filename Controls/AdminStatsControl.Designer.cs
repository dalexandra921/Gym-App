namespace GymApp_final.Controls
{
    partial class AdminStatsControl
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
            lblActiveSubs = new Label();
            lblTotalBookings = new Label();
            lblTopClient = new Label();
            btnRefreshStats = new Button();
            gridClassStats = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridClassStats).BeginInit();
            SuspendLayout();
            // 
            // lblActiveSubs
            // 
            lblActiveSubs.AutoSize = true;
            lblActiveSubs.Location = new Point(46, 37);
            lblActiveSubs.Name = "lblActiveSubs";
            lblActiveSubs.Size = new Size(153, 20);
            lblActiveSubs.TabIndex = 0;
            lblActiveSubs.Text = "Abonamente active: 0";
            // 
            // lblTotalBookings
            // 
            lblTotalBookings.AutoSize = true;
            lblTotalBookings.Location = new Point(46, 78);
            lblTotalBookings.Name = "lblTotalBookings";
            lblTotalBookings.Size = new Size(128, 20);
            lblTotalBookings.TabIndex = 1;
            lblTotalBookings.Text = "Rezervări totale: 0";
            // 
            // lblTopClient
            // 
            lblTopClient.AutoSize = true;
            lblTopClient.Location = new Point(46, 123);
            lblTopClient.Name = "lblTopClient";
            lblTopClient.Size = new Size(87, 20);
            lblTopClient.TabIndex = 2;
            lblTopClient.Text = "Top client: -";
            // 
            // btnRefreshStats
            // 
            btnRefreshStats.Location = new Point(492, 69);
            btnRefreshStats.Name = "btnRefreshStats";
            btnRefreshStats.Size = new Size(94, 29);
            btnRefreshStats.TabIndex = 3;
            btnRefreshStats.Text = "Refresh";
            btnRefreshStats.UseVisualStyleBackColor = true;
            // 
            // gridClassStats
            // 
            gridClassStats.AllowUserToAddRows = false;
            gridClassStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClassStats.Dock = DockStyle.Bottom;
            gridClassStats.Location = new Point(0, 235);
            gridClassStats.Name = "gridClassStats";
            gridClassStats.ReadOnly = true;
            gridClassStats.RowHeadersWidth = 51;
            gridClassStats.Size = new Size(859, 413);
            gridClassStats.TabIndex = 4;
            // 
            // AdminStatsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridClassStats);
            Controls.Add(btnRefreshStats);
            Controls.Add(lblTopClient);
            Controls.Add(lblTotalBookings);
            Controls.Add(lblActiveSubs);
            Name = "AdminStatsControl";
            Size = new Size(859, 648);
            ((System.ComponentModel.ISupportInitialize)gridClassStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblActiveSubs;
        private Label lblTotalBookings;
        private Label lblTopClient;
        private Button btnRefreshStats;
        private DataGridView gridClassStats;
    }
}
