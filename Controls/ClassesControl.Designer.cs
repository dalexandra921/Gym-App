namespace GymApp_final.Controls
{
    partial class ClassesControl
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
            gridClasses = new DataGridView();
            panelEdit = new Panel();
            lblAccess = new Label();
            cmbRequiredAccessLevel = new ComboBox();
            btnRefreshClasses = new Button();
            btnDeleteClass = new Button();
            btnUpdateClass = new Button();
            btnAddClass = new Button();
            dtpStartTime = new DateTimePicker();
            lblStartTime = new Label();
            numCapacity = new NumericUpDown();
            lblCapacity = new Label();
            numDuration = new NumericUpDown();
            lblDuration = new Label();
            txtTrainer = new TextBox();
            lblTrainer = new Label();
            txtClassTitle = new TextBox();
            lblClassTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)gridClasses).BeginInit();
            panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            SuspendLayout();
            // 
            // gridClasses
            // 
            gridClasses.AllowUserToAddRows = false;
            gridClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClasses.Dock = DockStyle.Top;
            gridClasses.Location = new Point(0, 0);
            gridClasses.MultiSelect = false;
            gridClasses.Name = "gridClasses";
            gridClasses.ReadOnly = true;
            gridClasses.RowHeadersWidth = 51;
            gridClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClasses.Size = new Size(878, 159);
            gridClasses.TabIndex = 0;
            // 
            // panelEdit
            // 
            panelEdit.Controls.Add(lblAccess);
            panelEdit.Controls.Add(cmbRequiredAccessLevel);
            panelEdit.Controls.Add(btnRefreshClasses);
            panelEdit.Controls.Add(btnDeleteClass);
            panelEdit.Controls.Add(btnUpdateClass);
            panelEdit.Controls.Add(btnAddClass);
            panelEdit.Controls.Add(dtpStartTime);
            panelEdit.Controls.Add(lblStartTime);
            panelEdit.Controls.Add(numCapacity);
            panelEdit.Controls.Add(lblCapacity);
            panelEdit.Controls.Add(numDuration);
            panelEdit.Controls.Add(lblDuration);
            panelEdit.Controls.Add(txtTrainer);
            panelEdit.Controls.Add(lblTrainer);
            panelEdit.Controls.Add(txtClassTitle);
            panelEdit.Controls.Add(lblClassTitle);
            panelEdit.Dock = DockStyle.Fill;
            panelEdit.Location = new Point(0, 159);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(878, 351);
            panelEdit.TabIndex = 1;
            // 
            // lblAccess
            // 
            lblAccess.AutoSize = true;
            lblAccess.Location = new Point(27, 302);
            lblAccess.Name = "lblAccess";
            lblAccess.Size = new Size(72, 20);
            lblAccess.TabIndex = 15;
            lblAccess.Text = "Tip acess:";
            // 
            // cmbRequiredAccessLevel
            // 
            cmbRequiredAccessLevel.FormattingEnabled = true;
            cmbRequiredAccessLevel.Location = new Point(179, 302);
            cmbRequiredAccessLevel.Name = "cmbRequiredAccessLevel";
            cmbRequiredAccessLevel.Size = new Size(200, 28);
            cmbRequiredAccessLevel.TabIndex = 14;
            // 
            // btnRefreshClasses
            // 
            btnRefreshClasses.Location = new Point(548, 243);
            btnRefreshClasses.Name = "btnRefreshClasses";
            btnRefreshClasses.Size = new Size(94, 29);
            btnRefreshClasses.TabIndex = 13;
            btnRefreshClasses.Text = "Refresh";
            btnRefreshClasses.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClass
            // 
            btnDeleteClass.Location = new Point(548, 139);
            btnDeleteClass.Name = "btnDeleteClass";
            btnDeleteClass.Size = new Size(94, 29);
            btnDeleteClass.TabIndex = 12;
            btnDeleteClass.Text = "Delete";
            btnDeleteClass.UseVisualStyleBackColor = true;
            // 
            // btnUpdateClass
            // 
            btnUpdateClass.Location = new Point(548, 84);
            btnUpdateClass.Name = "btnUpdateClass";
            btnUpdateClass.Size = new Size(94, 29);
            btnUpdateClass.TabIndex = 11;
            btnUpdateClass.Text = "Update";
            btnUpdateClass.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            btnAddClass.Location = new Point(548, 34);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(94, 29);
            btnAddClass.TabIndex = 10;
            btnAddClass.Text = "Add";
            btnAddClass.UseVisualStyleBackColor = true;
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(179, 247);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(200, 27);
            dtpStartTime.TabIndex = 9;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(28, 252);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(71, 20);
            lblStartTime.TabIndex = 8;
            lblStartTime.Text = "Data/Ora";
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(179, 187);
            numCapacity.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(200, 27);
            numCapacity.TabIndex = 7;
            numCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(28, 187);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(80, 20);
            lblCapacity.TabIndex = 6;
            lblCapacity.Text = "Capacitate";
            // 
            // numDuration
            // 
            numDuration.Location = new Point(179, 139);
            numDuration.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numDuration.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(200, 27);
            numDuration.TabIndex = 5;
            numDuration.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(28, 139);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(93, 20);
            lblDuration.TabIndex = 4;
            lblDuration.Text = "Durată (min)";
            // 
            // txtTrainer
            // 
            txtTrainer.Location = new Point(179, 84);
            txtTrainer.Name = "txtTrainer";
            txtTrainer.Size = new Size(200, 27);
            txtTrainer.TabIndex = 3;
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.Location = new Point(28, 84);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Size = new Size(67, 20);
            lblTrainer.TabIndex = 2;
            lblTrainer.Text = "Antrenor";
            // 
            // txtClassTitle
            // 
            txtClassTitle.Location = new Point(179, 31);
            txtClassTitle.Name = "txtClassTitle";
            txtClassTitle.Size = new Size(200, 27);
            txtClassTitle.TabIndex = 1;
            // 
            // lblClassTitle
            // 
            lblClassTitle.AutoSize = true;
            lblClassTitle.Location = new Point(28, 31);
            lblClassTitle.Name = "lblClassTitle";
            lblClassTitle.Size = new Size(38, 20);
            lblClassTitle.TabIndex = 0;
            lblClassTitle.Text = "Titlu";
            // 
            // ClassesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelEdit);
            Controls.Add(gridClasses);
            Name = "ClassesControl";
            Size = new Size(878, 510);
            ((System.ComponentModel.ISupportInitialize)gridClasses).EndInit();
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridClasses;
        private Panel panelEdit;
        private TextBox txtClassTitle;
        private Label lblClassTitle;
        private TextBox txtTrainer;
        private Label lblTrainer;
        private DateTimePicker dtpStartTime;
        private Label lblStartTime;
        private NumericUpDown numCapacity;
        private Label lblCapacity;
        private NumericUpDown numDuration;
        private Label lblDuration;
        private Button btnRefreshClasses;
        private Button btnDeleteClass;
        private Button btnUpdateClass;
        private Button btnAddClass;
        private Label lblAccess;
        private ComboBox cmbRequiredAccessLevel;
    }
}
