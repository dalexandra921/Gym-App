namespace GymApp_final.Controls
{
    partial class MyBookingsControl
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
            btnRefresh = new Button();
            btnCancel = new Button();
            gridMyBookings = new DataGridView();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMyBookings).BeginInit();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnRefresh);
            panelBottom.Controls.Add(btnCancel);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 459);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(794, 88);
            panelBottom.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(534, 33);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refesh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(215, 33);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Anulează";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // gridMyBookings
            // 
            gridMyBookings.AllowUserToAddRows = false;
            gridMyBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMyBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMyBookings.Dock = DockStyle.Fill;
            gridMyBookings.Location = new Point(0, 0);
            gridMyBookings.MultiSelect = false;
            gridMyBookings.Name = "gridMyBookings";
            gridMyBookings.ReadOnly = true;
            gridMyBookings.RowHeadersWidth = 51;
            gridMyBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridMyBookings.Size = new Size(794, 459);
            gridMyBookings.TabIndex = 1;
            // 
            // MyBookingsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridMyBookings);
            Controls.Add(panelBottom);
            Name = "MyBookingsControl";
            Size = new Size(794, 547);
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridMyBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private Button btnRefresh;
        private Button btnCancel;
        private DataGridView gridMyBookings;
    }
}
