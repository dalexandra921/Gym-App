namespace GymApp_final.Controls
{
    partial class ClientScheduleControl
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
            panelBottom = new Panel();
            lblInfo = new Label();
            btnReserve = new Button();
            gridSchedule = new DataGridView();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSchedule).BeginInit();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(lblInfo);
            panelBottom.Controls.Add(btnReserve);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 452);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(899, 78);
            panelBottom.TabIndex = 1;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(25, 31);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(246, 20);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Selectează o clasă și apasă Rezervă.";
            // 
            // btnReserve
            // 
            btnReserve.Location = new Point(729, 22);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(94, 29);
            btnReserve.TabIndex = 0;
            btnReserve.Text = "Rezervă";
            btnReserve.UseVisualStyleBackColor = true;
            // 
            // gridSchedule
            // 
            gridSchedule.AllowUserToAddRows = false;
            gridSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSchedule.Dock = DockStyle.Fill;
            gridSchedule.Location = new Point(0, 0);
            gridSchedule.MultiSelect = false;
            gridSchedule.Name = "gridSchedule";
            gridSchedule.ReadOnly = true;
            gridSchedule.RowHeadersWidth = 51;
            gridSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSchedule.Size = new Size(899, 452);
            gridSchedule.TabIndex = 2;
            // 
            // ClientScheduleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridSchedule);
            Controls.Add(panelBottom);
            Name = "ClientScheduleControl";
            Size = new Size(899, 530);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBottom;
        private Button btnReserve;
        private Label lblInfo;
        private DataGridView gridSchedule;
    }
}
