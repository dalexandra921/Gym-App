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
            tabTrainers = new TabControl();
            tabPlans = new TabPage();
            PlansControl = new GymApp_final.Controls.PlansControl();
            tabClasses = new TabPage();
            classesControl1 = new GymApp_final.Controls.ClassesControl();
            tabPage1 = new TabPage();
            trainersControl1 = new GymApp_final.Controls.TrainersControl();
            tabTrainers.SuspendLayout();
            tabPlans.SuspendLayout();
            tabClasses.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabTrainers
            // 
            tabTrainers.Controls.Add(tabPlans);
            tabTrainers.Controls.Add(tabClasses);
            tabTrainers.Controls.Add(tabPage1);
            tabTrainers.Dock = DockStyle.Fill;
            tabTrainers.Location = new Point(0, 0);
            tabTrainers.Name = "tabTrainers";
            tabTrainers.SelectedIndex = 0;
            tabTrainers.Size = new Size(843, 612);
            tabTrainers.TabIndex = 0;
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
            tabClasses.Controls.Add(classesControl1);
            tabClasses.Location = new Point(4, 29);
            tabClasses.Name = "tabClasses";
            tabClasses.Padding = new Padding(3);
            tabClasses.Size = new Size(835, 579);
            tabClasses.TabIndex = 1;
            tabClasses.Text = "Clase";
            tabClasses.UseVisualStyleBackColor = true;
            // 
            // classesControl1
            // 
            classesControl1.Dock = DockStyle.Fill;
            classesControl1.Location = new Point(3, 3);
            classesControl1.Name = "classesControl1";
            classesControl1.Size = new Size(829, 573);
            classesControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(trainersControl1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(835, 579);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Antrenori";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // trainersControl1
            // 
            trainersControl1.Dock = DockStyle.Fill;
            trainersControl1.Location = new Point(3, 3);
            trainersControl1.Name = "trainersControl1";
            trainersControl1.Size = new Size(829, 573);
            trainersControl1.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 612);
            Controls.Add(tabTrainers);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tabTrainers.ResumeLayout(false);
            tabPlans.ResumeLayout(false);
            tabClasses.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabTrainers;
        private TabPage tabPlans;
        private TabPage tabClasses;
        private Controls.PlansControl PlansControl;
        private Controls.ClassesControl classesControl1;
        private TabPage tabPage1;
        private Controls.TrainersControl trainersControl1;
    }
}