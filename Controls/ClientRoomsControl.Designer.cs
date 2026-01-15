namespace GymApp_final.Controls
{
    partial class ClientRoomsControl
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
            gridRoomsClient = new DataGridView();
            panelTop = new Panel();
            chkOnlyOpen = new CheckBox();
            btnRefreshRooms = new Button();
            ((System.ComponentModel.ISupportInitialize)gridRoomsClient).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // gridRoomsClient
            // 
            gridRoomsClient.AllowUserToAddRows = false;
            gridRoomsClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridRoomsClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRoomsClient.Dock = DockStyle.Fill;
            gridRoomsClient.Location = new Point(0, 0);
            gridRoomsClient.Name = "gridRoomsClient";
            gridRoomsClient.ReadOnly = true;
            gridRoomsClient.RowHeadersWidth = 51;
            gridRoomsClient.Size = new Size(860, 587);
            gridRoomsClient.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnRefreshRooms);
            panelTop.Controls.Add(chkOnlyOpen);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(860, 138);
            panelTop.TabIndex = 1;
            // 
            // chkOnlyOpen
            // 
            chkOnlyOpen.AutoSize = true;
            chkOnlyOpen.Location = new Point(30, 34);
            chkOnlyOpen.Name = "chkOnlyOpen";
            chkOnlyOpen.Size = new Size(164, 24);
            chkOnlyOpen.TabIndex = 0;
            chkOnlyOpen.Text = "Doar deschise acum";
            chkOnlyOpen.UseVisualStyleBackColor = true;
            // 
            // btnRefreshRooms
            // 
            btnRefreshRooms.Location = new Point(705, 34);
            btnRefreshRooms.Name = "btnRefreshRooms";
            btnRefreshRooms.Size = new Size(94, 29);
            btnRefreshRooms.TabIndex = 0;
            btnRefreshRooms.Text = "Refresh";
            btnRefreshRooms.UseVisualStyleBackColor = true;
            // 
            // ClientRoomsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTop);
            Controls.Add(gridRoomsClient);
            Name = "ClientRoomsControl";
            Size = new Size(860, 587);
            ((System.ComponentModel.ISupportInitialize)gridRoomsClient).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridRoomsClient;
        private Panel panelTop;
        private Button btnRefreshRooms;
        private CheckBox chkOnlyOpen;
    }
}
