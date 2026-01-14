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
            lblTotalBookings = new Label();
            lblActiveSubs = new Label();
            lblTopClient = new Label();
            gridClassOccupancy = new DataGridView();
            btnRefreshStats = new Button();
            ((System.ComponentModel.ISupportInitialize)gridClassOccupancy).BeginInit();
            SuspendLayout();
            // 
            // lblTotalBookings
            // 
            lblTotalBookings.AutoSize = true;
            lblTotalBookings.Location = new Point(29, 81);
            lblTotalBookings.Name = "lblTotalBookings";
            lblTotalBookings.Size = new Size(128, 20);
            lblTotalBookings.TabIndex = 0;
            lblTotalBookings.Text = "Rezervări totale: 0";
            // 
            // lblActiveSubs
            // 
            lblActiveSubs.AutoSize = true;
            lblActiveSubs.Location = new Point(29, 41);
            lblActiveSubs.Name = "lblActiveSubs";
            lblActiveSubs.Size = new Size(153, 20);
            lblActiveSubs.TabIndex = 1;
            lblActiveSubs.Text = "Abonamente active: 0";
            // 
            // lblTopClient
            // 
            lblTopClient.AutoSize = true;
            lblTopClient.Location = new Point(29, 120);
            lblTopClient.Name = "lblTopClient";
            lblTopClient.Size = new Size(87, 20);
            lblTopClient.TabIndex = 2;
            lblTopClient.Text = "Top client: -";
            // 
            // gridClassOccupancy
            // 
            gridClassOccupancy.AllowUserToAddRows = false;
            gridClassOccupancy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClassOccupancy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClassOccupancy.Dock = DockStyle.Bottom;
            gridClassOccupancy.Location = new Point(0, 207);
            gridClassOccupancy.Name = "gridClassOccupancy";
            gridClassOccupancy.ReadOnly = true;
            gridClassOccupancy.RowHeadersWidth = 51;
            gridClassOccupancy.Size = new Size(805, 402);
            gridClassOccupancy.TabIndex = 3;
            // 
            // btnRefreshStats
            // 
            btnRefreshStats.Location = new Point(473, 92);
            btnRefreshStats.Name = "btnRefreshStats";
            btnRefreshStats.Size = new Size(94, 29);
            btnRefreshStats.TabIndex = 4;
            btnRefreshStats.Text = "Refresh";
            btnRefreshStats.UseVisualStyleBackColor = true;
            // 
            // AdminStatsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefreshStats);
            Controls.Add(gridClassOccupancy);
            Controls.Add(lblTopClient);
            Controls.Add(lblActiveSubs);
            Controls.Add(lblTotalBookings);
            Name = "AdminStatsControl";
            Size = new Size(805, 609);
            ((System.ComponentModel.ISupportInitialize)gridClassOccupancy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalBookings;
        private Label lblActiveSubs;
        private Label lblTopClient;
        private DataGridView gridClassOccupancy;
        private Button btnRefreshStats;
    }
}
