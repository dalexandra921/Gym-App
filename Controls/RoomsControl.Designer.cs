namespace GymApp_final.Controls
{
    partial class RoomsControl
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
            gridRooms = new DataGridView();
            cmbRoomZone = new ComboBox();
            lblZone = new Label();
            txtRoomName = new TextBox();
            lblZoneName = new Label();
            numRoomCapacity = new NumericUpDown();
            lblRoomCapacity = new Label();
            cmbRoomAccess = new ComboBox();
            lblRoomAccess = new Label();
            btnAddRoom = new Button();
            btnUpdateRoom = new Button();
            btnDeleteRoom = new Button();
            btnRefreshRooms = new Button();
            ((System.ComponentModel.ISupportInitialize)gridRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoomCapacity).BeginInit();
            SuspendLayout();
            // 
            // gridRooms
            // 
            gridRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRooms.Dock = DockStyle.Top;
            gridRooms.Location = new Point(0, 0);
            gridRooms.Name = "gridRooms";
            gridRooms.RowHeadersWidth = 51;
            gridRooms.Size = new Size(874, 250);
            gridRooms.TabIndex = 0;
            // 
            // cmbRoomZone
            // 
            cmbRoomZone.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomZone.FormattingEnabled = true;
            cmbRoomZone.Location = new Point(184, 301);
            cmbRoomZone.Name = "cmbRoomZone";
            cmbRoomZone.Size = new Size(268, 28);
            cmbRoomZone.TabIndex = 1;
            // 
            // lblZone
            // 
            lblZone.AutoSize = true;
            lblZone.Location = new Point(32, 299);
            lblZone.Name = "lblZone";
            lblZone.Size = new Size(43, 20);
            lblZone.TabIndex = 2;
            lblZone.Text = "Zonă";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(184, 355);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(268, 27);
            txtRoomName.TabIndex = 3;
            // 
            // lblZoneName
            // 
            lblZoneName.AutoSize = true;
            lblZoneName.Location = new Point(32, 357);
            lblZoneName.Name = "lblZoneName";
            lblZoneName.Size = new Size(79, 20);
            lblZoneName.TabIndex = 4;
            lblZoneName.Text = "Nume sală";
            // 
            // numRoomCapacity
            // 
            numRoomCapacity.Location = new Point(184, 422);
            numRoomCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numRoomCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRoomCapacity.Name = "numRoomCapacity";
            numRoomCapacity.Size = new Size(268, 27);
            numRoomCapacity.TabIndex = 5;
            numRoomCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblRoomCapacity
            // 
            lblRoomCapacity.AutoSize = true;
            lblRoomCapacity.Location = new Point(32, 424);
            lblRoomCapacity.Name = "lblRoomCapacity";
            lblRoomCapacity.Size = new Size(80, 20);
            lblRoomCapacity.TabIndex = 6;
            lblRoomCapacity.Text = "Capacitate";
            // 
            // cmbRoomAccess
            // 
            cmbRoomAccess.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomAccess.FormattingEnabled = true;
            cmbRoomAccess.Location = new Point(184, 484);
            cmbRoomAccess.Name = "cmbRoomAccess";
            cmbRoomAccess.Size = new Size(268, 28);
            cmbRoomAccess.TabIndex = 7;
            // 
            // lblRoomAccess
            // 
            lblRoomAccess.AutoSize = true;
            lblRoomAccess.Location = new Point(42, 487);
            lblRoomAccess.Name = "lblRoomAccess";
            lblRoomAccess.Size = new Size(70, 20);
            lblRoomAccess.TabIndex = 8;
            lblRoomAccess.Text = "Tip acces";
            // 
            // btnAddRoom
            // 
            btnAddRoom.Location = new Point(650, 291);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(94, 29);
            btnAddRoom.TabIndex = 9;
            btnAddRoom.Text = "Add";
            btnAddRoom.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRoom
            // 
            btnUpdateRoom.Location = new Point(650, 345);
            btnUpdateRoom.Name = "btnUpdateRoom";
            btnUpdateRoom.Size = new Size(94, 29);
            btnUpdateRoom.TabIndex = 10;
            btnUpdateRoom.Text = "Update";
            btnUpdateRoom.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.Location = new Point(650, 415);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(94, 29);
            btnDeleteRoom.TabIndex = 11;
            btnDeleteRoom.Text = "Delete";
            btnDeleteRoom.UseVisualStyleBackColor = true;
            // 
            // btnRefreshRooms
            // 
            btnRefreshRooms.Location = new Point(650, 478);
            btnRefreshRooms.Name = "btnRefreshRooms";
            btnRefreshRooms.Size = new Size(94, 29);
            btnRefreshRooms.TabIndex = 12;
            btnRefreshRooms.Text = "Refresh";
            btnRefreshRooms.UseVisualStyleBackColor = true;
            // 
            // RoomsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefreshRooms);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnUpdateRoom);
            Controls.Add(btnAddRoom);
            Controls.Add(lblRoomAccess);
            Controls.Add(cmbRoomAccess);
            Controls.Add(lblRoomCapacity);
            Controls.Add(numRoomCapacity);
            Controls.Add(lblZoneName);
            Controls.Add(txtRoomName);
            Controls.Add(lblZone);
            Controls.Add(cmbRoomZone);
            Controls.Add(gridRooms);
            Name = "RoomsControl";
            Size = new Size(874, 570);
            ((System.ComponentModel.ISupportInitialize)gridRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoomCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridRooms;
        private ComboBox cmbRoomZone;
        private Label lblZone;
        private TextBox txtRoomName;
        private Label lblZoneName;
        private NumericUpDown numRoomCapacity;
        private Label lblRoomCapacity;
        private ComboBox cmbRoomAccess;
        private Label lblRoomAccess;
        private Button btnAddRoom;
        private Button btnUpdateRoom;
        private Button btnDeleteRoom;
        private Button btnRefreshRooms;
    }
}
