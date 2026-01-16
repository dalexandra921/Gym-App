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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gridClassStats).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblActiveSubs
            // 
            lblActiveSubs.AutoSize = true;
            lblActiveSubs.Location = new Point(45, 24);
            lblActiveSubs.Name = "lblActiveSubs";
            lblActiveSubs.Size = new Size(153, 20);
            lblActiveSubs.TabIndex = 0;
            lblActiveSubs.Text = "Abonamente active: 0";
            // 
            // lblTotalBookings
            // 
            lblTotalBookings.AutoSize = true;
            lblTotalBookings.Location = new Point(45, 65);
            lblTotalBookings.Name = "lblTotalBookings";
            lblTotalBookings.Size = new Size(128, 20);
            lblTotalBookings.TabIndex = 1;
            lblTotalBookings.Text = "Rezervări totale: 0";
            // 
            // lblTopClient
            // 
            lblTopClient.AutoSize = true;
            lblTopClient.Location = new Point(45, 110);
            lblTopClient.Name = "lblTopClient";
            lblTopClient.Size = new Size(87, 20);
            lblTopClient.TabIndex = 2;
            lblTopClient.Text = "Top client: -";
            // 
            // btnRefreshStats
            // 
            btnRefreshStats.Location = new Point(658, 61);
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
            gridClassStats.Location = new Point(0, 284);
            gridClassStats.Name = "gridClassStats";
            gridClassStats.ReadOnly = true;
            gridClassStats.RowHeadersWidth = 51;
            gridClassStats.Size = new Size(859, 364);
            gridClassStats.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefreshStats);
            panel1.Controls.Add(lblTotalBookings);
            panel1.Controls.Add(lblTopClient);
            panel1.Controls.Add(lblActiveSubs);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 142);
            panel1.TabIndex = 5;
            // 
            // AdminStatsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(gridClassStats);
            Name = "AdminStatsControl";
            Size = new Size(859, 648);
            ((System.ComponentModel.ISupportInitialize)gridClassStats).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblActiveSubs;
        private Label lblTotalBookings;
        private Label lblTopClient;
        private Button btnRefreshStats;
        private DataGridView gridClassStats;
        private Panel panel1;
    }
}
