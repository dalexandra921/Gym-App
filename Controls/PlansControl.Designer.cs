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
            lblPlanName = new Label();
            lblPlanPrice = new Label();
            numPlanPrice = new NumericUpDown();
            txtPlanName = new TextBox();
            lblPlanDescription = new Label();
            txtPlanDesc = new TextBox();
            btnAddPlan = new Button();
            btnUpdatePlan = new Button();
            btnDeletePlan = new Button();
            btnRefreshPlans = new Button();
            ((System.ComponentModel.ISupportInitialize)gridPlans).BeginInit();
            panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPlanPrice).BeginInit();
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
            // lblPlanName
            // 
            lblPlanName.AutoSize = true;
            lblPlanName.Location = new Point(22, 36);
            lblPlanName.Name = "lblPlanName";
            lblPlanName.Size = new Size(49, 20);
            lblPlanName.TabIndex = 0;
            lblPlanName.Text = "Nume";
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
            // numPlanPrice
            // 
            numPlanPrice.DecimalPlaces = 2;
            numPlanPrice.Location = new Point(145, 80);
            numPlanPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPlanPrice.Name = "numPlanPrice";
            numPlanPrice.Size = new Size(301, 27);
            numPlanPrice.TabIndex = 2;
            // 
            // txtPlanName
            // 
            txtPlanName.Location = new Point(145, 33);
            txtPlanName.Name = "txtPlanName";
            txtPlanName.Size = new Size(301, 27);
            txtPlanName.TabIndex = 3;
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
            // txtPlanDesc
            // 
            txtPlanDesc.Location = new Point(146, 138);
            txtPlanDesc.Multiline = true;
            txtPlanDesc.Name = "txtPlanDesc";
            txtPlanDesc.ScrollBars = ScrollBars.Vertical;
            txtPlanDesc.Size = new Size(300, 60);
            txtPlanDesc.TabIndex = 5;
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
            // btnUpdatePlan
            // 
            btnUpdatePlan.Location = new Point(536, 80);
            btnUpdatePlan.Name = "btnUpdatePlan";
            btnUpdatePlan.Size = new Size(94, 29);
            btnUpdatePlan.TabIndex = 7;
            btnUpdatePlan.Text = "Update";
            btnUpdatePlan.UseVisualStyleBackColor = true;
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
            // btnRefreshPlans
            // 
            btnRefreshPlans.Location = new Point(536, 189);
            btnRefreshPlans.Name = "btnRefreshPlans";
            btnRefreshPlans.Size = new Size(94, 29);
            btnRefreshPlans.TabIndex = 9;
            btnRefreshPlans.Text = "Refresh";
            btnRefreshPlans.UseVisualStyleBackColor = true;
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
    }
}
