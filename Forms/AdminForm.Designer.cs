namespace GymApp_final
{
    partial class AdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabMain = new TabControl();
            tabPlans = new TabPage();
            PlansControl = new GymApp_final.Controls.PlansControl();
            tabClasses = new TabPage();
            ClassesControl = new GymApp_final.Controls.ClassesControl();
            tabTrainers = new TabPage();
            TrainersControl = new GymApp_final.Controls.TrainersControl();
            tabStats = new TabPage();
            adminStatsControl1 = new GymApp_final.Controls.AdminStatsControl();
            tabMain.SuspendLayout();
            tabPlans.SuspendLayout();
            tabClasses.SuspendLayout();
            tabTrainers.SuspendLayout();
            tabStats.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPlans);
            tabMain.Controls.Add(tabClasses);
            tabMain.Controls.Add(tabTrainers);
            tabMain.Controls.Add(tabStats);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(843, 612);
            tabMain.TabIndex = 0;
            // 
            // tabPlans
            // 
            tabPlans.Controls.Add(PlansControl);
            tabPlans.Location = new Point(4, 29);
            tabPlans.Name = "tabPlans";
            tabPlans.Padding = new Padding(3);
            tabPlans.Size = new Size(835, 579);
            tabPlans.TabIndex = 0;
            tabPlans.Text = "Abonamente";
            tabPlans.UseVisualStyleBackColor = true;
            // 
            // PlansControl
            // 
            PlansControl.Dock = DockStyle.Fill;
            PlansControl.Location = new Point(3, 3);
            PlansControl.Name = "PlansControl";
            PlansControl.Size = new Size(829, 573);
            PlansControl.TabIndex = 0;
            // 
            // tabClasses
            // 
            tabClasses.Controls.Add(ClassesControl);
            tabClasses.Location = new Point(4, 29);
            tabClasses.Name = "tabClasses";
            tabClasses.Padding = new Padding(3);
            tabClasses.Size = new Size(835, 579);
            tabClasses.TabIndex = 1;
            tabClasses.Text = "Clase";
            tabClasses.UseVisualStyleBackColor = true;
            // 
            // ClassesControl
            // 
            ClassesControl.Dock = DockStyle.Fill;
            ClassesControl.Location = new Point(3, 3);
            ClassesControl.Name = "ClassesControl";
            ClassesControl.Size = new Size(829, 573);
            ClassesControl.TabIndex = 0;
            // 
            // tabTrainers
            // 
            tabTrainers.Controls.Add(TrainersControl);
            tabTrainers.Location = new Point(4, 29);
            tabTrainers.Name = "tabTrainers";
            tabTrainers.Padding = new Padding(3);
            tabTrainers.Size = new Size(835, 579);
            tabTrainers.TabIndex = 2;
            tabTrainers.Text = "Antrenori";
            tabTrainers.UseVisualStyleBackColor = true;
            // 
            // TrainersControl
            // 
            TrainersControl.Dock = DockStyle.Fill;
            TrainersControl.Location = new Point(3, 3);
            TrainersControl.Name = "TrainersControl";
            TrainersControl.Size = new Size(829, 573);
            TrainersControl.TabIndex = 0;
            // 
            // tabStats
            // 
            tabStats.Controls.Add(adminStatsControl1);
            tabStats.Location = new Point(4, 29);
            tabStats.Name = "tabStats";
            tabStats.Padding = new Padding(3);
            tabStats.Size = new Size(835, 579);
            tabStats.TabIndex = 3;
            tabStats.Text = "Statistici";
            tabStats.UseVisualStyleBackColor = true;
            // 
            // adminStatsControl1
            // 
            adminStatsControl1.Dock = DockStyle.Fill;
            adminStatsControl1.Location = new Point(3, 3);
            adminStatsControl1.Name = "adminStatsControl1";
            adminStatsControl1.Size = new Size(829, 573);
            adminStatsControl1.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 612);
            Controls.Add(tabMain);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tabMain.ResumeLayout(false);
            tabPlans.ResumeLayout(false);
            tabClasses.ResumeLayout(false);
            tabTrainers.ResumeLayout(false);
            tabStats.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabPlans;
        private TabPage tabClasses;
        private Controls.PlansControl PlansControl;
        private Controls.ClassesControl ClassesControl;
        private TabPage tabTrainers;
        private Controls.TrainersControl TrainersControl;
        private TabPage tabStats;
        private Controls.AdminStatsControl adminStatsControl1;
    }
}