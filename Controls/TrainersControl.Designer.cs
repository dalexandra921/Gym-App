namespace GymApp_final.Controls
{
    partial class TrainersControl
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
            gridTrainers = new DataGridView();
            lblNume = new Label();
            txtTrainerName = new TextBox();
            txtTrainerSpec = new TextBox();
            lblSpec = new Label();
            btnAddTrainer = new Button();
            btnUpdateTrainer = new Button();
            btnDeleteTrainer = new Button();
            btnRefreshTrainer = new Button();
            ((System.ComponentModel.ISupportInitialize)gridTrainers).BeginInit();
            SuspendLayout();
            // 
            // gridTrainers
            // 
            gridTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTrainers.Dock = DockStyle.Top;
            gridTrainers.Location = new Point(0, 0);
            gridTrainers.Name = "gridTrainers";
            gridTrainers.RowHeadersWidth = 51;
            gridTrainers.Size = new Size(826, 250);
            gridTrainers.TabIndex = 0;
            // 
            // lblNume
            // 
            lblNume.AutoSize = true;
            lblNume.Location = new Point(38, 307);
            lblNume.Name = "lblNume";
            lblNume.Size = new Size(49, 20);
            lblNume.TabIndex = 1;
            lblNume.Text = "Nume";
            // 
            // txtTrainerName
            // 
            txtTrainerName.Location = new Point(163, 304);
            txtTrainerName.Name = "txtTrainerName";
            txtTrainerName.Size = new Size(188, 27);
            txtTrainerName.TabIndex = 2;
            // 
            // txtTrainerSpec
            // 
            txtTrainerSpec.Location = new Point(163, 354);
            txtTrainerSpec.Name = "txtTrainerSpec";
            txtTrainerSpec.Size = new Size(188, 27);
            txtTrainerSpec.TabIndex = 3;
            // 
            // lblSpec
            // 
            lblSpec.AutoSize = true;
            lblSpec.Location = new Point(38, 357);
            lblSpec.Name = "lblSpec";
            lblSpec.Size = new Size(89, 20);
            lblSpec.TabIndex = 4;
            lblSpec.Text = "Specializare";
            // 
            // btnAddTrainer
            // 
            btnAddTrainer.Location = new Point(444, 298);
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Size = new Size(94, 29);
            btnAddTrainer.TabIndex = 5;
            btnAddTrainer.Text = "Add";
            btnAddTrainer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTrainer
            // 
            btnUpdateTrainer.Location = new Point(444, 353);
            btnUpdateTrainer.Name = "btnUpdateTrainer";
            btnUpdateTrainer.Size = new Size(94, 29);
            btnUpdateTrainer.TabIndex = 6;
            btnUpdateTrainer.Text = "Update";
            btnUpdateTrainer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTrainer
            // 
            btnDeleteTrainer.Location = new Point(444, 412);
            btnDeleteTrainer.Name = "btnDeleteTrainer";
            btnDeleteTrainer.Size = new Size(94, 29);
            btnDeleteTrainer.TabIndex = 7;
            btnDeleteTrainer.Text = "Delete";
            btnDeleteTrainer.UseVisualStyleBackColor = true;
            // 
            // btnRefreshTrainer
            // 
            btnRefreshTrainer.Location = new Point(444, 467);
            btnRefreshTrainer.Name = "btnRefreshTrainer";
            btnRefreshTrainer.Size = new Size(94, 29);
            btnRefreshTrainer.TabIndex = 8;
            btnRefreshTrainer.Text = "Refresh";
            btnRefreshTrainer.UseVisualStyleBackColor = true;
            // 
            // TrainersControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefreshTrainer);
            Controls.Add(btnDeleteTrainer);
            Controls.Add(btnUpdateTrainer);
            Controls.Add(btnAddTrainer);
            Controls.Add(lblSpec);
            Controls.Add(txtTrainerSpec);
            Controls.Add(txtTrainerName);
            Controls.Add(lblNume);
            Controls.Add(gridTrainers);
            Name = "TrainersControl";
            Size = new Size(826, 556);
            ((System.ComponentModel.ISupportInitialize)gridTrainers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridTrainers;
        private Label lblNume;
        private TextBox txtTrainerName;
        private TextBox txtTrainerSpec;
        private Label lblSpec;
        private Button btnAddTrainer;
        private Button btnUpdateTrainer;
        private Button btnDeleteTrainer;
        private Button btnRefreshTrainer;
    }
}
