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
            buttonSettings = new Button();
            buttonExercises = new Button();
            buttonProgress = new Button();
            buttonWorkoutPlan = new Button();
            buttonDashboard = new Button();
            panelContent = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(23, 24, 29);
            panelSidebar.Controls.Add(buttonSettings);
            panelSidebar.Controls.Add(buttonExercises);
            panelSidebar.Controls.Add(buttonProgress);
            panelSidebar.Controls.Add(buttonWorkoutPlan);
            panelSidebar.Controls.Add(buttonDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.ForeColor = SystemColors.ControlText;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.MaximumSize = new Size(200, 0);
            panelSidebar.MinimumSize = new Size(200, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 450);
            panelSidebar.TabIndex = 0;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(23, 24, 29);
            buttonSettings.Cursor = Cursors.Hand;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 54, 64);
            buttonSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 54, 64);
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI", 10F);
            buttonSettings.ForeColor = Color.White;
            buttonSettings.Location = new Point(9, 216);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Padding = new Padding(5);
            buttonSettings.Size = new Size(182, 45);
            buttonSettings.TabIndex = 4;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = false;
            // 
            // buttonExercises
            // 
            buttonExercises.BackColor = Color.FromArgb(23, 24, 29);
            buttonExercises.Cursor = Cursors.Hand;
            buttonExercises.FlatAppearance.BorderSize = 0;
            buttonExercises.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 54, 64);
            buttonExercises.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 54, 64);
            buttonExercises.FlatStyle = FlatStyle.Flat;
            buttonExercises.Font = new Font("Segoe UI", 10F);
            buttonExercises.ForeColor = Color.White;
            buttonExercises.Location = new Point(9, 114);
            buttonExercises.Name = "buttonExercises";
            buttonExercises.Padding = new Padding(5);
            buttonExercises.Size = new Size(182, 45);
            buttonExercises.TabIndex = 3;
            buttonExercises.Text = "Exercises";
            buttonExercises.UseVisualStyleBackColor = false;
            // 
            // buttonProgress
            // 
            buttonProgress.BackColor = Color.FromArgb(23, 24, 29);
            buttonProgress.Cursor = Cursors.Hand;
            buttonProgress.FlatAppearance.BorderSize = 0;
            buttonProgress.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 54, 64);
            buttonProgress.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 54, 64);
            buttonProgress.FlatStyle = FlatStyle.Flat;
            buttonProgress.Font = new Font("Segoe UI", 10F);
            buttonProgress.ForeColor = Color.White;
            buttonProgress.Location = new Point(9, 165);
            buttonProgress.Name = "buttonProgress";
            buttonProgress.Padding = new Padding(5);
            buttonProgress.Size = new Size(182, 45);
            buttonProgress.TabIndex = 2;
            buttonProgress.Text = "Progress";
            buttonProgress.UseVisualStyleBackColor = false;
            // 
            // buttonWorkoutPlan
            // 
            buttonWorkoutPlan.BackColor = Color.FromArgb(23, 24, 29);
            buttonWorkoutPlan.Cursor = Cursors.Hand;
            buttonWorkoutPlan.FlatAppearance.BorderSize = 0;
            buttonWorkoutPlan.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 54, 64);
            buttonWorkoutPlan.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 54, 64);
            buttonWorkoutPlan.FlatStyle = FlatStyle.Flat;
            buttonWorkoutPlan.Font = new Font("Segoe UI", 10F);
            buttonWorkoutPlan.ForeColor = Color.White;
            buttonWorkoutPlan.Location = new Point(9, 63);
            buttonWorkoutPlan.Name = "buttonWorkoutPlan";
            buttonWorkoutPlan.Padding = new Padding(5);
            buttonWorkoutPlan.Size = new Size(182, 45);
            buttonWorkoutPlan.TabIndex = 1;
            buttonWorkoutPlan.Text = "Workout Plan";
            buttonWorkoutPlan.UseVisualStyleBackColor = false;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.FromArgb(52, 54, 64);
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 54, 64);
            buttonDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 54, 64);
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 10F);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Location = new Point(9, 12);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(5);
            buttonDashboard.Size = new Size(182, 45);
            buttonDashboard.TabIndex = 0;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(41, 42, 49);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(600, 450);
            panelContent.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 39);
            ClientSize = new Size(800, 450);
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
