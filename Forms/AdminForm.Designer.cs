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
            tabAdmin = new TabControl();
            tabPlans = new TabPage();
            PlansControl = new GymApp_final.Controls.PlansControl();
            tabClasses = new TabPage();
            classesControl1 = new GymApp_final.Controls.ClassesControl();
            tabAdmin.SuspendLayout();
            tabPlans.SuspendLayout();
            tabClasses.SuspendLayout();
            SuspendLayout();
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(tabPlans);
            tabAdmin.Controls.Add(tabClasses);
            tabAdmin.Dock = DockStyle.Fill;
            tabAdmin.Location = new Point(0, 0);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.SelectedIndex = 0;
            tabAdmin.Size = new Size(800, 514);
            tabAdmin.TabIndex = 0;
            // 
            // tabPlans
            // 
            tabPlans.Controls.Add(PlansControl);
            tabPlans.Location = new Point(4, 29);
            tabPlans.Name = "tabPlans";
            tabPlans.Padding = new Padding(3);
            tabPlans.Size = new Size(792, 481);
            tabPlans.TabIndex = 0;
            tabPlans.Text = "Abonamente";
            tabPlans.UseVisualStyleBackColor = true;
            // 
            // PlansControl
            // 
            PlansControl.Dock = DockStyle.Fill;
            PlansControl.Location = new Point(3, 3);
            PlansControl.Name = "PlansControl";
            PlansControl.Size = new Size(786, 475);
            PlansControl.TabIndex = 0;
            // 
            // tabClasses
            // 
            tabClasses.Controls.Add(classesControl1);
            tabClasses.Location = new Point(4, 29);
            tabClasses.Name = "tabClasses";
            tabClasses.Padding = new Padding(3);
            tabClasses.Size = new Size(792, 481);
            tabClasses.TabIndex = 1;
            tabClasses.Text = "Clase";
            tabClasses.UseVisualStyleBackColor = true;
            // 
            // classesControl1
            // 
            classesControl1.Dock = DockStyle.Fill;
            classesControl1.Location = new Point(3, 3);
            classesControl1.Name = "classesControl1";
            classesControl1.Size = new Size(786, 475);
            classesControl1.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(tabAdmin);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += AdminForm_Load;
            tabAdmin.ResumeLayout(false);
            tabPlans.ResumeLayout(false);
            tabClasses.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAdmin;
        private TabPage tabPlans;
        private TabPage tabClasses;
        private Controls.PlansControl PlansControl;
        private Controls.ClassesControl classesControl1;
    }
}