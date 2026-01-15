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
            AdminStatsControl = new GymApp_final.Controls.AdminStatsControl();
            tabZones = new TabPage();
            ZonesControl = new GymApp_final.Controls.ZonesControl();
            tabRooms = new TabPage();
            RoomsControl = new GymApp_final.Controls.RoomsControl();
            tabBookings = new TabPage();
            adminBookingsViewControl1 = new GymApp_final.Controls.AdminBookingsViewControl();
            tabMain.SuspendLayout();
            tabPlans.SuspendLayout();
            tabClasses.SuspendLayout();
            tabTrainers.SuspendLayout();
            tabStats.SuspendLayout();
            tabZones.SuspendLayout();
            tabRooms.SuspendLayout();
            tabBookings.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPlans);
            tabMain.Controls.Add(tabClasses);
            tabMain.Controls.Add(tabTrainers);
            tabMain.Controls.Add(tabStats);
            tabMain.Controls.Add(tabZones);
            tabMain.Controls.Add(tabRooms);
            tabMain.Controls.Add(tabBookings);
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
            tabStats.Controls.Add(AdminStatsControl);
            tabStats.Location = new Point(4, 29);
            tabStats.Name = "tabStats";
            tabStats.Padding = new Padding(3);
            tabStats.Size = new Size(835, 579);
            tabStats.TabIndex = 3;
            tabStats.Text = "Statistici";
            tabStats.UseVisualStyleBackColor = true;
            // 
            // AdminStatsControl
            // 
            AdminStatsControl.Dock = DockStyle.Fill;
            AdminStatsControl.Location = new Point(3, 3);
            AdminStatsControl.Name = "AdminStatsControl";
            AdminStatsControl.Size = new Size(829, 573);
            AdminStatsControl.TabIndex = 0;
            // 
            // tabZones
            // 
            tabZones.Controls.Add(ZonesControl);
            tabZones.Location = new Point(4, 29);
            tabZones.Name = "tabZones";
            tabZones.Padding = new Padding(3);
            tabZones.Size = new Size(835, 579);
            tabZones.TabIndex = 4;
            tabZones.Text = "Zone";
            tabZones.UseVisualStyleBackColor = true;
            // 
            // ZonesControl
            // 
            ZonesControl.Dock = DockStyle.Fill;
            ZonesControl.Location = new Point(3, 3);
            ZonesControl.Name = "ZonesControl";
            ZonesControl.Size = new Size(829, 573);
            ZonesControl.TabIndex = 0;
            // 
            // tabRooms
            // 
            tabRooms.Controls.Add(RoomsControl);
            tabRooms.Location = new Point(4, 29);
            tabRooms.Name = "tabRooms";
            tabRooms.Padding = new Padding(3);
            tabRooms.Size = new Size(835, 579);
            tabRooms.TabIndex = 5;
            tabRooms.Text = "Săli";
            tabRooms.UseVisualStyleBackColor = true;
            // 
            // RoomsControl
            // 
            RoomsControl.Dock = DockStyle.Fill;
            RoomsControl.Location = new Point(3, 3);
            RoomsControl.Name = "RoomsControl";
            RoomsControl.Size = new Size(829, 573);
            RoomsControl.TabIndex = 0;
            // 
            // tabBookings
            // 
            tabBookings.Controls.Add(adminBookingsViewControl1);
            tabBookings.Location = new Point(4, 29);
            tabBookings.Name = "tabBookings";
            tabBookings.Padding = new Padding(3);
            tabBookings.Size = new Size(835, 579);
            tabBookings.TabIndex = 6;
            tabBookings.Text = "Rezervări";
            tabBookings.UseVisualStyleBackColor = true;
            tabBookings.Enter += tabBookings_Enter;
            // 
            // adminBookingsViewControl1
            // 
            adminBookingsViewControl1.Dock = DockStyle.Fill;
            adminBookingsViewControl1.Location = new Point(3, 3);
            adminBookingsViewControl1.Name = "adminBookingsViewControl1";
            adminBookingsViewControl1.Size = new Size(829, 573);
            adminBookingsViewControl1.TabIndex = 0;
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
            tabZones.ResumeLayout(false);
            tabRooms.ResumeLayout(false);
            tabBookings.ResumeLayout(false);
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
        private Controls.AdminStatsControl AdminStatsControl;
        private TabPage tabZones;
        private Controls.ZonesControl ZonesControl;
        private TabPage tabRooms;
        private Controls.RoomsControl RoomsControl;
        private TabPage tabBookings;
        private Controls.AdminBookingsViewControl adminBookingsViewControl1;
    }
}