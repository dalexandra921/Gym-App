namespace GymApp_final.Controls
{
    partial class PlansControl
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
            gridPlans = new DataGridView();
            panelEdit = new Panel();
            lblAccessType = new Label();
            cmbPlanAccess = new ComboBox();
            btnRefreshPlans = new Button();
            btnDeletePlan = new Button();
            btnUpdatePlan = new Button();
            btnAddPlan = new Button();
            txtPlanDesc = new TextBox();
            lblPlanDescription = new Label();
            txtPlanName = new TextBox();
            numPlanPrice = new NumericUpDown();
            lblPlanPrice = new Label();
            lblPlanName = new Label();
            numValidDays = new NumericUpDown();
            lblValidDays = new Label();
            ((System.ComponentModel.ISupportInitialize)gridPlans).BeginInit();
            panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPlanPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValidDays).BeginInit();
            SuspendLayout();
            // 
            // gridPlans
            // 
            gridPlans.AllowUserToAddRows = false;
            gridPlans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridPlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPlans.Dock = DockStyle.Top;
            gridPlans.Location = new Point(0, 0);
            gridPlans.MultiSelect = false;
            gridPlans.Name = "gridPlans";
            gridPlans.ReadOnly = true;
            gridPlans.RowHeadersWidth = 51;
            gridPlans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPlans.Size = new Size(786, 188);
            gridPlans.TabIndex = 0;
            // 
            // panelEdit
            // 
            panelEdit.Controls.Add(lblValidDays);
            panelEdit.Controls.Add(numValidDays);
            panelEdit.Controls.Add(lblAccessType);
            panelEdit.Controls.Add(cmbPlanAccess);
            panelEdit.Controls.Add(btnRefreshPlans);
            panelEdit.Controls.Add(btnDeletePlan);
            panelEdit.Controls.Add(btnUpdatePlan);
            panelEdit.Controls.Add(btnAddPlan);
            panelEdit.Controls.Add(txtPlanDesc);
            panelEdit.Controls.Add(lblPlanDescription);
            panelEdit.Controls.Add(txtPlanName);
            panelEdit.Controls.Add(numPlanPrice);
            panelEdit.Controls.Add(lblPlanPrice);
            panelEdit.Controls.Add(lblPlanName);
            panelEdit.Dock = DockStyle.Fill;
            panelEdit.Location = new Point(0, 188);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(786, 378);
            panelEdit.TabIndex = 1;
            // 
            // lblAccessType
            // 
            lblAccessType.AutoSize = true;
            lblAccessType.Location = new Point(22, 225);
            lblAccessType.Name = "lblAccessType";
            lblAccessType.Size = new Size(70, 20);
            lblAccessType.TabIndex = 11;
            lblAccessType.Text = "Tip acces";
            // 
            // cmbPlanAccess
            // 
            cmbPlanAccess.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlanAccess.FormattingEnabled = true;
            cmbPlanAccess.Items.AddRange(new object[] { "Standard", "VIP" });
            cmbPlanAccess.Location = new Point(146, 222);
            cmbPlanAccess.Name = "cmbPlanAccess";
            cmbPlanAccess.Size = new Size(300, 28);
            cmbPlanAccess.TabIndex = 10;
            // 
            // btnRefreshPlans
            // 
            btnRefreshPlans.Location = new Point(536, 189);
            btnRefreshPlans.Name = "btnRefreshPlans";
            btnRefreshPlans.Size = new Size(94, 29);
            btnRefreshPlans.TabIndex = 9;
            btnRefreshPlans.Text = "Refresh";
            btnRefreshPlans.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlan
            // 
            btnDeletePlan.Location = new Point(536, 137);
            btnDeletePlan.Name = "btnDeletePlan";
            btnDeletePlan.Size = new Size(94, 29);
            btnDeletePlan.TabIndex = 8;
            btnDeletePlan.Text = "Delete";
            btnDeletePlan.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePlan
            // 
            btnUpdatePlan.Location = new Point(536, 80);
            btnUpdatePlan.Name = "btnUpdatePlan";
            btnUpdatePlan.Size = new Size(94, 29);
            btnUpdatePlan.TabIndex = 7;
            btnUpdatePlan.Text = "Update";
            btnUpdatePlan.UseVisualStyleBackColor = true;
            // 
            // btnAddPlan
            // 
            btnAddPlan.Location = new Point(536, 31);
            btnAddPlan.Name = "btnAddPlan";
            btnAddPlan.Size = new Size(94, 29);
            btnAddPlan.TabIndex = 6;
            btnAddPlan.Text = "Add";
            btnAddPlan.UseVisualStyleBackColor = true;
            // 
            // txtPlanDesc
            // 
            txtPlanDesc.Location = new Point(146, 138);
            txtPlanDesc.Multiline = true;
            txtPlanDesc.Name = "txtPlanDesc";
            txtPlanDesc.ScrollBars = ScrollBars.Vertical;
            txtPlanDesc.Size = new Size(300, 60);
            txtPlanDesc.TabIndex = 5;
            // 
            // lblPlanDescription
            // 
            lblPlanDescription.AutoSize = true;
            lblPlanDescription.Location = new Point(22, 141);
            lblPlanDescription.Name = "lblPlanDescription";
            lblPlanDescription.Size = new Size(71, 20);
            lblPlanDescription.TabIndex = 4;
            lblPlanDescription.Text = "Descriere";
            // 
            // txtPlanName
            // 
            txtPlanName.Location = new Point(145, 33);
            txtPlanName.Name = "txtPlanName";
            txtPlanName.Size = new Size(301, 27);
            txtPlanName.TabIndex = 3;
            // 
            // numPlanPrice
            // 
            numPlanPrice.DecimalPlaces = 2;
            numPlanPrice.Location = new Point(145, 80);
            numPlanPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPlanPrice.Name = "numPlanPrice";
            numPlanPrice.Size = new Size(301, 27);
            numPlanPrice.TabIndex = 2;
            // 
            // lblPlanPrice
            // 
            lblPlanPrice.AutoSize = true;
            lblPlanPrice.Location = new Point(22, 87);
            lblPlanPrice.Name = "lblPlanPrice";
            lblPlanPrice.Size = new Size(35, 20);
            lblPlanPrice.TabIndex = 1;
            lblPlanPrice.Text = "Preț";
            // 
            // lblPlanName
            // 
            lblPlanName.AutoSize = true;
            lblPlanName.Location = new Point(22, 36);
            lblPlanName.Name = "lblPlanName";
            lblPlanName.Size = new Size(49, 20);
            lblPlanName.TabIndex = 0;
            lblPlanName.Text = "Nume";
            // 
            // numValidDays
            // 
            numValidDays.Location = new Point(146, 276);
            numValidDays.Maximum = new decimal(new int[] { 3650, 0, 0, 0 });
            numValidDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numValidDays.Name = "numValidDays";
            numValidDays.Size = new Size(300, 27);
            numValidDays.TabIndex = 12;
            numValidDays.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblValidDays
            // 
            lblValidDays.AutoSize = true;
            lblValidDays.Location = new Point(22, 278);
            lblValidDays.Name = "lblValidDays";
            lblValidDays.Size = new Size(121, 20);
            lblValidDays.TabIndex = 13;
            lblValidDays.Text = "Valabilitate (zile)";
            // 
            // PlansControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelEdit);
            Controls.Add(gridPlans);
            Name = "PlansControl";
            Size = new Size(786, 566);
            ((System.ComponentModel.ISupportInitialize)gridPlans).EndInit();
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPlanPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValidDays).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridPlans;
        private Panel panelEdit;
        private NumericUpDown numPlanPrice;
        private Label lblPlanPrice;
        private Label lblPlanName;
        private Button btnAddPlan;
        private TextBox txtPlanDesc;
        private Label lblPlanDescription;
        private TextBox txtPlanName;
        private Button btnRefreshPlans;
        private Button btnDeletePlan;
        private Button btnUpdatePlan;
        private Label lblAccessType;
        private ComboBox cmbPlanAccess;
        private Label lblValidDays;
        private NumericUpDown numValidDays;
    }
}
