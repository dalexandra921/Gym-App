namespace GymApp_final.Controls
{
    partial class ZonesControl
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
            gridZones = new DataGridView();
            panelEdit = new Panel();
            lblCloseHour = new Label();
            lblOpenHour = new Label();
            lblZoneAccess = new Label();
            lblName = new Label();
            btnRefreshZones = new Button();
            btnDeleteZone = new Button();
            btnUpdateZone = new Button();
            btnAddZone = new Button();
            numCloseHour = new NumericUpDown();
            numOpenHour = new NumericUpDown();
            cmbZoneAccess = new ComboBox();
            txtZoneName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridZones).BeginInit();
            panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCloseHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOpenHour).BeginInit();
            SuspendLayout();
            // 
            // gridZones
            // 
            gridZones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridZones.Dock = DockStyle.Top;
            gridZones.Location = new Point(0, 0);
            gridZones.Name = "gridZones";
            gridZones.RowHeadersWidth = 51;
            gridZones.Size = new Size(868, 188);
            gridZones.TabIndex = 0;
            // 
            // panelEdit
            // 
            panelEdit.Controls.Add(lblCloseHour);
            panelEdit.Controls.Add(lblOpenHour);
            panelEdit.Controls.Add(lblZoneAccess);
            panelEdit.Controls.Add(lblName);
            panelEdit.Controls.Add(btnRefreshZones);
            panelEdit.Controls.Add(btnDeleteZone);
            panelEdit.Controls.Add(btnUpdateZone);
            panelEdit.Controls.Add(btnAddZone);
            panelEdit.Controls.Add(numCloseHour);
            panelEdit.Controls.Add(numOpenHour);
            panelEdit.Controls.Add(cmbZoneAccess);
            panelEdit.Controls.Add(txtZoneName);
            panelEdit.Dock = DockStyle.Fill;
            panelEdit.Location = new Point(0, 188);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(868, 444);
            panelEdit.TabIndex = 1;
            // 
            // lblCloseHour
            // 
            lblCloseHour.AutoSize = true;
            lblCloseHour.Location = new Point(67, 209);
            lblCloseHour.Name = "lblCloseHour";
            lblCloseHour.Size = new Size(98, 20);
            lblCloseHour.TabIndex = 11;
            lblCloseHour.Text = "Oră închidere";
            // 
            // lblOpenHour
            // 
            lblOpenHour.AutoSize = true;
            lblOpenHour.Location = new Point(67, 154);
            lblOpenHour.Name = "lblOpenHour";
            lblOpenHour.Size = new Size(109, 20);
            lblOpenHour.TabIndex = 10;
            lblOpenHour.Text = "Oră deschidere";
            // 
            // lblZoneAccess
            // 
            lblZoneAccess.AutoSize = true;
            lblZoneAccess.Location = new Point(67, 93);
            lblZoneAccess.Name = "lblZoneAccess";
            lblZoneAccess.Size = new Size(71, 20);
            lblZoneAccess.TabIndex = 9;
            lblZoneAccess.Text = "Tip Acess";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(67, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(85, 20);
            lblName.TabIndex = 8;
            lblName.Text = "Nume zonă";
            // 
            // btnRefreshZones
            // 
            btnRefreshZones.Location = new Point(694, 205);
            btnRefreshZones.Name = "btnRefreshZones";
            btnRefreshZones.Size = new Size(94, 29);
            btnRefreshZones.TabIndex = 7;
            btnRefreshZones.Text = "Refresh";
            btnRefreshZones.UseVisualStyleBackColor = true;
            // 
            // btnDeleteZone
            // 
            btnDeleteZone.Location = new Point(694, 150);
            btnDeleteZone.Name = "btnDeleteZone";
            btnDeleteZone.Size = new Size(94, 29);
            btnDeleteZone.TabIndex = 6;
            btnDeleteZone.Text = "Delete";
            btnDeleteZone.UseVisualStyleBackColor = true;
            // 
            // btnUpdateZone
            // 
            btnUpdateZone.Location = new Point(694, 102);
            btnUpdateZone.Name = "btnUpdateZone";
            btnUpdateZone.Size = new Size(94, 29);
            btnUpdateZone.TabIndex = 5;
            btnUpdateZone.Text = "Update";
            btnUpdateZone.UseVisualStyleBackColor = true;
            // 
            // btnAddZone
            // 
            btnAddZone.Location = new Point(694, 39);
            btnAddZone.Name = "btnAddZone";
            btnAddZone.Size = new Size(94, 29);
            btnAddZone.TabIndex = 4;
            btnAddZone.Text = "Add";
            btnAddZone.UseVisualStyleBackColor = true;
            // 
            // numCloseHour
            // 
            numCloseHour.Location = new Point(205, 204);
            numCloseHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numCloseHour.Name = "numCloseHour";
            numCloseHour.Size = new Size(299, 27);
            numCloseHour.TabIndex = 3;
            // 
            // numOpenHour
            // 
            numOpenHour.Location = new Point(205, 149);
            numOpenHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numOpenHour.Name = "numOpenHour";
            numOpenHour.Size = new Size(299, 27);
            numOpenHour.TabIndex = 2;
            // 
            // cmbZoneAccess
            // 
            cmbZoneAccess.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbZoneAccess.FormattingEnabled = true;
            cmbZoneAccess.Location = new Point(205, 85);
            cmbZoneAccess.Name = "cmbZoneAccess";
            cmbZoneAccess.Size = new Size(299, 28);
            cmbZoneAccess.TabIndex = 1;
            // 
            // txtZoneName
            // 
            txtZoneName.Location = new Point(205, 40);
            txtZoneName.Name = "txtZoneName";
            txtZoneName.Size = new Size(299, 27);
            txtZoneName.TabIndex = 0;
            // 
            // ZonesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelEdit);
            Controls.Add(gridZones);
            Name = "ZonesControl";
            Size = new Size(868, 632);
            ((System.ComponentModel.ISupportInitialize)gridZones).EndInit();
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCloseHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOpenHour).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridZones;
        private Panel panelEdit;
        private Button btnRefreshZones;
        private Button btnDeleteZone;
        private Button btnUpdateZone;
        private Button btnAddZone;
        private NumericUpDown numCloseHour;
        private NumericUpDown numOpenHour;
        private ComboBox cmbZoneAccess;
        private TextBox txtZoneName;
        private Label lblCloseHour;
        private Label lblOpenHour;
        private Label lblZoneAccess;
        private Label lblName;
    }
}
