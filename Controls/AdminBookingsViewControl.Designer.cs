namespace GymApp_final.Controls
{
    partial class AdminBookingsViewControl
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
            splitMain = new SplitContainer();
            btnDeleteBookingAdmin = new Button();
            lblClase = new Label();
            gridClassesAdmin = new DataGridView();
            gridBookingsAdmin = new DataGridView();
            lblSelectedClass = new Label();
            btnRefreshAdminBookings = new Button();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClassesAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridBookingsAdmin).BeginInit();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(btnDeleteBookingAdmin);
            splitMain.Panel1.Controls.Add(lblClase);
            splitMain.Panel1.Controls.Add(gridClassesAdmin);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(gridBookingsAdmin);
            splitMain.Panel2.Controls.Add(lblSelectedClass);
            splitMain.Panel2.Controls.Add(btnRefreshAdminBookings);
            splitMain.Size = new Size(874, 635);
            splitMain.SplitterDistance = 431;
            splitMain.TabIndex = 0;
            // 
            // btnDeleteBookingAdmin
            // 
            btnDeleteBookingAdmin.Location = new Point(307, 38);
            btnDeleteBookingAdmin.Name = "btnDeleteBookingAdmin";
            btnDeleteBookingAdmin.Size = new Size(94, 29);
            btnDeleteBookingAdmin.TabIndex = 2;
            btnDeleteBookingAdmin.Text = "Șterge rezervarea";
            btnDeleteBookingAdmin.UseVisualStyleBackColor = true;
            // 
            // lblClase
            // 
            lblClase.AutoSize = true;
            lblClase.Location = new Point(39, 47);
            lblClase.Name = "lblClase";
            lblClase.Size = new Size(44, 20);
            lblClase.TabIndex = 0;
            lblClase.Text = "Clase";
            // 
            // gridClassesAdmin
            // 
            gridClassesAdmin.AllowUserToAddRows = false;
            gridClassesAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            gridClassesAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClassesAdmin.Dock = DockStyle.Bottom;
            gridClassesAdmin.Location = new Point(0, 162);
            gridClassesAdmin.Name = "gridClassesAdmin";
            gridClassesAdmin.ReadOnly = true;
            gridClassesAdmin.RowHeadersWidth = 51;
            gridClassesAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClassesAdmin.Size = new Size(431, 473);
            gridClassesAdmin.TabIndex = 1;
            // 
            // gridBookingsAdmin
            // 
            gridBookingsAdmin.AllowUserToAddRows = false;
            gridBookingsAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridBookingsAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBookingsAdmin.Dock = DockStyle.Bottom;
            gridBookingsAdmin.Location = new Point(0, 162);
            gridBookingsAdmin.Name = "gridBookingsAdmin";
            gridBookingsAdmin.ReadOnly = true;
            gridBookingsAdmin.RowHeadersWidth = 51;
            gridBookingsAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridBookingsAdmin.Size = new Size(439, 473);
            gridBookingsAdmin.TabIndex = 1;
            // 
            // lblSelectedClass
            // 
            lblSelectedClass.AutoSize = true;
            lblSelectedClass.Location = new Point(24, 42);
            lblSelectedClass.Name = "lblSelectedClass";
            lblSelectedClass.Size = new Size(225, 20);
            lblSelectedClass.TabIndex = 0;
            lblSelectedClass.Text = "Rezervări pentru: (nimic selectat)";
            // 
            // btnRefreshAdminBookings
            // 
            btnRefreshAdminBookings.Location = new Point(299, 38);
            btnRefreshAdminBookings.Name = "btnRefreshAdminBookings";
            btnRefreshAdminBookings.Size = new Size(94, 29);
            btnRefreshAdminBookings.TabIndex = 0;
            btnRefreshAdminBookings.Text = "Refresh";
            btnRefreshAdminBookings.UseVisualStyleBackColor = true;
            // 
            // AdminBookingsViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitMain);
            Name = "AdminBookingsViewControl";
            Size = new Size(874, 635);
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel1.PerformLayout();
            splitMain.Panel2.ResumeLayout(false);
            splitMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClassesAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridBookingsAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMain;
        private Button btnRefreshAdminBookings;
        private DataGridView gridClassesAdmin;
        private Label lblClase;
        private Button btnDeleteBookingAdmin;
        private DataGridView gridBookingsAdmin;
        private Label lblSelectedClass;
    }
}
