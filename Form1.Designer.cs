namespace WorkoutTrackingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            buttonProgress = new Button();
            buttonSettings = new Button();
            buttonDashboard = new Button();
            buttonWorkoutPlan = new Button();
            buttonExercises = new Button();
            panelContent = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(23, 24, 29);
            panelSidebar.Controls.Add(buttonProgress);
            panelSidebar.Controls.Add(buttonSettings);
            panelSidebar.Controls.Add(buttonDashboard);
            panelSidebar.Controls.Add(buttonWorkoutPlan);
            panelSidebar.Controls.Add(buttonExercises);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.ForeColor = SystemColors.ControlText;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(280, 771);
            panelSidebar.TabIndex = 0;
            // 
            // buttonProgress
            // 
            buttonProgress.BackColor = Color.FromArgb(23, 24, 29);
            buttonProgress.Cursor = Cursors.Hand;
            buttonProgress.FlatAppearance.BorderSize = 0;
            buttonProgress.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 64, 74);
            buttonProgress.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 54, 64);
            buttonProgress.FlatStyle = FlatStyle.Flat;
            buttonProgress.Font = new Font("Uni Sans  ", 20F);
            buttonProgress.ForeColor = Color.White;
            buttonProgress.Location = new Point(20, 300);
            buttonProgress.Name = "buttonProgress";
            buttonProgress.Padding = new Padding(5);
            buttonProgress.Size = new Size(240, 60);
            buttonProgress.TabIndex = 2;
            buttonProgress.Text = "Progress";
            buttonProgress.UseVisualStyleBackColor = false;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(23, 24, 29);
            buttonSettings.Cursor = Cursors.Hand;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 64, 74);
            buttonSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 54, 64);
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Uni Sans  ", 20F);
            buttonSettings.ForeColor = Color.White;
            buttonSettings.Location = new Point(20, 390);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Padding = new Padding(5);
            buttonSettings.Size = new Size(240, 60);
            buttonSettings.TabIndex = 4;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = false;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.FromArgb(52, 54, 64);
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 64, 74);
            buttonDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 54, 64);
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Uni Sans  ", 20F);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Location = new Point(20, 30);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(5);
            buttonDashboard.Size = new Size(240, 60);
            buttonDashboard.TabIndex = 0;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = false;
            // 
            // buttonWorkoutPlan
            // 
            buttonWorkoutPlan.BackColor = Color.FromArgb(23, 24, 29);
            buttonWorkoutPlan.Cursor = Cursors.Hand;
            buttonWorkoutPlan.FlatAppearance.BorderSize = 0;
            buttonWorkoutPlan.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 64, 74);
            buttonWorkoutPlan.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 54, 64);
            buttonWorkoutPlan.FlatStyle = FlatStyle.Flat;
            buttonWorkoutPlan.Font = new Font("Uni Sans  ", 20F);
            buttonWorkoutPlan.ForeColor = Color.White;
            buttonWorkoutPlan.Location = new Point(20, 120);
            buttonWorkoutPlan.Name = "buttonWorkoutPlan";
            buttonWorkoutPlan.Padding = new Padding(5);
            buttonWorkoutPlan.Size = new Size(240, 60);
            buttonWorkoutPlan.TabIndex = 1;
            buttonWorkoutPlan.Text = "Workout Plan";
            buttonWorkoutPlan.UseVisualStyleBackColor = false;
            // 
            // buttonExercises
            // 
            buttonExercises.BackColor = Color.FromArgb(23, 24, 29);
            buttonExercises.Cursor = Cursors.Hand;
            buttonExercises.FlatAppearance.BorderSize = 0;
            buttonExercises.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 64, 74);
            buttonExercises.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 54, 64);
            buttonExercises.FlatStyle = FlatStyle.Flat;
            buttonExercises.Font = new Font("Uni Sans  ", 20F);
            buttonExercises.ForeColor = Color.White;
            buttonExercises.Location = new Point(20, 210);
            buttonExercises.Name = "buttonExercises";
            buttonExercises.Padding = new Padding(5);
            buttonExercises.Size = new Size(240, 60);
            buttonExercises.TabIndex = 3;
            buttonExercises.Text = "Exercises";
            buttonExercises.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(41, 42, 49);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(280, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1144, 771);
            panelContent.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 39);
            ClientSize = new Size(1424, 771);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelContent;
        private Button buttonDashboard;
        private Button buttonWorkoutPlan;
        private Button buttonSettings;
        private Button buttonExercises;
        private Button buttonProgress;
    }
}
