namespace GymApp_final.Controls
{
    partial class SubscriptionsControl
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
            splitSubs = new SplitContainer();
            gridPlansClient = new DataGridView();
            panelBuy = new Panel();
            btnBuy = new Button();
            gridMySubs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitSubs).BeginInit();
            splitSubs.Panel1.SuspendLayout();
            splitSubs.Panel2.SuspendLayout();
            splitSubs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPlansClient).BeginInit();
            panelBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMySubs).BeginInit();
            SuspendLayout();
            // 
            // splitSubs
            // 
            splitSubs.Dock = DockStyle.Fill;
            splitSubs.Location = new Point(0, 0);
            splitSubs.Name = "splitSubs";
            splitSubs.Orientation = Orientation.Horizontal;
            // 
            // splitSubs.Panel1
            // 
            splitSubs.Panel1.Controls.Add(panelBuy);
            splitSubs.Panel1.Controls.Add(gridPlansClient);
            // 
            // splitSubs.Panel2
            // 
            splitSubs.Panel2.Controls.Add(gridMySubs);
            splitSubs.Size = new Size(789, 573);
            splitSubs.SplitterDistance = 220;
            splitSubs.TabIndex = 0;
            // 
            // gridPlansClient
            // 
            gridPlansClient.AllowUserToAddRows = false;
            gridPlansClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridPlansClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPlansClient.Dock = DockStyle.Fill;
            gridPlansClient.Location = new Point(0, 0);
            gridPlansClient.MultiSelect = false;
            gridPlansClient.Name = "gridPlansClient";
            gridPlansClient.ReadOnly = true;
            gridPlansClient.RowHeadersWidth = 51;
            gridPlansClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPlansClient.Size = new Size(789, 220);
            gridPlansClient.TabIndex = 0;
            // 
            // panelBuy
            // 
            panelBuy.Controls.Add(btnBuy);
            panelBuy.Dock = DockStyle.Bottom;
            panelBuy.Location = new Point(0, 165);
            panelBuy.Name = "panelBuy";
            panelBuy.Size = new Size(789, 55);
            panelBuy.TabIndex = 0;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(601, 14);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(94, 29);
            btnBuy.TabIndex = 0;
            btnBuy.Text = "Cumpără";
            btnBuy.UseVisualStyleBackColor = true;
            // 
            // gridMySubs
            // 
            gridMySubs.AllowUserToAddRows = false;
            gridMySubs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMySubs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMySubs.Dock = DockStyle.Fill;
            gridMySubs.Location = new Point(0, 0);
            gridMySubs.MultiSelect = false;
            gridMySubs.Name = "gridMySubs";
            gridMySubs.ReadOnly = true;
            gridMySubs.RowHeadersWidth = 51;
            gridMySubs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridMySubs.Size = new Size(789, 349);
            gridMySubs.TabIndex = 0;
            // 
            // SubscriptionsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitSubs);
            Name = "SubscriptionsControl";
            Size = new Size(789, 573);
            splitSubs.Panel1.ResumeLayout(false);
            splitSubs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitSubs).EndInit();
            splitSubs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPlansClient).EndInit();
            panelBuy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridMySubs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitSubs;
        private DataGridView gridPlansClient;
        private Panel panelBuy;
        private Button btnBuy;
        private DataGridView gridMySubs;
    }
}
